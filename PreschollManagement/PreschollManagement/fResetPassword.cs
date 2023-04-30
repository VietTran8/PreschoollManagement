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
    public partial class fResetPassword : Form
    {
        private string username;
        public fResetPassword()
        {
            InitializeComponent();
        }

        public fResetPassword(string username)
        {
            this.username = username;
            InitializeComponent();

        }

        private void fResetPassword_Load(object sender, EventArgs e)
        {
            txbUsername.Text = this.username;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
             if (txbNewPassword.Text != txbReNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                string username = txbUsername.Text;
                string password = txbNewPassword.Text;

                string message = AccountController.resetPassword(username, password);
                MessageBox.Show(message, "Thông báo");
                this.Close();
            }
        }
    }
}
