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
    public partial class Examination : Form
    {
        public Examination()
        {
            InitializeComponent();
        }
        int count=0;
        int total=0;
        int obtMarks=0;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                MessageBox.Show("You have to select atleast 1 Subject");
            }
            else if (count > 3)
            {
                MessageBox.Show("You can select maximum 3 Subjects");
            }
            else
            {
                
                tabcontrol.SelectTab("tabExam");
                MessageBox.Show("Total is:"+total);

            }

        }

        private void chkBoxMath_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMath.Checked == true)
            {
                count++;
                grpBoxMath.Visible = true;
                total = total + 3;
            }
            else if(chkBoxMath.Checked == false)
            {
                if (count > 0)
                {
                    count--;
                    grpBoxMath.Visible = false;
                    total = total - 3;
                }
            }
        }

        private void chkBoxEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEnglish.Checked == true)
            {
                count++;
                grpBoxEng.Visible = true;
                total = total + 3;
            }
            else if (chkBoxEnglish.Checked == false)
            {
                if (count > 0)
                {
                    count--;
                    grpBoxEng.Visible = false;
                    total = total - 3;
                }
            }
        }

        private void chkBoxComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxComputer.Checked == true)
            {
                count++;
                grpBoxComp.Visible = true;
                total = total + 3;
            }
            else if (chkBoxComputer.Checked == false)
            {
                if (count > 0)
                {
                    count--;
                    grpBoxComp.Visible = false;
                    total = total - 3;
                }
            }
        }

        private void chkBoxPak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPak.Checked == true)
            {
                count++;
                grpBoxPak.Visible = true;
                total = total + 3;
            }
            else if (chkBoxPak.Checked == false)
            {
                if (count > 0)
                {
                    count--;
                    grpBoxPak.Visible = false;
                    total = total - 3;
                }
            }
        }

        private void btnNextpref_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                MessageBox.Show("You have to Select atleast 1 Subject");
            }
            else if (count > 3)
            {
                MessageBox.Show("You can Select maximum 3 Subject");
            }
            else
            {

                tabcontrol.SelectTab("tabExam");
            }
        }

        private void rb2MathQ1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2MathQ1.Checked == true)
            {
                obtMarks++;
            }
            else if (rb2MathQ1.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void btnNextExam_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectTab("tabResult");
            tMarks.Text = total.ToString();
            ObtainMarks.Text = obtMarks.ToString();
        }

        private void rb3MathQ2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3MathQ2.Checked == true)
            {
                obtMarks++;
            }
            else if (rb3MathQ2.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb1MathQ3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1MathQ3.Checked == true)
            {
                obtMarks++;
            }
            else if (rb1MathQ3.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb1EngQ1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1EngQ1.Checked == true)
            {
                obtMarks++;
            }
            else if (rb1EngQ1.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb2EngQ2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2EngQ2.Checked == true)
            {
                obtMarks++;
            }
            else if (rb2EngQ2.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb2EngQ3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2EngQ3.Checked == true)
            {
                obtMarks++;
            }
            else if (rb2EngQ3.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb2CompQ1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2CompQ1.Checked == true)
            {
                obtMarks++;
            }
            else if (rb2CompQ1.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb1CompQ2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1CompQ2.Checked == true)
            {
                obtMarks++;
            }
            else if (rb1CompQ2.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb1CompQ3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1CompQ3.Checked == true)
            {
                obtMarks++;
            }
            else if (rb1CompQ3.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb2PakQ1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2PakQ1.Checked == true)
            {
                obtMarks++;
            }
            else if (rb2PakQ1.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb3PakQ2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3PakQ2.Checked == true)
            {
                obtMarks++;
            }
            else if (rb3PakQ2.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void rb2PakQ3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2PakQ3.Checked == true)
            {
                obtMarks++;
            }
            else if (rb2PakQ3.Checked == false)
            {
                if (obtMarks > 0)
                {
                    obtMarks--;
                }
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}