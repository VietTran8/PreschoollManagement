using PreschollManagement.Controller;
using PreschollManagement.Report;
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
    public partial class fProfileManagement : Form
    {
        private static bool isUpdate = false;
        public fProfileManagement()
        {
            InitializeComponent();
        }

        private void Load_ListStudent()
        {
            DataTable table = StudentController.getListStudent();
            if (table != null)
            {
                dgvStudentList.DataSource = table;
            } else
            {
                MessageBox.Show("Cố lỗi xảy ra, vui lòng thử lại sau",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Disabled_Function()
        {
            picDeleteStudent.Enabled = false;
            picEditStudent.Enabled = false;
        }

        private void Disabled_InputControl() {
            foreach (Control con in pnlInffo.Controls) {
                if (con is TextBox || con is ComboBox || con is DateTimePicker) {
                    con.Enabled = false;
                }
            }
        }

        private void Enabled_InputControl()
        {
            foreach (Control con in pnlInffo.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Enabled = true;
                }
            }

            txbStudentId.Enabled = false;
        }

        private void Enabled_Function()
        {
            picDeleteStudent.Enabled = true;
            picEditStudent.Enabled = true;
        }

        private void picAddStudent_MouseEnter(object sender, EventArgs e)
        {
            picAddStudent.BackColor = Color.CornflowerBlue;
        }

        private void picAddStudent_MouseLeave(object sender, EventArgs e)
        {
            picAddStudent.BackColor = Color.Transparent;
            isUpdate = false;
        }

        private void Load_Class()
        {
            List<String> classList = StudentController.getListClass();
            if (classList != null)
            {
                cbClass.Items.AddRange(classList.ToArray());
            }
        }

        private void Clear_Input()
        {
            foreach (Control con in pnlInffo.Controls)
            {
                if (con is TextBox || con is ComboBox)
                {
                    con.Text = "";
                }
            }

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                bool isChecked = rdoById.Checked;
                int choose = 0;
                if (isChecked)
                    choose = 0;
                else
                    choose = 1;

                string lastName = txbSearch.Text;
                string id = txbSearch.Text;


                if (StudentController.getListStudentBy(id, lastName, choose).Rows.Count > 0)
                {
                    dgvStudentList.DataSource = StudentController.getListStudentBy(id, lastName, choose);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    Init();
                }

            }
        }

        private void picDeleteStudent_EnabledChanged(object sender, EventArgs e)
        {
            if (picDeleteStudent.Enabled)
            {
                picDeleteStudent.BackColor = Color.Transparent;
            }
            else {
                picDeleteStudent.BackColor = Color.Maroon;
            }
        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            Disabled_Function();
        }

        private void picEditStudent_EnabledChanged(object sender, EventArgs e)
        {
            if (picEditStudent.Enabled)
            {
                picEditStudent.BackColor = Color.Transparent;
            }
            else {
                picEditStudent.BackColor = Color.Maroon;
            }
        }

        private void picEditStudent_MouseEnter(object sender, EventArgs e)
        {
            if (picEditStudent.Enabled) {
                picEditStudent.BackColor = Color.CornflowerBlue;
            }
        }

        private void picEditStudent_MouseLeave(object sender, EventArgs e)
        {
            if (picEditStudent.Enabled) {
                picEditStudent.BackColor = Color.Transparent;
            }
        }

        private void picPrint_MouseEnter(object sender, EventArgs e)
        {
            picPrint.BackColor = Color.CornflowerBlue;
        }

        private void picPrint_MouseLeave(object sender, EventArgs e)
        {
            picPrint.BackColor = Color.Transparent;
        }

        private void fProfileManagement_Load(object sender, EventArgs e)
        {
            Init();
            Load_Class();

        }

        private void Init()
        {
            Disabled_InputControl();
            rdoById.Checked = true;

            Load_ListStudent();

            //Format date time picker
            FormatDtp.FormatDateTimePicker(dtpBirthDay, "dd-MM-yyyy");

            Clear_Input();
            Disabled_Function();

            btnSave.Text = "Lưu";
            btnSave.Enabled = false;

            picAddStudent.Enabled = true;
        }

        private void picDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hồ sơ của học sinh " + txbStudentId.Text + "?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string studentId = txbStudentId.Text;
                string message = StudentController.deleteStudent(studentId);
                MessageBox.Show(message, "Thông báo");
                Init();
            }
        }

        private void picEditStudent_Click(object sender, EventArgs e)
        {
            Enabled_InputControl();
            picAddStudent.Enabled = false;
            picDeleteStudent.Enabled = false;
            btnSave.Enabled = true;
            isUpdate = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void picAddStudent_Click(object sender, EventArgs e)
        {
            Enabled_InputControl();
            Disabled_Function();
            Clear_Input();
            btnSave.Text = "Thêm";
            btnSave.Enabled = true;
        }

        private void txbParentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                picAddStudent.Enabled = true;
                Disabled_InputControl();
                btnSave.Enabled = false;
                picDeleteStudent.Enabled = true;
                picEditStudent.Enabled = true;
                DataGridViewRow selectedRow = dgvStudentList.Rows[e.RowIndex];

                txbStudentId.Text = selectedRow.Cells["Mã học sinh"].Value.ToString();
                string Class = selectedRow.Cells["Tên lớp"].Value.ToString() + " - " +
                               selectedRow.Cells["Mã lớp"].Value.ToString();
                cbClass.Text = Class;
                txbStudentFirstName.Text = selectedRow.Cells["Họ học sinh"].Value.ToString();
                txbStudentLastName.Text = selectedRow.Cells["Tên học sinh"].Value.ToString();
                cbGender.Text = selectedRow.Cells["Giới tính"].Value.ToString();
                txbEthnicity.Text = selectedRow.Cells["Dân tộc"].Value.ToString();
                txbReligion.Text = selectedRow.Cells["Tôn giáo"].Value.ToString();
                string[] date = selectedRow.Cells["Ngày sinh"].Value.ToString().Split('-');
                DateTime newDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                dtpBirthDay.Value = newDate;
                txbAddress.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                txbHomeTown.Text = selectedRow.Cells["Quê quán"].Value.ToString();
                txbParentName.Text = selectedRow.Cells["Tên phụ huynh"].Value.ToString();
                txbParentPhone.Text = selectedRow.Cells["Số điện thoại"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!isUpdate)
            {
                if (MessageBox.Show("Bạn có chắc là muốn thêm hồ sơ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool flag = false;
                    foreach (Control con in pnlInffo.Controls)
                    {
                        if (!(con is Label) && (con.Name != "txbStudentId"))
                            if (con.Text == "")
                            {
                                flag = true;
                                break;
                            }
                    }
                    if (flag)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int gender;
                        if (cbGender.Text == "Nam")
                            gender = 0;
                        else
                            gender = 1;
                        string classId = cbClass.Text.Split(' ')[3].Trim(),
                                firstName = txbStudentFirstName.Text,
                                lastName = txbStudentLastName.Text,
                                ethnicity = txbEthnicity.Text,
                                religion = txbReligion.Text,
                                birth = dtpBirthDay.Text,
                                address = txbAddress.Text,
                                homeTown = txbHomeTown.Text,
                                parentName = txbParentName.Text,
                                parentPhone = txbParentPhone.Text;

                        string message = StudentController.addStudent(classId, firstName, lastName,
                            gender, birth, ethnicity, religion, address, homeTown, parentName, parentPhone);
                        MessageBox.Show(message, "Thông báo");
                        Init();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc là muốn sửa hồ sơ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool flag = false;
                    foreach (Control con in pnlInffo.Controls)
                    {
                        if (!(con is Label))
                            if (con.Text == "")
                            {
                                flag = true;
                                break;
                            }
                    }
                    if (flag)
                    {
                        MessageBox.Show("Không dược để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int gender;
                        if (cbGender.Text == "Nam")
                            gender = 0;
                        else
                            gender = 1;
                        string studentId = txbStudentId.Text,
                                classId = cbClass.Text.Split(' ')[3].Trim(),
                                firstName = txbStudentFirstName.Text,
                                lastName = txbStudentLastName.Text,
                                ethnicity = txbEthnicity.Text,
                                religion = txbReligion.Text,
                                birth = dtpBirthDay.Text,
                                address = txbAddress.Text,
                                homeTown = txbHomeTown.Text,
                                parentName = txbParentName.Text,
                                parentPhone = txbParentPhone.Text;

                        string message = StudentController.updateStudent(studentId, classId, firstName, lastName,
                            gender, birth, ethnicity, religion, address, homeTown, parentName, parentPhone);
                        MessageBox.Show(message, "Thông báo");
                        Init();
                    }
                }
            }
        }

        private void picAddStudent_EnabledChanged(object sender, EventArgs e)
        {
            if (picAddStudent.Enabled)
            {
                picAddStudent.BackColor = Color.Transparent;
            }
            else
            {
                picAddStudent.BackColor = Color.Maroon;
            }
        }

        private void picPrint_Click(object sender, EventArgs e)
        {
            DataTable table = StudentController.printStudentList();
            rptStudentList report = new rptStudentList();
            report.SetDataSource(table);

            fStudentPrint form = new fStudentPrint();
            form.rptvStudentList.ReportSource = report;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
