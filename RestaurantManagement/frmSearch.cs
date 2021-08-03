using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restaurant_Management.BLL;
using Restaurant_Management.DAL;
using Converting_Date;
using System.Globalization;

namespace RestaurantManagement
{
    public partial class frmSearch : Form
    {
        SqlConnection Connection = new SqlConnection(RestaurantManagementDAL.ConnectionString);
        SqlCommand Command = new SqlCommand();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void txtFoodName_TextChanged(object sender, EventArgs e)
        {
            DataSet oDataSet = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select Invoice.TableNo as [شماره میز], FoodName as [نام غذا], Invoice.InvoiceNo as [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت هرواحد], Invoice.InvoiceAmount As [هزینه کل (ریال)], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where Invoice.ID=Invoice_ID AND FoodName Like @N";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@N", txtFoodName.Text + "%");
            DataAdapter.Fill(oDataSet, "T1");
            dgvSearching.DataSource = oDataSet;
            dgvSearching.DataMember = "T1";
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            DataSet oDataSet = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select Invoice.TableNo as [شماره میز], FoodName as [نام غذا], Invoice.InvoiceNo as [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت هرواحد], Invoice.InvoiceAmount As [هزینه کل (ریال)], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where Invoice.ID=Invoice_ID AND InvoiceDate Like @N";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@N", txtDate.Text + "%");
            DataAdapter.Fill(oDataSet, "T1");
            dgvSearching.DataSource = oDataSet;
            dgvSearching.DataMember = "T1";
        }

        private void txtFoodCode_TextChanged(object sender, EventArgs e)
        {
            DataSet oDataSet = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select Invoice.TableNo as [شماره میز], FoodName as [نام غذا], Invoice.InvoiceNo as [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت هرواحد], Invoice.InvoiceAmount As [هزینه کل (ریال)], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where Invoice.ID=Invoice_ID AND InvoiceNo Like @N";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@N", txtInvoiceNo.Text + "%");
            DataAdapter.Fill(oDataSet, "T1");
            dgvSearching.DataSource = oDataSet;
            dgvSearching.DataMember = "T1";
        }

        private void txtTableNo_TextChanged(object sender, EventArgs e)
        {
            DataSet oDataSet = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select Invoice.TableNo as [شماره میز], FoodName as [نام غذا], Invoice.InvoiceNo as [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت هرواحد], Invoice.InvoiceAmount As [هزینه کل (ریال)], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where Invoice.ID=Invoice_ID AND TableNo Like @N";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@N", txtTableNo.Text + "%");
            DataAdapter.Fill(oDataSet, "T1");
            dgvSearching.DataSource = oDataSet;
            dgvSearching.DataMember = "T1";
        }

        private void cmbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet oDataSet = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.SelectCommand.CommandText = "Select Invoice.TableNo as [شماره میز], FoodName as [نام غذا], Invoice.InvoiceNo as [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت هرواحد], Invoice.InvoiceAmount As [هزینه کل (ریال)], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where Invoice.ID=Invoice_ID AND InvoiceType Like @N";
            DataAdapter.SelectCommand.Parameters.AddWithValue("@N", cmbInvoiceType.SelectedItem.ToString() + "%");
            DataAdapter.Fill(oDataSet, "T1");
            dgvSearching.DataSource = oDataSet;
            dgvSearching.DataMember = "T1";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DataSet oDataSet = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            DataAdapter.SelectCommand = new SqlCommand();
            DataAdapter.SelectCommand.Connection = Connection;

            DataAdapter.SelectCommand.CommandText = string.Format("Select Invoice.TableNo as [شماره میز], FoodName as [نام غذا], Invoice.InvoiceNo as [شماره فاکتور], Invoice.InvoiceType As [نوع فاکتور], SoldEntries.[Count] As [تعداد], SoldEntries.PriceForOne As [قیمت هرواحد], Invoice.InvoiceAmount As [هزینه کل (ریال)], Invoice.InvoiceDate As [تاریخ فاکتور] from Invoice, SoldEntries Where InvoiceDate >= @StartDate And InvoiceDate <= @EndDate And Invoice_ID=Invoice.ID");
            DataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", Converting.AddingStartDate(mtbStartDate.Text) + "%");
            DataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", Converting.AddingEndDate(mtbEndDate.Text) + "%");

            DataAdapter.Fill(oDataSet, "T1");
            dgvSearching.DataSource = oDataSet;
            dgvSearching.DataMember = "T1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime oDateTime = DateTime.Now;
            Converting oConverting= new Converting();
            mtbEndDate.Text = oConverting.PersianDate(oDateTime.ToString(), false, true);
            mtbStartDate.Text = oConverting.PersianDate(oDateTime.ToString(), false, true);
        }

    }
}
