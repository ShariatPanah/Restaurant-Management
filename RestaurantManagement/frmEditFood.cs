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
    public partial class frmEditFood : Form
    {
        int _id;
        public frmEditFood(int _ID)
        {
            InitializeComponent();
            _id = _ID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditFood_Load(object sender, EventArgs e)
        {
            Food oFood = new Food();
            oFood = RestaurantManagementDAL.RetrieveFood(_id);
            txtFoodName.Text = oFood.FoodName;
            txtFoodCode.Text = oFood.FoodCode.ToString();
            txtPrice.Text = oFood.Price.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Food oFood = new Food();
            oFood.FoodName = txtFoodName.Text;
            oFood.FoodCode = Convert.ToInt32(txtFoodCode.Text);
            oFood.Price = Convert.ToInt64(txtPrice.Text);

            RestaurantManagementDAL.UpdateFood(_id, oFood);

            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            this.Close();
        }

        
    }
}
