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
    public partial class fTuitionManagement : Form
    {
        bool isUpdate = false;
        private Dictionary<string, List<string>> listStudentId = TuitionController.fetchStudent();
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
            string input = txbSearch.Text;
            if (input == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else {
                bool isChecked = rdoById.Checked;
                if (isChecked)
                    dgvListTuition.DataSource = TuitionController.getListTuitionById(input);
                else
                    dgvListTuition.DataSource = TuitionController.getListTuitionByLastName(input);

            }
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
            isUpdate = true;
            Enable_InputControl();
            picAddStudent.Enabled = false;
            picDeleteStudent.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void fTuitionManagement_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            Disable_InputControl();
            rdoById.Checked = true;
            Load_ListTuition();
            Load_StudentId();

            Clear_Input();

            btnSave.Enabled = false;
            btnSave.Text = "Lưu";
            cbStudentId.Enabled = false;
            picAddStudent.Enabled = true;

            Disable_Function();


            FormatDtp.FormatDateTimePicker(dtpExpirationDate, "dd-MM-yyyy");
            FormatDtp.FormatDateTimePicker(dtpPaymentDate, "dd-MM-yyyy");

        }

        private void Load_ListTuition()
        {
            DataTable table = TuitionController.getListTuition();
            if (table != null)
            {
                dgvListTuition.DataSource = table;
            }
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
            isUpdate = false;
            Enable_InputControl();
            Disable_Function();
            btnSave.Enabled = true;
            btnSave.Text = "Thêm";
            cbStudentId.Enabled = true;
            Clear_Input();
        }


        private void Clear_Input()
        {
            foreach (Control con in pnlInfo.Controls)
            { 
                if(!(con is Label) && !(con is Button))
                {
                    con.Text = "";
                }
            }
            foreach (Control con in gbFees.Controls)
            {
                if (!(con is Label))
                {
                    con.Text = "";
                }
            }
        }

        private void picPrint_Click(object sender, EventArgs e)
        {
            fTuitionConfirmPrint form = new fTuitionConfirmPrint();
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

        private void dgvListTuition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Disable_InputControl();
                picAddStudent.Enabled = true;
                picDeleteStudent.Enabled = true;
                picEditStudent.Enabled = true;

                DataGridViewRow selectedRow = dgvListTuition.Rows[e.RowIndex];

                txbTuitionId.Text = selectedRow.Cells["Mã học phí"].Value.ToString();
                cbStudentId.Text = selectedRow.Cells["Mã học sinh"].Value.ToString();
                cbClass.Text = selectedRow.Cells["Lớp"].Value.ToString();
                txbStudentFirstName.Text = selectedRow.Cells["Họ học sinh"].Value.ToString();
                txbStudentLastName.Text = selectedRow.Cells["Tên học sinh"].Value.ToString();
                txbYear.Text = selectedRow.Cells["Năm học"].Value.ToString();
                cbStatus.Text = selectedRow.Cells["Trạng thái"].Value.ToString();

                string[] eps = selectedRow.Cells["Hạn đóng"].Value.ToString().Split('-');
                DateTime expiredDate = new DateTime(int.Parse(eps[2]), int.Parse(eps[1]), int.Parse(eps[0]));
                dtpExpirationDate.Value = expiredDate;

                eps = selectedRow.Cells["Ngày đóng"].Value.ToString().Split('-');
                DateTime paymentdDate = new DateTime(int.Parse(eps[2]), int.Parse(eps[1]), int.Parse(eps[0]));
                dtpPaymentDate.Value = paymentdDate;

                txbMethodPayment.Text = selectedRow.Cells["PTTT"].Value.ToString();
                txbTuition.Text = selectedRow.Cells["Học phí"].Value.ToString();
                txbInsurance.Text = selectedRow.Cells["Phí bảo hiểm"].Value.ToString();
                txbAlimony.Text = selectedRow.Cells["Phí cấp dưỡng"].Value.ToString();
                txbOtherFees.Text = selectedRow.Cells["Phí khác"].Value.ToString();
            }
        }

        private void picAddStudent_EnabledChanged(object sender, EventArgs e)
        {
            picAddStudent.BackColor = picAddStudent.Enabled ? Color.Transparent : Color.Maroon;
        }

        private void Load_StudentId()
        {
            cbStudentId.Items.Clear();
            if (this.listStudentId != null)
            {
                foreach (KeyValuePair<string, List<string>> each in listStudentId) 
                {
                    cbStudentId.Items.Add(each.Key);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                if (MessageBox.Show("Bạn có chắc là muốn thêm thông tin học phí?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int year = int.Parse(txbYear.Text);
                    string expiredDate = dtpExpirationDate.Text;
                    float tuition = float.Parse(txbTuition.Text);
                    float insurance = float.Parse(txbInsurance.Text);
                    float alimony = float.Parse(txbAlimony.Text);
                    float otherFee = float.Parse(txbOtherFees.Text);
                    string studentId = cbStudentId.Text;
                    string paymentDate = dtpPaymentDate.Text;
                    string paymentMethod = txbMethodPayment.Text;
                    int status = 0;
                    if (cbStatus.Text == "Chưa đóng")
                    {
                        status = 0;
                    }
                    else
                    {
                        status = 1;
                    }

                    string message = TuitionController.addTuition(year, expiredDate,
                        tuition, insurance, alimony, otherFee, studentId, paymentDate,
                        paymentMethod, status);
                    MessageBox.Show(message, "Thông báo");
                    Init();

                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc là muốn cập nhật thông tin học phí?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string tuitionId = txbTuitionId.Text;
                    int year = int.Parse(txbYear.Text);
                    string expiredDate = dtpExpirationDate.Text;
                    float tuition = float.Parse(txbTuition.Text);
                    float insurance = float.Parse(txbInsurance.Text);
                    float alimony = float.Parse(txbAlimony.Text);
                    float otherFee = float.Parse(txbOtherFees.Text);
                    string studentId = cbStudentId.Text;
                    string paymentDate = dtpPaymentDate.Text;
                    string paymentMethod = txbMethodPayment.Text;
                    int status = 0;
                    if (cbStatus.Text == "Chưa đóng")
                    {
                        status = 0;
                    }
                    else
                    {
                        status = 1;
                    }

                    string message = TuitionController.updateTuition(tuitionId, year, expiredDate,
                        tuition, insurance, alimony, otherFee, studentId, paymentDate,
                        paymentMethod, status);
                    MessageBox.Show(message, "Thông báo");
                    Init();
                }
            }
        }

        private void cbStudentId_TextChanged(object sender, EventArgs e)
        {
            txbStudentFirstName.Text = listStudentId[cbStudentId.Text][1];
            txbStudentLastName.Text = listStudentId[cbStudentId.Text][2];
            cbClass.Text = listStudentId[cbStudentId.Text][0];
        }

        private void picDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa thông tin học phí?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string tuitionId = txbTuitionId.Text;
                string message = TuitionController.deleteTuition(tuitionId);
                MessageBox.Show(message, "Thông báo");
                Init(); 
            }
        }

        private void dtpExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPaymentDate.Value = dtpExpirationDate.Value;
        }
    }
}
