using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DAL;
using Restaurant_Management.BLL;
using Converting_Date;
using System.Globalization;

namespace RestaurantManagement
{
    public partial class frmInvoiceIssuance : Form
    {
        public frmInvoiceIssuance()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            SqlConnection Connection = new SqlConnection(RestaurantManagementDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataSet oDataSet = new DataSet();
            Connection.Open();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandType = CommandType.Text;
            DataAdapter.SelectCommand.CommandText = string.Format
                ("Select  Invoice.TableNo As [شماره میز], FoodName As [نام غذا], Invoice.InvoiceNo As [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت واحد (ریال)], Invoice.InvoiceAmount As [مبلغ فاکتور], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where Invoice.ID=Invoice_ID");

            DataAdapter.Fill(oDataSet, "T1");
            dgvInvoice.DataSource = null;
            dgvInvoice.DataMember = null;
            dgvInvoice.DataSource = oDataSet;
            dgvInvoice.DataMember = "T1";
        }
        private void frmInvoiceIssuance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManageMentDataSet.SoldEntries' table. You can move, or remove it, as needed.
            //this.soldEntriesTableAdapter.Fill(this.restaurantManageMentDataSet.SoldEntries);
            cmbInvoiceType.SelectedIndex = 0;
            FillGrid();
        }

        private void btnSubmitPrint_Click(object sender, EventArgs e)
        {
            Food oFood = RestaurantManagementDAL.RetrieveByCode(Convert.ToInt32(txtFoodCode.Text));
            Invoice oInvoice = new Invoice();
            SoldEntries OSoldEntries = new SoldEntries();
            if (!String.IsNullOrEmpty(txtInvoiceNo.Text))
            {
                oInvoice.InvoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
            }
            else
                MessageBox.Show("شماره فاکتور را وارد کنید");

            if (!String.IsNullOrEmpty(txtFoodCode.Text))
            {
                oInvoice.FoodCode = oFood.FoodCode;
            }
            else
                MessageBox.Show("کد غذا را وارد کنید");

            if (!String.IsNullOrEmpty(txtCount.Text))
            {
                oInvoice.FoodCount = Convert.ToInt32(txtCount.Text);
                OSoldEntries.FoodCount = Convert.ToInt32(txtCount.Text);
            }
            else
                MessageBox.Show("تعداد پُرس را وارد کنید");

            OSoldEntries.FoodName = oFood.FoodName;
            OSoldEntries.PriceForOne = oFood.Price;
            if (cmbInvoiceType.SelectedIndex == 0) 
            {
                oInvoice.TableNo = 0;
            }
            else
            {
                oInvoice.TableNo = Convert.ToInt32(txtTableNo.Text);
            }
            Converting oConverting = new Converting();

            oInvoice.InvoiceType = cmbInvoiceType.SelectedItem.ToString();
            oInvoice.InvoiceDate = oConverting.PersianDate(DateTime.Now.ToString(), true, true);
            oInvoice.PriceForOne = oFood.Price;
            oInvoice.Amount = oInvoice.FoodCount * oFood.Price;

            RestaurantManagementDAL.InsertFactor(oInvoice);
            RestaurantManagementDAL.InsertSoldEntries(OSoldEntries);

            txtCount.Text = "";
            txtFoodCode.Text = "";
            txtInvoiceNo.Text = "";
            txtTableNo.Text = "";
            cmbInvoiceType.SelectedIndex = 0;
            txtInvoiceNo.Focus();

            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbInvoiceType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cmbInvoiceType.SelectedItem=="خارجی")
            //{
            //    txtTableNo.Enabled = false;
            //}
            //else
            //{
            //    txtTableNo.Enabled = true;
            //}
        }

        private void cmbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInvoiceType.SelectedIndex == 0)
            {
                txtTableNo.Enabled = false;
            }
            else
            {
                txtTableNo.Enabled = true;
            }
        }

    }
}
