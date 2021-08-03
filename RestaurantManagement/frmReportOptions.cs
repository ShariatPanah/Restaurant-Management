using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.BLL;
using Restaurant_Management.DAL;
using Converting_Date;

namespace RestaurantManagement
{
    public partial class frmReportOptions : Form
    {
        string End = string.Empty;
        string Start = string.Empty;
        public frmReportOptions()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            Converting oConvertin = new Converting();
            mtbDate.Text = Start = oConvertin.PersianDate(Date.ToString(), false, true);
        }

        private void frmReportOptions_Load(object sender, EventArgs e)
        {
            rdbDailyReport.Checked = true;
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            if (rdbDailyReport.Checked == true)
            {
                Start = Converting.AddingStartDate(mtbDate.Text);
                End = Converting.AddingEndDate(mtbDate.Text);
                Reporting MyReport = new Reporting();
                string Formula = "{Invoice.InvoiceDate} in '" + Start + "' to '" + End + "'";
                MyReport.DataDefinition.RecordSelectionFormula = Formula;
                frmReport oReport = new frmReport(MyReport);
                oReport.ShowDialog();
            }
            else if (rdbMonthlyReport.Checked == true)
            {
                Start = Converting.AddingStartMonth(DateTime.Now.ToString(), cmbMonth.SelectedIndex + 1);
                End = Converting.AddingEndMonth(DateTime.Now.ToString(), cmbMonth.SelectedIndex + 1);
                Reporting MyReport = new Reporting();
                string Formula = "{Invoice.InvoiceDate} in '" + Start + "' to '" + End + "'";
                MyReport.DataDefinition.RecordSelectionFormula = Formula;
                frmReport oReport = new frmReport(MyReport);
                oReport.ShowDialog();
            }
            else if (rdbYearReport.Checked == true)
            {
                Start = Converting.AddingStartYear(Convert.ToInt32(txtYear.Text));
                End = Converting.AddingEndYear(Convert.ToInt32(txtYear.Text));
                Reporting MyReport = new Reporting();
                string Formula = "{Invoice.InvoiceDate} in '" + Start + "' to '" + End + "'";
                MyReport.DataDefinition.RecordSelectionFormula = Formula;
                frmReport oReport = new frmReport(MyReport);
                oReport.ShowDialog();
            }
        }

        private void rdbDailyReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDailyReport.Checked == true)
            {
                label1.Enabled = true;
                mtbDate.Enabled = true;
                btnToday.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                mtbDate.Enabled = false;
                btnToday.Enabled = false;
            }
        }

        private void rdbMonthlyReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMonthlyReport.Checked == true)
            {
                label2.Enabled = true;
                cmbMonth.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
                cmbMonth.Enabled = false;
            }
        }

        private void rdbYearReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYearReport.Checked == true)
            {
                label3.Enabled = true;
                txtYear.Enabled = true;
            }
            else
            {
                label3.Enabled = false;
                txtYear.Enabled = false;
            }
        }
    }
}
