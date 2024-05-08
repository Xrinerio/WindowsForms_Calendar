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

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            if (inputForm != null)
            {
                inputForm.year = year;
                inputForm.month = month;
                inputForm.day = day;
                inputForm.ShowDialog();
            }
        }
    }
}
