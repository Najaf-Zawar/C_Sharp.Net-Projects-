using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] intArr = { 1, 2, 3, 4, 5 };
        double[] doubleArr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        char[] charArr = { 'h', 'e', 'l', 'l', 'o' };

        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach(T element in inputArray)
            {
                MessageBox.Show(element.ToString());
            }
        }

      /*  void DisplayArray(int[] source)
        {
            foreach (int element in source)
            {
                MessageBox.Show(element.ToString());
            }
        }

        void DisplayArray(double[] source)
        {
            foreach (double element in source)
            {
                MessageBox.Show(element.ToString());
            }
        }

        void DisplayArray(char[] source)
        {
            foreach (double element in source)
            {
                MessageBox.Show(element.ToString());
            }
        }   */



        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayArray(intArr);
        }

       
    }
}
