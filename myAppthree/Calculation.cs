using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAppthree
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double baseVal = 0;
            double powerVal = 0;
            double ans = 0;
          baseVal =  Convert.ToInt32(baseNumeric.Value);
          powerVal = Convert.ToInt32(powerNumeric.Value);
            ans = Math.Pow(baseVal, powerVal);
            lblAns.Text = "Answer is: "+ans.ToString();
        }

        private void btnInterestCalc_Click(object sender, EventArgs e)
        {
            double years;
            int amount;
            int interest;
            int result;

            years = Convert.ToInt32(numericYears.Value);
            amount = Convert.ToInt16(txtPrincipalAmount.Text);
            interest = Convert.ToInt16(txtInterestRate.Text);

            result = (amount * interest) / 100;
            result = amount + result;
            txtBoxResult.Text = result.ToString();


        }
    }
}
