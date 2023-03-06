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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btnJump_Click(object sender, EventArgs e)
        { 
                Random r = new Random();
                Point p = new Point(
                    int.Parse(r.Next(822).ToString()),
                   int.Parse(r.Next(489).ToString())

                        );
                btnJump.Location = p;
                i++;
          
            if (i >= 10)
            {
                btnJump.Enabled = false;

                }
            }
     
    }
}
