
namespace myAppthree
{
    partial class labPractice2
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.filePathPicture = new System.Windows.Forms.PictureBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.filePathPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(31, 127);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 42);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(244, 127);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 42);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.pictureBox_Image);
            // 
            // filePathPicture
            // 
            this.filePathPicture.Location = new System.Drawing.Point(342, 49);
            this.filePathPicture.Name = "filePathPicture";
            this.filePathPicture.Size = new System.Drawing.Size(437, 274);
            this.filePathPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filePathPicture.TabIndex = 4;
            this.filePathPicture.TabStop = false;
            this.filePathPicture.Click += new System.EventHandler(this.filePathPicture_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(31, 80);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(288, 20);
            this.txtFilePath.TabIndex = 5;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // labPractice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 402);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.filePathPicture);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSelect);
            this.Name = "labPractice2";
            this.Text = "labPractice2";
            ((System.ComponentModel.ISupportInitialize)(this.filePathPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox filePathPicture;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}