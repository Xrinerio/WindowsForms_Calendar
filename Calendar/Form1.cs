using System.Globalization;
using static Calendar.InputForm;
using System.IO;
using System.Text;

namespace Calendar
{
    public partial class Form1 : Form
    {
        InputForm? temp = null;
        int month, year;
        InputForm inputForm = new InputForm();
        UserControlDays[] spisokdays = new UserControlDays[31];

        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 31; i++)
            {
                spisokdays[i] = new UserControlDays(inputForm);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }
        public void LoadPage(int year, int month)
        {
            string monthname = new DateTime(year, month, 1).ToString("MMMM", CultureInfo.GetCultureInfo("ru"));
            monthyear.Text = monthname + " " + year;

            DateTime startmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month) + 1;
            int daysinweek = Convert.ToInt32(startmonth.DayOfWeek.ToString("d")) - 1;

            for (int i = 1; i <= daysinweek; i++)
            {
                UserControlBlank UCBlank = new UserControlBlank();
                daycontainer.Controls.Add(UCBlank);
            }

            for (int i = 1; i < days; i++)
            {
                spisokdays[i - 1].year = year;
                spisokdays[i - 1].month = month;
                spisokdays[i - 1].day = i;
                spisokdays[i - 1].days(i);
                if(CheckDBdata(year,month,days))
                {
                    spisokdays[i-1].BackColor = Color.LightYellow;
                }
                daycontainer.Controls.Add(spisokdays[i - 1]);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }

            LoadPage(year, month);

        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }

            LoadPage(year, month);


        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            LoadPage(year, month);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        public bool CheckDBdata(int takeyear, int takemonth, int takeday)
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\babur\\OneDrive\\Рабочий стол\\Calendar\\DB.txt", Encoding.UTF8))
            {
                string? line = sr.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split("::");
                    try
                    {
                        if (text[1] == Convert.ToString(takeday) && text[2] == Convert.ToString(takemonth) && text[3] == Convert.ToString(takeyear)){
                            return true;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                    line = sr.ReadLine();
                }
                return false;
            }
        }            
    }
}
