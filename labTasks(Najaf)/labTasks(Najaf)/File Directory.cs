using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace labTasks_Najaf_
{
    public partial class File_Directory : Form
    {
        public File_Directory()
        {
            InitializeComponent();
        }
        IEnumerable<FileInfo> Files;
        IEnumerable<FileInfo> Files2;
        IEnumerable<FileInfo> filelist;
        IEnumerable<FileInfo> filelist2;

        List<String> filenames = new List<String>();
        List<String> filenames2 = new List<String>();
        List<String> compFilenames = new List<String>();

        private void btnPath1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (FolderBrowserDialog objects = new FolderBrowserDialog())
            {
                objects.SelectedPath = "E:";
                result = objects.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lstPath1Files.Items.Clear();
                    txtFilePath1.Text = objects.SelectedPath;
                    DirectoryInfo dir = new DirectoryInfo(txtFilePath1.Text);
                    filelist = dir.GetFiles(".", SearchOption.AllDirectories);

                    Files = from files in filelist select files;

                    filenames.Clear();
                    foreach (FileInfo file in Files)
                    {

                        filenames.Add(file.Name);
                    }
                    foreach (String file in filenames)
                    {
                        lstPath1Files.Items.Add(file);
                }
            }
         }

     }

        private void btnPath2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (FolderBrowserDialog objects = new FolderBrowserDialog())
            {
                objects.SelectedPath = "E:";
                result = objects.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lstPath2Files.Items.Clear();
                    txtFilePath2.Text = objects.SelectedPath;
                    DirectoryInfo dir = new DirectoryInfo(txtFilePath2.Text);
                    filelist2 = dir.GetFiles(".", SearchOption.AllDirectories);

                    Files2 = from files in filelist2 select files;

                    filenames2.Clear();
                    foreach (FileInfo file in Files2)
                    {

                        filenames2.Add(file.Name);
                    }
                    foreach (String file in filenames2)
                    {
                        lstPath2Files.Items.Add(file);
                    }
                }
            }
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            lstcompFiles.Items.Clear();
            var common = filenames.Intersect(filenames2).ToList();
            if (common.Count > 0)
            {
                foreach (String file in common)
                {

                    lstcompFiles.Items.Add(file);
                }
            }
            else
            {
                MessageBox.Show("No Common File");
            }
        }
    }
}
