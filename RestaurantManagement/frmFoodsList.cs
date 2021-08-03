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

namespace RestaurantManagement
{
    public partial class frmFoodsList : Form
    {
        public frmFoodsList()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = RestaurantManagementDAL.GetFoodEntries();
            dgvFoodsList.DataSource = null;
            dgvFoodsList.DataSource = Table;
        }
        private void frmFoodsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantManageMentDataSet.Food' table. You can move, or remove it, as needed.
           // this.foodTableAdapter.Fill(this.restaurantManageMentDataSet.Food);
            FillGrid();
        }
    }
}
