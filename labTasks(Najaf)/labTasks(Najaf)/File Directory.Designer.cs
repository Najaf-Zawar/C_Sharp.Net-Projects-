namespace labTasks_Najaf_
{
    partial class File_Directory
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
            this.txtFilePath1 = new System.Windows.Forms.TextBox();
            this.btnPath1 = new System.Windows.Forms.Button();
            this.btnPath2 = new System.Windows.Forms.Button();
            this.txtFilePath2 = new System.Windows.Forms.TextBox();
            this.lstPath1Files = new System.Windows.Forms.ListBox();
            this.lstPath2Files = new System.Windows.Forms.ListBox();
            this.btnComp = new System.Windows.Forms.Button();
            this.lstcompFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFilePath1
            // 
            this.txtFilePath1.Location = new System.Drawing.Point(69, 58);
            this.txtFilePath1.Name = "txtFilePath1";
            this.txtFilePath1.Size = new System.Drawing.Size(342, 20);
            this.txtFilePath1.TabIndex = 1;
            // 
            // btnPath1
            // 
            this.btnPath1.Location = new System.Drawing.Point(417, 56);
            this.btnPath1.Name = "btnPath1";
            this.btnPath1.Size = new System.Drawing.Size(89, 23);
            this.btnPath1.TabIndex = 2;
            this.btnPath1.Text = "Select Folder";
            this.btnPath1.UseVisualStyleBackColor = true;
            this.btnPath1.Click += new System.EventHandler(this.btnPath1_Click);
            // 
            // btnPath2
            // 
            this.btnPath2.Location = new System.Drawing.Point(417, 108);
            this.btnPath2.Name = "btnPath2";
            this.btnPath2.Size = new System.Drawing.Size(89, 23);
            this.btnPath2.TabIndex = 3;
            this.btnPath2.Text = "Select Folder";
            this.btnPath2.UseVisualStyleBackColor = true;
            this.btnPath2.Click += new System.EventHandler(this.btnPath2_Click);
            // 
            // txtFilePath2
            // 
            this.txtFilePath2.Location = new System.Drawing.Point(69, 111);
            this.txtFilePath2.Name = "txtFilePath2";
            this.txtFilePath2.Size = new System.Drawing.Size(342, 20);
            this.txtFilePath2.TabIndex = 4;
            // 
            // lstPath1Files
            // 
            this.lstPath1Files.FormattingEnabled = true;
            this.lstPath1Files.Location = new System.Drawing.Point(69, 185);
            this.lstPath1Files.Name = "lstPath1Files";
            this.lstPath1Files.Size = new System.Drawing.Size(173, 173);
            this.lstPath1Files.TabIndex = 5;
            // 
            // lstPath2Files
            // 
            this.lstPath2Files.FormattingEnabled = true;
            this.lstPath2Files.Location = new System.Drawing.Point(309, 185);
            this.lstPath2Files.Name = "lstPath2Files";
            this.lstPath2Files.Size = new System.Drawing.Size(185, 173);
            this.lstPath2Files.TabIndex = 6;
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(633, 130);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(75, 23);
            this.btnComp.TabIndex = 7;
            this.btnComp.Text = "Compare";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // lstcompFiles
            // 
            this.lstcompFiles.FormattingEnabled = true;
            this.lstcompFiles.Location = new System.Drawing.Point(588, 185);
            this.lstcompFiles.Name = "lstcompFiles";
            this.lstcompFiles.Size = new System.Drawing.Size(185, 173);
            this.lstcompFiles.TabIndex = 8;
            // 
            // File_Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstcompFiles);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.lstPath2Files);
            this.Controls.Add(this.lstPath1Files);
            this.Controls.Add(this.txtFilePath2);
            this.Controls.Add(this.btnPath2);
            this.Controls.Add(this.btnPath1);
            this.Controls.Add(this.txtFilePath1);
            this.Name = "File_Directory";
            this.Text = "File_Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilePath1;
        private System.Windows.Forms.Button btnPath1;
        private System.Windows.Forms.Button btnPath2;
        private System.Windows.Forms.TextBox txtFilePath2;
        private System.Windows.Forms.ListBox lstPath1Files;
        private System.Windows.Forms.ListBox lstPath2Files;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.ListBox lstcompFiles;
    }
}