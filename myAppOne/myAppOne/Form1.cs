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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInp.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String inp = txtInp.Text;
            this.Hide();
            frmCalc fc = new frmCalc(this, inp);
           fc.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
