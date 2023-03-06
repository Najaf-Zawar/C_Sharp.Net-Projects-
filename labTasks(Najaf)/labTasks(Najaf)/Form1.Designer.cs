namespace labTasks_Najaf_
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
            this.txtParagraph = new System.Windows.Forms.TextBox();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParagraph
            // 
            this.txtParagraph.Location = new System.Drawing.Point(365, 65);
            this.txtParagraph.Multiline = true;
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.Size = new System.Drawing.Size(152, 90);
            this.txtParagraph.TabIndex = 0;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(275, 68);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(84, 13);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "Enter Paragraph";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(442, 161);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(491, 200);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paragraph contain 3 letter words: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.txtParagraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParagraph;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
    }
}

