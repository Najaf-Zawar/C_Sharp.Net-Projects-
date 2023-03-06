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
    public partial class frmCalc : Form
    {
        Form fc;
        string strOutput;
        public frmCalc(Form CallingForm, String strInp)
        {
            fc = CallingForm;
            strOutput = strInp;
            InitializeComponent();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            lbloutput.Text = strOutput;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fc.ShowDialog();
            this.Close();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }
    }
}
