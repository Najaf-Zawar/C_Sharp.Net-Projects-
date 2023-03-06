using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myApp5
{
    public partial class GateTypeInput : Form
    {

        public GateTypeInput()
        {
            InitializeComponent();
        }

        private void GateTypeInput_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
           dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime current_date = dateTimePicker1.Value;
            // MessageBox.Show(current_date.Date.DayOfWeek.ToString());
            // MessageBox.Show(current_date.Date.Month.ToString());
            //MessageBox.Show(current_date.Date.DayOfYear.ToString());
        }
    }
}
