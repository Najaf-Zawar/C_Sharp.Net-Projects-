using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAppOne
{
    public partial class frmCalculator : Form
    {
 
        public frmCalculator()
        {
            InitializeComponent();
        }
        String inp;
        Double val1;
        Double val2;
        Double result;
        char sign;
        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtInp1.Text != "")
            {
                lblsaveValue.Text = txtInp1.Text;
                val1 = Convert.ToDouble(txtInp1.Text);
                txtInp1.Text = "";
                sign = '-';
                lblsaveValue.Text += sign;
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (txtInp1.Text != "")
            {
                lblsaveValue.Text = txtInp1.Text;
                val1 = Convert.ToDouble(txtInp1.Text);
                txtInp1.Text = "";
                sign = '+';
                lblsaveValue.Text += sign;
            }
        }

        private void txtInp1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }    


      

        private void btn0_Click(object sender, EventArgs e)
        {

            Button b0 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b0.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Button bDot = (Button)sender;
            txtInp1.Text = txtInp1.Text + bDot.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button b2 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button b3 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button b4 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button b5 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button b6 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button b7 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button b8 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button b9 = (Button)sender;
            txtInp1.Text = txtInp1.Text + b9.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInp1.Text = "";
            lblsaveValue.Text = "";
            result = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtInp1.Text != "")
            {
                lblsaveValue.Text += txtInp1.Text;
                val2 = Convert.ToDouble(txtInp1.Text);
                txtInp1.Text = "";
                if (sign == '+')
                {
                    result = val1 + val2;
                    txtInp1.Text += result;
                    val1 = result;
                    lblsaveValue.Text += " = " + val1;
                }
                else if (sign == '-')
                {
                    lblsaveValue.Text += txtInp1.Text;
                    result = val1 - val2;
                    txtInp1.Text += result;
                    val1 = result;
                    lblsaveValue.Text += " = " + val1;
                }
                else if (sign == '*')
                {
                    lblsaveValue.Text += txtInp1.Text;
                    result = val1 * val2;
                    txtInp1.Text += result;
                    val1 = result;
                    lblsaveValue.Text += " = " + val1;
                }
                else if (sign == '/')
                {
                    if (val2 == 0)
                    {
                        MessageBox.Show("Cannot divided by 0");
                    }
                    else
                    {
                        lblsaveValue.Text += txtInp1.Text;
                        result = val1 / val2;
                        txtInp1.Text += result;
                        val1 = result;
                        lblsaveValue.Text += " = " + val1;
                    }
                }
                else if (sign == '%')
                {
                    lblsaveValue.Text += txtInp1.Text;
                    result = val1 % val2;
                    txtInp1.Text += result;
                    val1 = result;
                    lblsaveValue.Text += " = " + val1;
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (txtInp1.Text != "")
            {
                lblsaveValue.Text = txtInp1.Text;
                val1 = Convert.ToDouble(txtInp1.Text);
                txtInp1.Text = " ";
                sign = '*';
                lblsaveValue.Text += sign;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtInp1.Text != "")
            {
                lblsaveValue.Text = txtInp1.Text;
                val1 = Convert.ToDouble(txtInp1.Text);
                txtInp1.Text = "";
                sign = '/';
                lblsaveValue.Text += sign;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtInp1.Text != "")
            {
                lblsaveValue.Text = txtInp1.Text;
                val1 = Convert.ToDouble(txtInp1.Text);
                txtInp1.Text = "";
                sign = '%';
                lblsaveValue.Text += sign;
            }
        }

    }
}
