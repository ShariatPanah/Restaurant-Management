using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DAL;
using Restaurant_Management.BLL;

namespace RestaurantManagement
{
    public partial class frmAddNewFood : Form
    {
        public frmAddNewFood()
        {
            InitializeComponent();
        }
        public void FillGrid()
        {
            DataTable Table = RestaurantManagementDAL.GetFoodEntries();
            dgvADDFood.DataSource = null;
            dgvADDFood.DataSource = Table;
        }
        private void frmAddNewFood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManageMentDataSet.Food' table. You can move, or remove it, as needed.
            //this.foodTableAdapter.Fill(this.restaurantManageMentDataSet.Food);
            FillGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvADDFood.SelectedRows.Count > 0)
            {
                btnDeleteFood.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDeleteFood.Enabled = false;
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = (DataRowView)dgvADDFood.SelectedRows[0].DataBoundItem;
            int _id = (int)oDataRowView.Row["ID"];
            RestaurantManagementDAL.DeleteFoodRow(_id);
            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Food oFood = new Food();
            oFood.FoodName = txtFoodName.Text;
            oFood.FoodCode = Convert.ToInt32(txtFoodCode.Text);
            oFood.Price = Convert.ToInt64(txtPrice.Text);

            RestaurantManagementDAL.InsertFoods(oFood);

            txtFoodCode.Text = "";
            txtFoodName.Text = "";
            txtPrice.Text = "";

            FillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvADDFood.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];
            frmEditFood EditFood = new frmEditFood(id);
            EditFood.Show();
            EditFood.FormClosed += EditFood_FormClosed;
        }

        void EditFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }
    }
}
