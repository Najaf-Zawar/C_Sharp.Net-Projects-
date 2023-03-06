
namespace myAppthree
{
    partial class Calculation
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
            this.baseNumeric = new System.Windows.Forms.NumericUpDown();
            this.powerNumeric = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            this.txtPrincipalAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.btnInterestCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            this.SuspendLayout();
            // 
            // baseNumeric
            // 
            this.baseNumeric.Location = new System.Drawing.Point(113, 34);
            this.baseNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.baseNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baseNumeric.Name = "baseNumeric";
            this.baseNumeric.Size = new System.Drawing.Size(120, 20);
            this.baseNumeric.TabIndex = 0;
            this.baseNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // powerNumeric
            // 
            this.powerNumeric.Location = new System.Drawing.Point(113, 59);
            this.powerNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.powerNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.powerNumeric.Name = "powerNumeric";
            this.powerNumeric.Size = new System.Drawing.Size(120, 20);
            this.powerNumeric.TabIndex = 1;
            this.powerNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(160, 90);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(110, 125);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 13);
            this.lblAns.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Power";
            // 
            // numericYears
            // 
            this.numericYears.Location = new System.Drawing.Point(424, 32);
            this.numericYears.Name = "numericYears";
            this.numericYears.Size = new System.Drawing.Size(120, 20);
            this.numericYears.TabIndex = 6;
            // 
            // txtPrincipalAmount
            // 
            this.txtPrincipalAmount.Location = new System.Drawing.Point(423, 58);
            this.txtPrincipalAmount.Name = "txtPrincipalAmount";
            this.txtPrincipalAmount.Size = new System.Drawing.Size(120, 20);
            this.txtPrincipalAmount.TabIndex = 7;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(424, 84);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(120, 20);
            this.txtInterestRate.TabIndex = 8;
            // 
            // btnInterestCalc
            // 
            this.btnInterestCalc.Location = new System.Drawing.Point(381, 115);
            this.btnInterestCalc.Name = "btnInterestCalc";
            this.btnInterestCalc.Size = new System.Drawing.Size(75, 23);
            this.btnInterestCalc.TabIndex = 9;
            this.btnInterestCalc.Text = "Calculate";
            this.btnInterestCalc.UseVisualStyleBackColor = true;
            this.btnInterestCalc.Click += new System.EventHandler(this.btnInterestCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Principal Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Interest Rate";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(381, 161);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(163, 91);
            this.txtBoxResult.TabIndex = 13;
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInterestCalc);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtPrincipalAmount);
            this.Controls.Add(this.numericYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.powerNumeric);
            this.Controls.Add(this.baseNumeric);
            this.Name = "Calculation";
            this.Text = "Calculation";
            ((System.ComponentModel.ISupportInitialize)(this.baseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown baseNumeric;
        private System.Windows.Forms.NumericUpDown powerNumeric;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericYears;
        private System.Windows.Forms.TextBox txtPrincipalAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnInterestCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxResult;
    }
}