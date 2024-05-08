using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class InputForm : Form
    {
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
            button1.Enabled = false;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            
            
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
    }
}
