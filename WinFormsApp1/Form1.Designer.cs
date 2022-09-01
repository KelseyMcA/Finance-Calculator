namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxHourlyWage = new System.Windows.Forms.TextBox();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAfterTax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGrossCombined = new System.Windows.Forms.Label();
            this.btnCalcJointSalary = new System.Windows.Forms.Button();
            this.tbxHrlyWg2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGross2 = new System.Windows.Forms.Label();
            this.lblAftrTax2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAfterTaxCombined = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxHrs1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxHrs2 = new System.Windows.Forms.TextBox();
            this.tbxTaxRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxHourlyWage
            // 
            this.tbxHourlyWage.Location = new System.Drawing.Point(188, 61);
            this.tbxHourlyWage.Name = "tbxHourlyWage";
            this.tbxHourlyWage.Size = new System.Drawing.Size(83, 27);
            this.tbxHourlyWage.TabIndex = 0;
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(55, 323);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(108, 63);
            this.btnCalculateSalary.TabIndex = 1;
            this.btnCalculateSalary.Text = "Calculate Single Salary";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gross Wage";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(199, 158);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(0, 20);
            this.lblGross.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "After Tax";
            // 
            // lblAfterTax
            // 
            this.lblAfterTax.AutoSize = true;
            this.lblAfterTax.Location = new System.Drawing.Point(199, 204);
            this.lblAfterTax.Name = "lblAfterTax";
            this.lblAfterTax.Size = new System.Drawing.Size(0, 20);
            this.lblAfterTax.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hourly Wage";
            // 
            // lblGrossCombined
            // 
            this.lblGrossCombined.AutoSize = true;
            this.lblGrossCombined.Location = new System.Drawing.Point(492, 284);
            this.lblGrossCombined.Name = "lblGrossCombined";
            this.lblGrossCombined.Size = new System.Drawing.Size(0, 20);
            this.lblGrossCombined.TabIndex = 7;
            // 
            // btnCalcJointSalary
            // 
            this.btnCalcJointSalary.Location = new System.Drawing.Point(188, 323);
            this.btnCalcJointSalary.Name = "btnCalcJointSalary";
            this.btnCalcJointSalary.Size = new System.Drawing.Size(110, 63);
            this.btnCalcJointSalary.TabIndex = 8;
            this.btnCalcJointSalary.Text = "Calculate Joint Salary";
            this.btnCalcJointSalary.UseVisualStyleBackColor = true;
            this.btnCalcJointSalary.Click += new System.EventHandler(this.btnCalcJointSalary_Click);
            // 
            // tbxHrlyWg2
            // 
            this.tbxHrlyWg2.Location = new System.Drawing.Point(498, 58);
            this.tbxHrlyWg2.Name = "tbxHrlyWg2";
            this.tbxHrlyWg2.Size = new System.Drawing.Size(83, 27);
            this.tbxHrlyWg2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hourly Wage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Person 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Person 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gross Wage";
            // 
            // lblGross2
            // 
            this.lblGross2.AutoSize = true;
            this.lblGross2.Location = new System.Drawing.Point(498, 158);
            this.lblGross2.Name = "lblGross2";
            this.lblGross2.Size = new System.Drawing.Size(0, 20);
            this.lblGross2.TabIndex = 14;
            // 
            // lblAftrTax2
            // 
            this.lblAftrTax2.AutoSize = true;
            this.lblAftrTax2.Location = new System.Drawing.Point(498, 199);
            this.lblAftrTax2.Name = "lblAftrTax2";
            this.lblAftrTax2.Size = new System.Drawing.Size(0, 20);
            this.lblAftrTax2.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "After Tax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Gross Wage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "After Tax";
            // 
            // lblAfterTaxCombined
            // 
            this.lblAfterTaxCombined.AutoSize = true;
            this.lblAfterTaxCombined.Location = new System.Drawing.Point(492, 323);
            this.lblAfterTaxCombined.Name = "lblAfterTaxCombined";
            this.lblAfterTaxCombined.Size = new System.Drawing.Size(0, 20);
            this.lblAfterTaxCombined.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hours Worked per Week";
            // 
            // tbxHrs1
            // 
            this.tbxHrs1.Location = new System.Drawing.Point(188, 110);
            this.tbxHrs1.Name = "tbxHrs1";
            this.tbxHrs1.Size = new System.Drawing.Size(83, 27);
            this.tbxHrs1.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Hours Worked per Week";
            // 
            // tbxHrs2
            // 
            this.tbxHrs2.Location = new System.Drawing.Point(498, 106);
            this.tbxHrs2.Name = "tbxHrs2";
            this.tbxHrs2.Size = new System.Drawing.Size(83, 27);
            this.tbxHrs2.TabIndex = 23;
            // 
            // tbxTaxRate
            // 
            this.tbxTaxRate.Location = new System.Drawing.Point(188, 253);
            this.tbxTaxRate.Name = "tbxTaxRate";
            this.tbxTaxRate.Size = new System.Drawing.Size(83, 27);
            this.tbxTaxRate.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tax Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 437);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxTaxRate);
            this.Controls.Add(this.tbxHrs2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxHrs1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAfterTaxCombined);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAftrTax2);
            this.Controls.Add(this.lblGross2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxHrlyWg2);
            this.Controls.Add(this.btnCalcJointSalary);
            this.Controls.Add(this.lblGrossCombined);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAfterTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateSalary);
            this.Controls.Add(this.tbxHourlyWage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxHourlyWage;
        private Button btnCalculateSalary;
        private Label label1;
        private Label lblGross;
        private Label label3;
        private Label lblAfterTax;
        private Label label5;
        private Label lblGrossCombined;
        private Button btnCalcJointSalary;
        private TextBox tbxHrlyWg2;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label lblGross2;
        private Label lblAftrTax2;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label lblAfterTaxCombined;
        private Label label6;
        private TextBox tbxHrs1;
        private Label label12;
        private TextBox tbxHrs2;
        private TextBox tbxTaxRate;
        private Label label13;
    }
}