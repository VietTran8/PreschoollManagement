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
    public partial class fAccountMana : Form
    {
        private static bool isUpdate = false;
        public fAccountMana()
        {
            InitializeComponent();
        }

        private void Unvisible_Button()
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void Visible_Button()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }

        private void Disable_Button()
        {
            btnChangeRole.Enabled = false;
            btnResetPassword.Enabled = false;
            btnDeleteAccount.Enabled = false;
        }

        private void Enable_Button()
        {
            btnChangeRole.Enabled = true;
            btnResetPassword.Enabled = true;
            btnDeleteAccount.Enabled = true;
        }

        private void Disable_InputControl() 
        {
            txbPassword.Enabled = false;
            txbUsername.Enabled = false;
            cbRole.Enabled = false;
        }

        private void Enable_InputControl()
        {
            txbPassword.Enabled = true;
            txbUsername.Enabled = true;
            cbRole.Enabled = true;
        }

        private void fAccountMana_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {

            Load_ListAccount();

            Unvisible_Button();
            Disable_InputControl();
            btnCreate.Visible = true;
            Disable_Button();

            //Custom column header text
            dgvAccount.Columns[0].HeaderText = "Tên tài khoản";
            dgvAccount.Columns[1].HeaderText = "Mật khẩu";
            dgvAccount.Columns[2].HeaderText = "Vai trò";

            Clear_TextBox();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Visible_Button();
            Disable_Button();

            btnCreate.Visible = false;
            Enable_InputControl();
            isUpdate = false;

            Clear_TextBox();

            btnSave.Text = "Tạo";

        }

        private void Clear_TextBox()
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
            cbRole.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init();
            Clear_TextBox();

        }

        private void Load_ListAccount()
        {
            dgvAccount.DataSource = AccountController.getListAccount();
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            cbRole.Enabled = true;
            Visible_Button();
            btnDeleteAccount.Enabled = false;
            btnResetPassword.Enabled = false;
            isUpdate = true;

            btnSave.Text = "Lưu";

        }

        private static int ConvertRoleToInt(string role)
        {
            switch (role)
            {
                case "Quản trị viên":
                    return 0;
                case "Tổ chuyên môn":
                    return 1;
                case "Giáo viên":
                    return 2;
                case "Kế toán":
                    return 3;
                case "Cấp dưỡng":
                    return 4;
                default:
                    return -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                if (txbUsername.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txbUsername.Focus();
                }
                else if (cbRole.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn vai trò", "Thông báo");
                }
                else if (MessageBox.Show("Bạn có chắc là muốn tạo tài khoản?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string username = txbUsername.Text;
                    string password = txbPassword.Text;
                    int role = ConvertRoleToInt(cbRole.Text);

                    string message = AccountController.createAccount(username, password, role);
                    MessageBox.Show(message, "Thông báo");
                    Init();
                }
            }
            else
            {
                btnSave.Text = "Lưu";

                if (MessageBox.Show("Bạn có chắc là muốn cập nhật vai trò của người dùng " + txbUsername.Text + "?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string username = txbUsername.Text;
                    int role = ConvertRoleToInt(cbRole.Text);

                    string result = AccountController.updateRole(role, username);

                    MessageBox.Show(result, "Thông báo");
                    Init();
                }
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Disable_InputControl();
                Enable_Button();
                Unvisible_Button();

                

                DataGridViewRow selectedRow = dgvAccount.Rows[e.RowIndex];

                txbUsername.Text = selectedRow.Cells[0].Value.ToString();
                txbPassword.Text = selectedRow.Cells[1].Value.ToString();
                
                cbRole.Text = selectedRow.Cells[2].Value.ToString();

                
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa tài khoản " + txbUsername.Text + "?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string message = AccountController.deleteAccount(txbUsername.Text);

                MessageBox.Show(message, "Thông báo");
                Init();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            fResetPassword form = new fResetPassword(txbUsername.Text);
            form.ShowDialog();
            Init();
        }

        private void ckbSeePass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSeePass.Checked == true)
            {
                txbPassword.PasswordChar = (char)0;
            }
            else
            {
                txbPassword.PasswordChar = '*';
            }
        }
    }
}
