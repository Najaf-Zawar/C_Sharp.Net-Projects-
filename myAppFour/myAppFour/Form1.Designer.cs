
namespace myAppFour
{
    partial class Form1
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
            this.lblOuput = new System.Windows.Forms.Label();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Location = new System.Drawing.Point(82, 245);
            this.lblOuput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(0, 20);
            this.lblOuput.TabIndex = 5;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(52, 90);
            this.rbRed.Margin = new System.Windows.Forms.Padding(5);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(60, 24);
            this.rbRed.TabIndex = 6;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(52, 126);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(5);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(63, 24);
            this.rbBlue.TabIndex = 7;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(52, 161);
            this.rbGreen.Margin = new System.Windows.Forms.Padding(5);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(77, 24);
            this.rbGreen.TabIndex = 8;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(48, 65);
            this.lblColor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(122, 20);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Choose Color:";
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(236, 65);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(564, 281);
            this.pnlColor.TabIndex = 10;
            this.pnlColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnlColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pnlColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 391);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.lblOuput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel pnlColor;
    }
}

