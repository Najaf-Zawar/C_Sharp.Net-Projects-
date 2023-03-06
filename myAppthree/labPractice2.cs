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
    public partial class labPractice2 : Form
    {
        public labPractice2()
        {
            InitializeComponent();
        }
        String filePath;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult res;
            
            using(OpenFileDialog fileChooser=new OpenFileDialog())
            {
                fileChooser.InitialDirectory = "E:\\UNIVERSITY";
                //fileChooser.Filter = "txt files(*.txt;*.pdf)|*.txt;*.pdf";
                fileChooser.Filter = "All files(*.txt;*.pdf;*.All files)|*.txt;*.pdf;*.*";
                res = fileChooser.ShowDialog();
                filePath = fileChooser.FileName;
            }
            if (res == DialogResult.OK)
            {
                txtFilePath.Text = filePath;
                btnOpen.Enabled = true;

            }

        }

        private void pictureBox_Image(object sender, EventArgs e)
        {
            //pictureBox2.ImageLocation = "E:\\UNIVERSITY\\Semester  6\\Visual Programming\\LabReports\\Lab4\\PcImg.jpg";
            filePathPicture.ImageLocation = filePath;
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void filePathPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
