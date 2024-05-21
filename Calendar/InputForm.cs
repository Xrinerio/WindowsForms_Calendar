using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calendar
{
    public partial class InputForm : Form
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DateBase.txt");
        public int year, month, day;
        List<Data> datas = new List<Data>();
        Data tofile;
        string otherdata = "";
        bool first = true;

        public void Clean()
        {
            textBox_input.Text = "/";
            textBox1.Clear();
            checkBox1.Checked = false;
            checkedListBox1.Items.Clear();
            btn_del.Visible = false;
        }
        

        private string SklonMonth(int value)
        {
            switch (value)
            {
                case 1:
                    return "Января";
                case 2:
                    return "Февраля";
                case 3:
                    return "Марта";
                case 4:
                    return "Апреля";
                case 5:
                    return "Мая";
                case 6:
                    return "Июня";
                case 7:
                    return "Июля";
                case 8:
                    return "Августа";
                case 9:
                    return "Сентября";
                case 10:
                    return "Октября";
                case 11:
                    return "Ноября";
                case 12:
                    return "Декабря";
            }
            return "MonthNameError";
        }

        private void AddToDB()
        {
            using (StreamWriter writer = new StreamWriter(path, false))
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
        
        public InputForm()
        {
            InitializeComponent();
            ReadSlovar(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "slovar.txt"));
            checkedListBox1.CheckOnClick = true;
            textBox1.Visible = false;
            textBox_nowtime.Mask = "00:00";

        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            foreach (var item in Global.slovar)
            {
                checkedListBox1.Items.Add(item.Key);
            }
            
            inputdate.Text = day + " " + SklonMonth(month) + " " + year;
            textBox_nowtime.Text = DateTime.Now.ToString("t");
            btn_del.Visible = false;

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
            bool flag = false;
            tofile = new Data(textBox_nowtime.Text, day, month, year);

            if (checkBox1.Checked && textBox1.Text != "")
            {
                string[] tofilenote = textBox1.Text.Split("\r\n");
                foreach (string s in tofilenote)
                {
                    tofile.note += s + "//";
                }

                flag = true;

            }
            if (textBox_input.Text != "" && textBox_input.Text != "/")
            {
                tofile.press = textBox_input.Text;
                flag = true;
            }
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                foreach (string el in checkedListBox1.CheckedItems)
                {
                    tofile.sympt.Add(el);
                }
                flag = true;
            }

            if (flag)
            {
                if (datas.Count > 0)
                {
                    bool flag2 = true;
                    for (int i = 0; i < datas.Count; i++)
                    {
                        Data data = datas[i];
                        if (data.day == day && data.month == month && data.year == year && data.time == tofile.time)
                        {
                            data.sympt.Clear();
                            data.sympt.AddRange(tofile.sympt);
                            data.note = tofile.note;
                            data.press = tofile.press;
                            flag2 = false;
                        }
                    }
                    if (flag2)
                    {
                        datas.Add(tofile);
                    }
                }
                else
                {
                    datas.Add(tofile);
                }
            }

            AddToDB();


            if (showDesc.Checked == true)
            {
                string outtext = "";
                if(textBox_input.Text != "")
                {
                    int[] a = textBox_input.Text.Split('/').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
                    if (a.Length == 2)
                    {
                        if (a[0] > 130)
                        {
                            outtext += "~У вас повышенное систалическое давление \n";
                        }else if (a[0] < 110)
                        {
                            outtext += "~У вас пониженное систалическое давление \n";
                        }
                        if (a[1] > 85)
                        {
                            outtext += "~У вас повышенное диастолическое давление \n";
                        }
                        else if (a[1] < 70)
                        {
                            outtext += "~У вас пониженное диастолическое давление \n";
                        }
                        outtext += "\n";
                    }
                }
                foreach (string el in checkedListBox1.CheckedItems)
                {
                    try
                    {
                        if (Global.slovar[el.ToString()].Split("::").Length >= 2)
                        {
                            foreach (string mel in Global.slovar[el.ToString()].Split("::"))
                            {
                                outtext += mel + "\n";
                            }
                        }
                        else { outtext += Global.slovar[el.ToString()] + "\n"; }
                        outtext += "\n";
                    }
                    catch { continue; }

                }
                if(outtext != "")
                {
                    MessageBox.Show(
                    $"{outtext}",
                    "Ваши результаты",
                    MessageBoxButtons.OK);
                }
                
            }

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
            for (int i = 0; i < datas.Count; i++)
            {
                checkedListBox2.Items.Add(datas[i].time);
            }
            checkedListBox2.Items.Add("Добавить запись");
            checkedListBox2.SetSelected(checkedListBox2.Items.Count - 1, true);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string? selectedTime = Convert.ToString(checkedListBox2.SelectedItem);
                foreach (Data data in datas)
                {
                    if (data.time == selectedTime)
                    {
                        Clean();
                        btn_del.Visible = true;
                        foreach (var item in Global.slovar)
                        {
                            checkedListBox1.Items.Add(item.Key);
                        }
                        textBox_nowtime.Text = selectedTime;
                        textBox_input.Text = data.press;
                        if (data.note != "")
                        {
                            checkBox1.Checked = true;
                            foreach (string s in data.note.Split("//"))
                            {
                                textBox1.AppendText(s + "\r\n");
                            }

                        }
                        foreach (string el in data.sympt)
                        {
                            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                            {
                                if (el == checkedListBox1.Items[i].ToString())
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
                        inputdate.Text = day + " " + SklonMonth(month) + " " + year;
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
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            datas.RemoveAt(checkedListBox2.SelectedIndex);
            AddToDB();
            Clean();
            checkedListBox2.Items.Clear();
            LoadItems();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Split("\r\n").Length > 5)
            {
                textBox1.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                textBox1.ScrollBars = ScrollBars.None;
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
