using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RestaurantManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInvoiceIssuance_Click(object sender, EventArgs e)
        {
            frmInvoiceIssuance invoice = new frmInvoiceIssuance();
            frmFoodsList FoodList = new frmFoodsList();
            invoice.Show();
            FoodList.Show();
        }

        private void btnFoodList_Click(object sender, EventArgs e)
        {
            frmFoodsList List = new frmFoodsList();
            List.ShowDialog();
        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            frmAddNewFood oAddNewFood = new frmAddNewFood();
            oAddNewFood.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch oSearch = new frmSearch();
            oSearch.Show();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            frmReportOptions oReportOptions = new frmReportOptions();
            oReportOptions.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar P = new PersianCalendar();
            this.label2.Text = string.Format("ساعت: {0:HH:mm:ss}", DateTime.Now);

            Converting_Date.Converting C = new Converting_Date.Converting();
            this.label3.Text = "تاریخ امروز: " + C.ConvertDay() + " " + P.GetDayOfMonth(DateTime.Now) + " " + C.ConvertMonth() + " " + P.GetYear(DateTime.Now);
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.ShowDialog();
        }

    }
}
