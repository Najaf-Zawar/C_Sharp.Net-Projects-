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
    public partial class labPracticeGroupBOx_Rbutton : Form
    {
        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }
        // They are just Like private int ctr { get; set; }
        public labPracticeGroupBOx_Rbutton()
        {
            InitializeComponent();
        }

        private void labPracticeGroupBOx_Rbutton_Load(object sender, EventArgs e)
        {

        }

        //Change button based on option chosen by sender
        private void buttonType_CheckedChange(object sender, EventArgs e)
        {
            if (sender==rb1OkButton)
            {
                ButtonType = MessageBoxButtons.OK;
            }
            else if (sender == rb2OkCancelButton)
            {
                ButtonType = MessageBoxButtons.OKCancel;
            }
            else if (sender == rb3AbortButton)
            {
                ButtonType = MessageBoxButtons.AbortRetryIgnore;
            }
           else if (sender == rb4Yes_CancelButton)
            {
                ButtonType = MessageBoxButtons.YesNoCancel;
            }
            else if (sender == rb5YesButton)
            {
                ButtonType = MessageBoxButtons.YesNo;
            }
           else if (sender == rb6RetryButton)
            {
                ButtonType = MessageBoxButtons.RetryCancel;
            }
        }

        private void iconType_CheckedChange(object sender, EventArgs e)
        {
            if (sender == rb1AsterikIcon)
            {
                IconType = MessageBoxIcon.Asterisk;
            }
            else if (sender == rb2ErrorIcon)
            {
                IconType = MessageBoxIcon.Error;
            }
            else if (sender == rb3ExclamationIcon)
            {
                IconType = MessageBoxIcon.Exclamation;
            }
            else if (sender == rb4HandIcon)
            {
                IconType = MessageBoxIcon.Hand;
            }
            else if (sender == rb5InfoIcon)
            {
                IconType = MessageBoxIcon.Information;
            }
            else if (sender == rb6QuesIcon)
            {
                IconType = MessageBoxIcon.Question;
            }
            else if (sender == rb7StopIcon)
            {
                IconType = MessageBoxIcon.Stop;
            }
            else if (sender == rb8WarnIcon)
            {
                IconType = MessageBoxIcon.Warning;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String message = txtMessage.Text;
            string title = txtTitle.Text;
            DialogResult result=MessageBox.Show(
                message,title,
                ButtonType, IconType);
            txtTitle.Text = "";
            txtMessage.Text = "";
            switch (result)
            {
                case DialogResult.OK:
                    lblOutput.Text = "Ok was Pressed";
                    break;
                case DialogResult.Cancel:
                    lblOutput.Text = "Cancel was Pressed";
                    break;
                case DialogResult.Abort:
                    lblOutput.Text = "Abort was Pressed";
                    break;
                case DialogResult.Retry:
                    lblOutput.Text = "Retry was Pressed";
                    break;
                case DialogResult.Ignore:
                    lblOutput.Text = "Ignore was Pressed";
                    break;
                case DialogResult.Yes:
                    lblOutput.Text = "Yes was Pressed";
                    break;
                case DialogResult.No:
                    lblOutput.Text = "No was Pressed";
                    break;
            }
        }
    }
}
