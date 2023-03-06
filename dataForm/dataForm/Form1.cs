using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dataForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"E:\UNIVERSITY\Semester  6\Visual Programming\Projects\dataForm\dataForm\XMLFile1.xml");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];
        }
    }
}

