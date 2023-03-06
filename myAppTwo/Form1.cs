using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAppTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Salam o Alaikum");
        }
    }
}
