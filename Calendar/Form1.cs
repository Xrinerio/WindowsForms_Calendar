using System.Globalization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        InputForm? temp = null;
        int month, year;
        public Form1()
        {
            InitializeComponent();
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
                UserControlDays UCDays = new UserControlDays();
                UCDays.days(i);
                daycontainer.Controls.Add(UCDays);
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

        public void openInputForm(InputForm inputForm)
        {
            if (temp != null)
            {
                temp.Close();
            }
            temp = inputForm;
            temp.Show();
        }
        public void closeInputForm()
        {
            temp.Close();
            temp = null;
        }
    }
}
