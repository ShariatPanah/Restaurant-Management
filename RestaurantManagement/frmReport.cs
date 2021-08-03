using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmReport : Form
    {
        Reporting MyReport = new Reporting();
        public frmReport(Reporting _report)
        {
            InitializeComponent();
            MyReport = _report;
            
        }
        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = MyReport;
        }
    }
}
