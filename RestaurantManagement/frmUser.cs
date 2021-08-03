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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {

            DataTable Table = RestaurantManagementDAL.GetAllUsers();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = Table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.Username = txtUsername.Text.Trim();
            oUser.Password = txtPassword.Text.Trim();

            RestaurantManagementDAL.NewUser(oUser);

            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

            FillGrid();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView DataRow = (DataRowView)dgvUsers.SelectedRows[0].DataBoundItem;
            int id = (int)DataRow.Row["ID"];

            RestaurantManagementDAL.DeleteUser(id);
            FillGrid();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnDeleteRow.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
