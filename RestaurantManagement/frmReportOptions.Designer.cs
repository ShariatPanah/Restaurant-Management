namespace RestaurantManagement
{
    partial class frmReportOptions
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbYearReport = new System.Windows.Forms.RadioButton();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMonthlyReport = new System.Windows.Forms.RadioButton();
            this.rdbDailyReport = new System.Windows.Forms.RadioButton();
            this.btnToday = new System.Windows.Forms.Button();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbYearReport);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbMonthlyReport);
            this.groupBox1.Controls.Add(this.rdbDailyReport);
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.mtbDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع گزارش";
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(115, 176);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(138, 21);
            this.txtYear.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(274, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "سال:";
            // 
            // rdbYearReport
            // 
            this.rdbYearReport.AutoSize = true;
            this.rdbYearReport.Location = new System.Drawing.Point(249, 153);
            this.rdbYearReport.Name = "rdbYearReport";
            this.rdbYearReport.Size = new System.Drawing.Size(88, 17);
            this.rdbYearReport.TabIndex = 7;
            this.rdbYearReport.TabStop = true;
            this.rdbYearReport.Text = "گزارش سالانه";
            this.rdbYearReport.UseVisualStyleBackColor = true;
            this.rdbYearReport.CheckedChanged += new System.EventHandler(this.rdbYearReport_CheckedChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Enabled = false;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.cmbMonth.Location = new System.Drawing.Point(115, 113);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMonth.Size = new System.Drawing.Size(138, 21);
            this.cmbMonth.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(274, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ماه:";
            // 
            // rdbMonthlyReport
            // 
            this.rdbMonthlyReport.AutoSize = true;
            this.rdbMonthlyReport.Location = new System.Drawing.Point(249, 90);
            this.rdbMonthlyReport.Name = "rdbMonthlyReport";
            this.rdbMonthlyReport.Size = new System.Drawing.Size(87, 17);
            this.rdbMonthlyReport.TabIndex = 4;
            this.rdbMonthlyReport.TabStop = true;
            this.rdbMonthlyReport.Text = "گزارش ماهانه";
            this.rdbMonthlyReport.UseVisualStyleBackColor = true;
            this.rdbMonthlyReport.CheckedChanged += new System.EventHandler(this.rdbMonthlyReport_CheckedChanged);
            // 
            // rdbDailyReport
            // 
            this.rdbDailyReport.AutoSize = true;
            this.rdbDailyReport.Location = new System.Drawing.Point(253, 30);
            this.rdbDailyReport.Name = "rdbDailyReport";
            this.rdbDailyReport.Size = new System.Drawing.Size(83, 17);
            this.rdbDailyReport.TabIndex = 3;
            this.rdbDailyReport.TabStop = true;
            this.rdbDailyReport.Text = "گزارش روزانه";
            this.rdbDailyReport.UseVisualStyleBackColor = true;
            this.rdbDailyReport.CheckedChanged += new System.EventHandler(this.rdbDailyReport_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.Enabled = false;
            this.btnToday.Location = new System.Drawing.Point(34, 51);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 2;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // mtbDate
            // 
            this.mtbDate.Enabled = false;
            this.mtbDate.Location = new System.Drawing.Point(115, 53);
            this.mtbDate.Mask = "0000-00-00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbDate.Size = new System.Drawing.Size(138, 21);
            this.mtbDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(274, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ:";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(274, 247);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 1;
            this.btnGetReport.Text = "تهیه گزارش";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(46, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش گیری";
            this.Load += new System.EventHandler(this.frmReportOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbYearReport;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMonthlyReport;
        private System.Windows.Forms.RadioButton rdbDailyReport;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Button btnCancel;
    }
}