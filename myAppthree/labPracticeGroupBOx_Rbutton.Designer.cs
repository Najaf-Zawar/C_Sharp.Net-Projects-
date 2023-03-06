
namespace myAppthree
{
    partial class labPracticeGroupBOx_Rbutton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.rb6RetryButton = new System.Windows.Forms.RadioButton();
            this.rb5YesButton = new System.Windows.Forms.RadioButton();
            this.rb4Yes_CancelButton = new System.Windows.Forms.RadioButton();
            this.rb3AbortButton = new System.Windows.Forms.RadioButton();
            this.rb2OkCancelButton = new System.Windows.Forms.RadioButton();
            this.rb1OkButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb8WarnIcon = new System.Windows.Forms.RadioButton();
            this.rb7StopIcon = new System.Windows.Forms.RadioButton();
            this.rb6QuesIcon = new System.Windows.Forms.RadioButton();
            this.rb5InfoIcon = new System.Windows.Forms.RadioButton();
            this.rb4HandIcon = new System.Windows.Forms.RadioButton();
            this.rb3ExclamationIcon = new System.Windows.Forms.RadioButton();
            this.rb2ErrorIcon = new System.Windows.Forms.RadioButton();
            this.rb1AsterikIcon = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.rb6RetryButton);
            this.groupBox1.Controls.Add(this.rb5YesButton);
            this.groupBox1.Controls.Add(this.rb4Yes_CancelButton);
            this.groupBox1.Controls.Add(this.rb3AbortButton);
            this.groupBox1.Controls.Add(this.rb2OkCancelButton);
            this.groupBox1.Controls.Add(this.rb1OkButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button type";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(7, 183);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // rb6RetryButton
            // 
            this.rb6RetryButton.AutoSize = true;
            this.rb6RetryButton.Location = new System.Drawing.Point(7, 140);
            this.rb6RetryButton.Name = "rb6RetryButton";
            this.rb6RetryButton.Size = new System.Drawing.Size(83, 17);
            this.rb6RetryButton.TabIndex = 5;
            this.rb6RetryButton.TabStop = true;
            this.rb6RetryButton.Text = "RetryCancel";
            this.rb6RetryButton.UseVisualStyleBackColor = true;
            this.rb6RetryButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChange);
            // 
            // rb5YesButton
            // 
            this.rb5YesButton.AutoSize = true;
            this.rb5YesButton.Location = new System.Drawing.Point(7, 116);
            this.rb5YesButton.Name = "rb5YesButton";
            this.rb5YesButton.Size = new System.Drawing.Size(57, 17);
            this.rb5YesButton.TabIndex = 4;
            this.rb5YesButton.TabStop = true;
            this.rb5YesButton.Text = "YesNo";
            this.rb5YesButton.UseVisualStyleBackColor = true;
            this.rb5YesButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChange);
            // 
            // rb4Yes_CancelButton
            // 
            this.rb4Yes_CancelButton.AutoSize = true;
            this.rb4Yes_CancelButton.Location = new System.Drawing.Point(7, 92);
            this.rb4Yes_CancelButton.Name = "rb4Yes_CancelButton";
            this.rb4Yes_CancelButton.Size = new System.Drawing.Size(90, 17);
            this.rb4Yes_CancelButton.TabIndex = 3;
            this.rb4Yes_CancelButton.TabStop = true;
            this.rb4Yes_CancelButton.Text = "YesNoCancel";
            this.rb4Yes_CancelButton.UseVisualStyleBackColor = true;
            this.rb4Yes_CancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChange);
            // 
            // rb3AbortButton
            // 
            this.rb3AbortButton.AutoSize = true;
            this.rb3AbortButton.Location = new System.Drawing.Point(7, 68);
            this.rb3AbortButton.Name = "rb3AbortButton";
            this.rb3AbortButton.Size = new System.Drawing.Size(105, 17);
            this.rb3AbortButton.TabIndex = 2;
            this.rb3AbortButton.TabStop = true;
            this.rb3AbortButton.Text = "AbortRetryIgnore";
            this.rb3AbortButton.UseVisualStyleBackColor = true;
            this.rb3AbortButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChange);
            // 
            // rb2OkCancelButton
            // 
            this.rb2OkCancelButton.AutoSize = true;
            this.rb2OkCancelButton.Location = new System.Drawing.Point(7, 44);
            this.rb2OkCancelButton.Name = "rb2OkCancelButton";
            this.rb2OkCancelButton.Size = new System.Drawing.Size(72, 17);
            this.rb2OkCancelButton.TabIndex = 1;
            this.rb2OkCancelButton.TabStop = true;
            this.rb2OkCancelButton.Text = "OkCancel";
            this.rb2OkCancelButton.UseVisualStyleBackColor = true;
            this.rb2OkCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChange);
            // 
            // rb1OkButton
            // 
            this.rb1OkButton.AutoSize = true;
            this.rb1OkButton.Location = new System.Drawing.Point(7, 20);
            this.rb1OkButton.Name = "rb1OkButton";
            this.rb1OkButton.Size = new System.Drawing.Size(39, 17);
            this.rb1OkButton.TabIndex = 0;
            this.rb1OkButton.TabStop = true;
            this.rb1OkButton.Text = "Ok";
            this.rb1OkButton.UseVisualStyleBackColor = true;
            this.rb1OkButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb8WarnIcon);
            this.groupBox2.Controls.Add(this.rb7StopIcon);
            this.groupBox2.Controls.Add(this.rb6QuesIcon);
            this.groupBox2.Controls.Add(this.rb5InfoIcon);
            this.groupBox2.Controls.Add(this.rb4HandIcon);
            this.groupBox2.Controls.Add(this.rb3ExclamationIcon);
            this.groupBox2.Controls.Add(this.rb2ErrorIcon);
            this.groupBox2.Controls.Add(this.rb1AsterikIcon);
            this.groupBox2.Location = new System.Drawing.Point(180, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon";
            // 
            // rb8WarnIcon
            // 
            this.rb8WarnIcon.AutoSize = true;
            this.rb8WarnIcon.Location = new System.Drawing.Point(7, 187);
            this.rb8WarnIcon.Name = "rb8WarnIcon";
            this.rb8WarnIcon.Size = new System.Drawing.Size(65, 17);
            this.rb8WarnIcon.TabIndex = 7;
            this.rb8WarnIcon.TabStop = true;
            this.rb8WarnIcon.Text = "Warning";
            this.rb8WarnIcon.UseVisualStyleBackColor = true;
            this.rb8WarnIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb7StopIcon
            // 
            this.rb7StopIcon.AutoSize = true;
            this.rb7StopIcon.Location = new System.Drawing.Point(7, 164);
            this.rb7StopIcon.Name = "rb7StopIcon";
            this.rb7StopIcon.Size = new System.Drawing.Size(47, 17);
            this.rb7StopIcon.TabIndex = 6;
            this.rb7StopIcon.TabStop = true;
            this.rb7StopIcon.Text = "Stop";
            this.rb7StopIcon.UseVisualStyleBackColor = true;
            this.rb7StopIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb6QuesIcon
            // 
            this.rb6QuesIcon.AutoSize = true;
            this.rb6QuesIcon.Location = new System.Drawing.Point(7, 140);
            this.rb6QuesIcon.Name = "rb6QuesIcon";
            this.rb6QuesIcon.Size = new System.Drawing.Size(67, 17);
            this.rb6QuesIcon.TabIndex = 5;
            this.rb6QuesIcon.TabStop = true;
            this.rb6QuesIcon.Text = "Question";
            this.rb6QuesIcon.UseVisualStyleBackColor = true;
            this.rb6QuesIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb5InfoIcon
            // 
            this.rb5InfoIcon.AutoSize = true;
            this.rb5InfoIcon.Location = new System.Drawing.Point(7, 116);
            this.rb5InfoIcon.Name = "rb5InfoIcon";
            this.rb5InfoIcon.Size = new System.Drawing.Size(77, 17);
            this.rb5InfoIcon.TabIndex = 4;
            this.rb5InfoIcon.TabStop = true;
            this.rb5InfoIcon.Text = "Information";
            this.rb5InfoIcon.UseVisualStyleBackColor = true;
            this.rb5InfoIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb4HandIcon
            // 
            this.rb4HandIcon.AutoSize = true;
            this.rb4HandIcon.Location = new System.Drawing.Point(7, 92);
            this.rb4HandIcon.Name = "rb4HandIcon";
            this.rb4HandIcon.Size = new System.Drawing.Size(51, 17);
            this.rb4HandIcon.TabIndex = 3;
            this.rb4HandIcon.TabStop = true;
            this.rb4HandIcon.Text = "Hand";
            this.rb4HandIcon.UseVisualStyleBackColor = true;
            this.rb4HandIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb3ExclamationIcon
            // 
            this.rb3ExclamationIcon.AutoSize = true;
            this.rb3ExclamationIcon.Location = new System.Drawing.Point(7, 68);
            this.rb3ExclamationIcon.Name = "rb3ExclamationIcon";
            this.rb3ExclamationIcon.Size = new System.Drawing.Size(82, 17);
            this.rb3ExclamationIcon.TabIndex = 2;
            this.rb3ExclamationIcon.TabStop = true;
            this.rb3ExclamationIcon.Text = "Exclamation";
            this.rb3ExclamationIcon.UseVisualStyleBackColor = true;
            this.rb3ExclamationIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb2ErrorIcon
            // 
            this.rb2ErrorIcon.AutoSize = true;
            this.rb2ErrorIcon.Location = new System.Drawing.Point(7, 44);
            this.rb2ErrorIcon.Name = "rb2ErrorIcon";
            this.rb2ErrorIcon.Size = new System.Drawing.Size(47, 17);
            this.rb2ErrorIcon.TabIndex = 1;
            this.rb2ErrorIcon.TabStop = true;
            this.rb2ErrorIcon.Text = "Error";
            this.rb2ErrorIcon.UseVisualStyleBackColor = true;
            this.rb2ErrorIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // rb1AsterikIcon
            // 
            this.rb1AsterikIcon.AutoSize = true;
            this.rb1AsterikIcon.Location = new System.Drawing.Point(7, 20);
            this.rb1AsterikIcon.Name = "rb1AsterikIcon";
            this.rb1AsterikIcon.Size = new System.Drawing.Size(57, 17);
            this.rb1AsterikIcon.TabIndex = 0;
            this.rb1AsterikIcon.TabStop = true;
            this.rb1AsterikIcon.Text = "Asterik";
            this.rb1AsterikIcon.UseVisualStyleBackColor = true;
            this.rb1AsterikIcon.CheckedChanged += new System.EventHandler(this.iconType_CheckedChange);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(28, 240);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(32, 278);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Enter Title of Message Box";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(187, 275);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(129, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(32, 307);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Enter Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(187, 301);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(129, 20);
            this.txtMessage.TabIndex = 6;
            // 
            // labPracticeGroupBOx_Rbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 373);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "labPracticeGroupBOx_Rbutton";
            this.Text = "GroupBox Practice";
            this.Load += new System.EventHandler(this.labPracticeGroupBOx_Rbutton_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.RadioButton rb6RetryButton;
        private System.Windows.Forms.RadioButton rb5YesButton;
        private System.Windows.Forms.RadioButton rb4Yes_CancelButton;
        private System.Windows.Forms.RadioButton rb3AbortButton;
        private System.Windows.Forms.RadioButton rb2OkCancelButton;
        private System.Windows.Forms.RadioButton rb1OkButton;
        private System.Windows.Forms.RadioButton rb8WarnIcon;
        private System.Windows.Forms.RadioButton rb7StopIcon;
        private System.Windows.Forms.RadioButton rb6QuesIcon;
        private System.Windows.Forms.RadioButton rb5InfoIcon;
        private System.Windows.Forms.RadioButton rb4HandIcon;
        private System.Windows.Forms.RadioButton rb3ExclamationIcon;
        private System.Windows.Forms.RadioButton rb2ErrorIcon;
        private System.Windows.Forms.RadioButton rb1AsterikIcon;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}