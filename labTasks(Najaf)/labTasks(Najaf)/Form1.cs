using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTasks_Najaf_
{
    public partial class Form1 : Form
    {
        String para;
        String[] splitPara;
        int count=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            para = txtParagraph.Text;
            splitPara = para.Split();
            IEnumerable<String> countQuery = from word in splitPara where word.Count().Equals(3) select word;
            foreach (string i in countQuery)
            {
                count++;
            }
            lblOutput.Text = count.ToString();
            count = 0;
        }
    }
}
