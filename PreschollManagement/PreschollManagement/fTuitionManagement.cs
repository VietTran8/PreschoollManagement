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
    public partial class fTuitionManagement : Form
    {
        public fTuitionManagement()
        {
            InitializeComponent();
        }

        private void Enable_Function() {
            picDeleteStudent.Enabled = true;
            picEditStudent.Enabled = true;
        }

        private void Disable_Function() {
            picDeleteStudent.Enabled = false;
            picEditStudent.Enabled = false;
        }

        private void picDeleteStudent_MouseEnter(object sender, EventArgs e)
        {
            if (picDeleteStudent.Enabled) {
                picDeleteStudent.BackColor = Color.CornflowerBlue;
            }
        }

        private void picDeleteStudent_MouseLeave(object sender, EventArgs e)
        {
            if (picDeleteStudent.Enabled) {
                picDeleteStudent.BackColor = Color.Transparent;
            }
        }

        private void Disable_InputControl() 
        {
            txbYear.Enabled = false;
            cbStatus.Enabled = false;
            dtpExpirationDate.Enabled = false;
            dtpPaymentDate.Enabled = false;
            txbMethodPayment.Enabled = false;
            cbStudentId.Enabled = false;
            foreach (Control con in gbFees.Controls) {
                if (con is TextBox) 
                {
                    con.Enabled = false;
                }
            }
        }

        private void Enable_InputControl()
        {
            txbYear.Enabled = true;
            cbStatus.Enabled = true;
            dtpExpirationDate.Enabled = true;
            dtpPaymentDate.Enabled = true;
            txbMethodPayment.Enabled = true;
            foreach (Control con in gbFees.Controls)
            {
                if (con is TextBox)
                {
                    con.Enabled = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Enable_Function();
        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            Disable_Function();
        }

        private void picDeleteStudent_EnabledChanged(object sender, EventArgs e)
        {
            picDeleteStudent.BackColor = picDeleteStudent.Enabled ? Color.Transparent : Color.Maroon;
        }

        private void picEditStudent_MouseEnter(object sender, EventArgs e)
        {
            if (picEditStudent.Enabled) 
            {
                picEditStudent.BackColor = Color.CornflowerBlue;
            }
        }

        private void picEditStudent_MouseLeave(object sender, EventArgs e)
        {
            if (picEditStudent.Enabled)
            {
                picEditStudent.BackColor = Color.Transparent;
            }
        }

        private void picEditStudent_EnabledChanged(object sender, EventArgs e)
        {
            picEditStudent.BackColor = picEditStudent.Enabled ? Color.Transparent : Color.Maroon;
        }

        private void picPrint_MouseEnter(object sender, EventArgs e)
        {
            picPrint.BackColor = Color.CornflowerBlue;
        }

        private void picPrint_MouseLeave(object sender, EventArgs e)
        {
            picPrint.BackColor = Color.Transparent;
        }

        private void picEditStudent_Click(object sender, EventArgs e)
        {
            Enable_InputControl();
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Disable_InputControl();
            btnSave.Enabled = false;
            btnSave.Text = "Lưu";
            cbStudentId.Enabled = false;
        }

        private void fTuitionManagement_Load(object sender, EventArgs e)
        {
            Disable_InputControl();
            rdoById.Checked = true;
        }

        private void picAddStudent_MouseEnter(object sender, EventArgs e)
        {
            picAddStudent.BackColor = Color.CornflowerBlue;
        }

        private void picAddStudent_MouseLeave(object sender, EventArgs e)
        {
            picAddStudent.BackColor = Color.Transparent;
        }

        private void picAddStudent_Click(object sender, EventArgs e)
        {
            Enable_InputControl();
            btnSave.Enabled = true;
            btnSave.Text = "Thêm";
            cbStudentId.Enabled = true;
        }

        private void picPrint_Click(object sender, EventArgs e)
        {
            fChooseClass form = new fChooseClass();
            form.ShowDialog();
        }

        private void txbTuition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbAlimony_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbOtherFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
