namespace RestaurantManagement
{
    partial class frmInvoiceIssuance
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInvoiceType = new System.Windows.Forms.ComboBox();
            this.txtInvoiceNo = new System.Windows.Forms.MaskedTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmitPrint = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtFoodCode = new System.Windows.Forms.TextBox();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.soldEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManageMentDataSet = new RestaurantManagement.RestaurantManageMentDataSet();
            this.soldEntriesTableAdapter = new RestaurantManagement.RestaurantManageMentDataSetTableAdapters.SoldEntriesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManageMentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(413, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره فاکتور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(398, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "شماره میز:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(548, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد غذا:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(239, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "تعداد:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbInvoiceType);
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSubmitPrint);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.txtFoodCode);
            this.groupBox1.Controls.Add(this.txtTableNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات فاکتور";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(365, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "شماره فاکتور چهار رقمی است، برای مثال: 1001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(262, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "نوع فاکتور:";
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.FormattingEnabled = true;
            this.cmbInvoiceType.Items.AddRange(new object[] {
            "خارجی",
            "داخلی"});
            this.cmbInvoiceType.Location = new System.Drawing.Point(177, 37);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Size = new System.Drawing.Size(72, 21);
            this.cmbInvoiceType.TabIndex = 1;
            this.cmbInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cmbInvoiceType_SelectedIndexChanged);
            this.cmbInvoiceType.SelectionChangeCommitted += new System.EventHandler(this.cmbInvoiceType_SelectionChangeCommitted);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(365, 36);
            this.txtInvoiceNo.Mask = "0000";
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvoiceNo.Size = new System.Drawing.Size(42, 21);
            this.txtInvoiceNo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(6, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmitPrint
            // 
            this.btnSubmitPrint.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitPrint.Location = new System.Drawing.Point(548, 148);
            this.btnSubmitPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitPrint.Name = "btnSubmitPrint";
            this.btnSubmitPrint.Size = new System.Drawing.Size(130, 46);
            this.btnSubmitPrint.TabIndex = 5;
            this.btnSubmitPrint.Text = "ثبت و چاپ";
            this.btnSubmitPrint.UseVisualStyleBackColor = true;
            this.btnSubmitPrint.Click += new System.EventHandler(this.btnSubmitPrint_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(122, 120);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 4;
            // 
            // txtFoodCode
            // 
            this.txtFoodCode.Location = new System.Drawing.Point(351, 120);
            this.txtFoodCode.Name = "txtFoodCode";
            this.txtFoodCode.Size = new System.Drawing.Size(180, 21);
            this.txtFoodCode.TabIndex = 3;
            // 
            // txtTableNo
            // 
            this.txtTableNo.Enabled = false;
            this.txtTableNo.Location = new System.Drawing.Point(249, 83);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(132, 21);
            this.txtTableNo.TabIndex = 2;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(12, 215);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoice.Size = new System.Drawing.Size(688, 310);
            this.dgvInvoice.TabIndex = 8;
            // 
            // soldEntriesBindingSource
            // 
            this.soldEntriesBindingSource.DataMember = "SoldEntries";
            this.soldEntriesBindingSource.DataSource = this.restaurantManageMentDataSet;
            // 
            // restaurantManageMentDataSet
            // 
            this.restaurantManageMentDataSet.DataSetName = "RestaurantManageMentDataSet";
            this.restaurantManageMentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soldEntriesTableAdapter
            // 
            this.soldEntriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoiceIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 537);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInvoiceIssuance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور فاکتور";
            this.Load += new System.EventHandler(this.frmInvoiceIssuance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManageMentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmitPrint;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtFoodCode;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private RestaurantManageMentDataSet restaurantManageMentDataSet;
        private System.Windows.Forms.BindingSource soldEntriesBindingSource;
        private RestaurantManageMentDataSetTableAdapters.SoldEntriesTableAdapter soldEntriesTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox txtInvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInvoiceType;
        private System.Windows.Forms.Label label7;
    }
}