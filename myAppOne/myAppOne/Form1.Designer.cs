
namespace myAppOne
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
            this.btnmove = new System.Windows.Forms.Button();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmove
            // 
            this.btnmove.Location = new System.Drawing.Point(282, 261);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(248, 95);
            this.btnmove.TabIndex = 0;
            this.btnmove.Text = "Move to frmCalc";
            this.btnmove.UseVisualStyleBackColor = true;
            this.btnmove.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(251, 152);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(306, 20);
            this.txtInp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnmove);
            this.Name = "Form1";
            this.Text = "myFirstForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.TextBox txtInp;
        private System.Windows.Forms.Label label1;
    }
}

