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
        public fAccountConfig()
        {
            InitializeComponent();
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
