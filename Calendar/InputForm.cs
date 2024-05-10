using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calendar
{
    public partial class InputForm : Form
    {
        public int year, month, day;
        List<Data> datas = new List<Data>();
        Data tofile;
        string otherdata = "";
        bool first = true;

        public void Clean()
        {
            textBox_input.Clear();
            textBox1.Clear();
            checkBox1.Checked = false;
            checkedListBox1.Items.Clear();
            
        }

        private void AddToDB()
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\babur\\OneDrive\\Рабочий стол\\Calendar\\DB.txt", false))
            {
                writer.Write(otherdata);
                for (int i = 0; i < datas.Count; i++)
                {   
                    writer.WriteLine(datas[i].Compil());
                }
            }
            LoadDB();
        }
        public static class Global
        {
            public static Dictionary<string, string> slovar = new Dictionary<string, string>();
        }

        public void ReadSlovar(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string? line = sr.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split("<>");
                    try
                    {
                        Global.slovar.Add(text[0], text[1]);
                    }
                    catch
                    {
                        continue;
                    }
                    line = sr.ReadLine();
                }
            }
        }
        public string Age(int age)
        {
            string age_str = age.ToString();
            string k = "";
            if ((age == 0) || ((age > 4) & (age < 21)) || ((age > 20) & ((age_str.EndsWith("0")) || (age_str.EndsWith("5")) || (age_str.EndsWith("6")) || (age_str.EndsWith("7")) || (age_str.EndsWith("8")) || (age_str.EndsWith("9"))))) k = "лет";
            else if ((age_str == "1") || ((age > 20) & (age_str.EndsWith("1")))) k = "год";
            else if (((age > 1) & (age < 5)) || ((age > 20) & ((age_str.EndsWith("2")) || (age_str.EndsWith("3")) || (age_str.EndsWith("4"))))) k = "года";

            k = age_str + " " + k;
            return k;
        }
        public InputForm()
        {
            InitializeComponent();
            ReadSlovar("C:\\Users\\babur\\OneDrive\\Рабочий стол\\Calendar\\slovar.txt");
            checkedListBox1.CheckOnClick = true;
            textBox1.Visible = false;
            
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            foreach (var item in Global.slovar)
            {
                checkedListBox1.Items.Add(item.Key);
            }
            inputdate.Text = new DateTime(year, month, day).ToString("D");
            textBox_nowtime.Text = DateTime.Now.ToString("t");
            
            LoadDB();
            LoadItems();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputForm_MouseDown(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tofile = new Data(textBox_nowtime.Text, day, month, year);

            if (checkBox1.Checked)
            {
                tofile.note = textBox1.Text;
            }
            if (textBox_input.Text != null)
            {
                tofile.press = textBox_input.Text;
            }
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                foreach (string el in checkedListBox1.CheckedItems)
                {
                    tofile.sympt.Add(el);
                }

            }
            if (datas.Count > 0)
            {
                bool flag = true;
                for (int i = 0; i < datas.Count; i++)
                {   
                    Data data = datas[i];
                    if (data.day == day && data.month == month && data.year == year && data.time == tofile.time)
                    {
                        data.sympt.Clear();
                        data.sympt.AddRange(tofile.sympt);
                        data.note = tofile.note;
                        data.press = tofile.press;
                        flag = false;
                    }
                }
                if (flag)
                {
                    datas.Add(tofile);
                }
            }
            else 
            {
                datas.Add(tofile);
            }
            AddToDB(); 
            Close();
        }

        private void textBox_nowtime_TextChanged(object sender, EventArgs e)
        {
            string[] taketime = textBox_nowtime.Text.Split(":");
            try
            {
                int hours = Convert.ToInt32(taketime[0]);
                int minutes = Convert.ToInt32(taketime[1]);
                if (hours > 23 || minutes > 59)
                {
                    label3.ForeColor = Color.Red;
                    button1.Enabled = false;
                }
                else
                {
                    label3.ForeColor = Color.Black;
                    button1.Enabled = true;
                }
            }
            catch
            {
                button1.Enabled = false;
            }


        }

        private void LoadItems()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\babur\\OneDrive\\Рабочий стол\\Calendar\\DB.txt", Encoding.UTF8))
            {
                string? line = sr.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split("::");
                    try
                    {
                        if (text[1] == Convert.ToString(day) && text[2] == Convert.ToString(month) && text[3] == Convert.ToString(year))
                        {
                            checkedListBox2.Items.Add(text[0]);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                    line = sr.ReadLine();
                }
            }
            checkedListBox2.Items.Add("Добавить запись");
            checkedListBox2.SetSelected(checkedListBox2.Items.Count-1,true);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string? selectedTime = Convert.ToString(checkedListBox2.SelectedItem);
                foreach (Data data in datas)
                {
                    if(data.time == selectedTime)
                    {
                        Clean();
                        foreach (var item in Global.slovar)
                        {
                            checkedListBox1.Items.Add(item.Key);
                        }
                        textBox_nowtime.Text = selectedTime;
                        textBox_input.Text = data.press;
                        if(data.note != "")
                        {
                            checkBox1.Checked = true;
                            textBox1.Text = data.note;
                        }
                        foreach(string el in data.sympt)
                        {
                            for(int i = 0; i < checkedListBox1.Items.Count; i++)
                            {
                                if(el == checkedListBox1.Items[i].ToString())
                                {
                                    checkedListBox1.SetItemChecked(i, true);
                                }
                            }
                        }
                    }
                }
                if (selectedTime == "Добавить запись")
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        Clean();
                        foreach (var item in Global.slovar)
                        {
                            checkedListBox1.Items.Add(item.Key);
                        }
                        inputdate.Text = new DateTime(year, month, day).ToString("D");
                        textBox_nowtime.Text = DateTime.Now.ToString("t");
                    }
                }
            }
            catch
            {
                
            }

            
        }
        private void LoadDB()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\babur\\OneDrive\\Рабочий стол\\Calendar\\DB.txt", Encoding.UTF8))
            {
                otherdata = "";
                datas.Clear();
                string? line = sr.ReadLine();
                while (line != null)
                {
                    Data temp_data = new Data(line);
                    if (temp_data.day == day && temp_data.month == month && temp_data.year == year)
                    {
                        datas.Add(temp_data);
                    }
                    else
                    {
                        otherdata += line + "\n";
                    }
                    
                    line = sr.ReadLine();
                }
            }
        }
    }

    public partial class Data
    {
        public string time;
        public int day, month, year;
        public string note = "";
        public string press = "";
        public List<string> sympt = new List<string>();
        
        public Data() { }
        public Data(string time, int day, int month, int year) 
        {
            this.time = time;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Data(string line) 
        {
            string[] data = line.Split("::");
            for (int i = 0; i < data.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        time = data[i];
                        break;
                    case 1:
                        day = Convert.ToInt32(data[i]);
                        break;
                    case 2:
                        month = Convert.ToInt32(data[i]);
                        break;
                    case 3:
                        year = Convert.ToInt32(data[i]);
                        break;
                }
                if (data[i] == "note") 
                {
                    note = data[i + 1];
                }
                if (data[i] == "press")
                {
                    press = data[i + 1];
                }
                if (data[i] == "sympt")
                {
                    for(int j = i;  j < data.Length; j++)
                    {
                        if (data[j] != "sympt")
                        {
                            sympt.Add(data[j]);
                        }
                    }
                }
            }
        }

        public string Compil()
        {
            string exp = "";
            exp += this.time + "::";
            exp += this.day + "::";
            exp += this.month + "::";
            exp += this.year + "::";
            if (this.note != "")
            {
                exp += "note::" + this.note + "::";
            }
            if (this.press != "")
            {
                exp += "press::" + this.press + "::";
            }
            if (this.sympt.Count > 0)
            {
                exp += "sympt";
                for (int j = 0; j < this.sympt.Count; j++)
                {
                    exp += "::" + this.sympt[j];
                }
            }
            return exp;
        }
    }
}
