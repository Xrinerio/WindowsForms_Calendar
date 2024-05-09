using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public int year, month, day;
        public InputForm inputForm;

        public UserControlDays(InputForm inputForm)
        {
            this.inputForm = inputForm;
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }
        public void days(int numday)
        {
            UCDays.Text = numday + "";
        }

        public void setNotes(int value)
        {
            string value_str = value.ToString();
            string k = "";
            if ((value == 0) || ((value > 4) & (value < 21)) || ((value > 20) & ((value_str.EndsWith("0")) || (value_str.EndsWith("5")) || (value_str.EndsWith("6")) || (value_str.EndsWith("7")) || (value_str.EndsWith("8")) || (value_str.EndsWith("9"))))) k = "записей";
            else if ((value_str == "1") || ((value > 20) & (value_str.EndsWith("1")))) k = "запись";
            else if (((value > 1) & (value < 5)) || ((value > 20) & ((value_str.EndsWith("2")) || (value_str.EndsWith("3")) || (value_str.EndsWith("4"))))) k = "записи";
            k = value_str + " " + k;
            notesscore.Text = k;
            if(value == 0)
            {
                notesscore.Text = "";
            }
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            if (inputForm != null)
            {
                inputForm.Clean();
                inputForm.year = year;
                inputForm.month = month;
                inputForm.day = day;
                inputForm.ShowDialog();
            }
        }
    }
}
