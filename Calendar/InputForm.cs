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

namespace Calendar
{
    public partial class InputForm : Form
    {
        public int year, month, day;

        private void AddToDB(string fileName)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\babur\\OneDrive\\Рабочий стол\\Calendar\\DB.txt"))
            {
                writer.WriteLine(fileName);
                writer.Close();
            }
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
            foreach (var item in Global.slovar)
            {
                checkedListBox1.Items.Add(item.Key);
            }
            checkedListBox1.CheckOnClick = true;
            textBox1.Visible = false;
            textBox_nowtime.Mask = "00:00";
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            inputdate.Text = new DateTime(year, month, day).ToString("D");
            textBox_nowtime.Text = DateTime.Now.ToString("t");

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

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {

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
            string tofile = $"{textBox_nowtime.Text}::{day}::{month}::{year}::";

            if (checkBox1.Checked)
            {
                tofile += "note::"+textBox1.Text+"::";
            }
            if (textBox_input.Text != null) 
            {
                tofile += "press::"+textBox_input.Text+"::";
            }
            if(checkedListBox1.CheckedItems.Count > 0)
            {
                string sympt = "sympt";
                foreach(string el in checkedListBox1.CheckedItems)
                {
                    sympt += "::"+el;
                }
                tofile += sympt;
            }
            AddToDB(tofile);
            this.Close();
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
                
            }
            
            
        }
    }
}
