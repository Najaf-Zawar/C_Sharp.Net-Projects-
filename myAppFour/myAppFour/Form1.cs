using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAppFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean shouldPaint = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = pnlColor.CreateGraphics())
                {
                    if (rbRed.Checked == true)
                    {
                        graphics.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 4, 4);
                    }
                    if (rbBlue.Checked)
                    {
                        graphics.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 4, 4);
                    }
                    if (rbGreen.Checked)
                    {
                        graphics.FillEllipse(new SolidBrush(Color.Green), e.X, e.Y, 4, 4);
                    }
                }
            }
        }
    }
}
