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

namespace RestaurantManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (RestaurantManagementDAL.Login(txtUser.Text.ToString(), txtPass.Text.ToString()) != 0) 
            {
                frmMain Main = new frmMain();
                Main.Show();
                this.Hide();
                Main.FormClosed += Main_FormClosed;
            }
            else
            {
                MessageBox.Show("!نام كاربري يا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = txtPass.Text = string.Empty;
            }
        }

        void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
