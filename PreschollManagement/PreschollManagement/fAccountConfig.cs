using PreschollManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreschollManagement
{
    public partial class fAccountConfig : Form
    {
        private static string username;
        public fAccountConfig(string nusername)
        {
            InitializeComponent();
            username = nusername;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isShowed = false;
        bool isShowedNew = false;
        bool isShowedReNew = false;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txbNewPassword.Text != txbReNewPassword.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                string message = AccountController.changePassword(username, txbOldPassword.Text, txbReNewPassword.Text);
                MessageBox.Show(message, "Thông báo");
                txbNewPassword.Text = string.Empty;
                txbOldPassword.Text = string.Empty;
                txbReNewPassword.Text = string.Empty;

            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (!isShowed)
            {
                txbOldPassword.UseSystemPasswordChar = false;
                isShowed = true;
            }
            else
            {
                txbOldPassword.UseSystemPasswordChar = true;
                isShowed = false;
            }
        }

        private void btnShowNewPass_Click(object sender, EventArgs e)
        {
            if (!isShowedNew)
            {
                txbNewPassword.UseSystemPasswordChar = false;
                isShowedNew = true;
            }
            else
            {
                txbNewPassword.UseSystemPasswordChar = true;
                isShowedNew = false;
            }
        }

        private void btnShowRePass_Click(object sender, EventArgs e)
        {
            if (!isShowedReNew)
            {
                txbReNewPassword.UseSystemPasswordChar = false;
                isShowedReNew = true;
            }
            else
            {
                txbReNewPassword.UseSystemPasswordChar = true;
                isShowedReNew = false;
            }
        }
    }
}
