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
    public partial class fStudyResultMana : Form
    {
        public fStudyResultMana()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbClass.Text == "" || cbMonth.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp và tháng", "Thông báo");
                btnSearch.Enabled = false;
            }
            else {
                btnSearch.Enabled = true;

                string ClassInfo = cbClass.Text;
                int month = int.Parse(cbMonth.Text);

                if (StudyResultController.resultsIsExists(ClassInfo, month))
                {
                    btnRefresh.Enabled = true;
                    btnPrint.Enabled = true;
                    dgvResultList.DataSource = StudyResultController.viewListStudyResult(month, ClassInfo);
                }
                else {
                    if (MessageBox.Show("Chưa có danh sách kết quả này, bạn có muốn tạo mới danh sách?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string message = StudyResultController.addNewList(month, ClassInfo);
                        MessageBox.Show(message, "Thông báo");
                        btnRefresh.Enabled = true;
                        dgvResultList.DataSource = StudyResultController.viewListStudyResult(month, ClassInfo);
                    }
                }
            }
        }

        private void Disable_Function()
        {
            btnUpdate.Enabled = false;
        }

        private void Disable_Control()
        {
            txbResultId.Enabled = false;
            txbStudentName.Enabled = false;
            txbStudentId.Enabled = false;
        }

        private void Disable_Result()
        {
            foreach (Control con in gbResult.Controls) {
                if (con is ComboBox) {
                    con.Enabled = false;
                }
            }
        }

        private void Enable_Result()
        {
            foreach (Control con in gbResult.Controls)
            {
                if (con is ComboBox)
                {
                    con.Enabled = true;
                }
            }
        }

        private void fStudyResultMana_Load(object sender, EventArgs e)
        {
            Init();
            Load_ClassList();
            btnRefresh.Enabled = false;
            btnPrint.Enabled = false ;
            btnSearch.Enabled = false;

        }

        private void Init()
        {
            Disable_Function();
            Disable_Control();
            Disable_Result();
            btnSave.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Enable_Result();
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn cập nhật kết quả của học sinh này?", "Xác nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                string resultId = txbResultId.Text;
                string physical = cbPhysical.Text;
                string awareness = cbAwareness.Text;
                string socialAffection = cbSocialAffection.Text;
                string language = cbLanguage.Text;
                string aesthetic = cbAesthetic.Text;

                string classInfo = cbClass.Text;
                int month = int.Parse(cbMonth.Text);

                string message = StudyResultController.updateStudyResult(
                         resultId,
                         physical,
                         awareness,
                         socialAffection,
                         language,
                         aesthetic
                    );
                MessageBox.Show(message, "Thông báo");
                dgvResultList.DataSource = StudyResultController.viewListStudyResult(month, classInfo);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fCreateStudyResult form = new fCreateStudyResult();
            form.ShowDialog();
        }

        private void Load_ClassList()
        {
            List<string> classList = StudyResultController.getClasses();

            cbClass.Items.Clear();
            foreach (string item in classList)
            {
                cbClass.Items.Add(item);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string classInfo = cbClass.Text;
            int month = int.Parse(cbMonth.Text);

            string message = StudyResultController.updateListStudyResult(month, classInfo);
            MessageBox.Show(message, "Thông báo");
            dgvResultList.DataSource = StudyResultController.viewListStudyResult(month, classInfo);
        }

        private void dgvResultList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Disable_Result();
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                DataGridViewRow selectedRow = dgvResultList.Rows[e.RowIndex];

                txbResultId.Text = selectedRow.Cells["Mã kết quả"].Value.ToString();
                txbStudentId.Text = selectedRow.Cells["Mã học sinh"].Value.ToString();
                txbStudentName.Text = selectedRow.Cells["Họ và tên"].Value.ToString();
                cbAesthetic.Text = selectedRow.Cells["Thẩm mỹ"].Value.ToString();
                cbAwareness.Text = selectedRow.Cells["Nhận thức"].Value.ToString();
                cbLanguage.Text = selectedRow.Cells["Ngôn ngữ"].Value.ToString();
                cbPhysical.Text = selectedRow.Cells["Thể chất"].Value.ToString();
                cbSocialAffection.Text = selectedRow.Cells["Tình cảm xã hội"].Value.ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int month = int.Parse(cbMonth.Text);
            string classInfo = cbClass.Text;
          
            DataTable table = StudyResultController.getListResultToPrint(month, classInfo);
            if (table != null)
            {
                rptResult report = new rptResult();
                report.SetDataSource(table);

                fPrintResult form = new fPrintResult();
                form.rptvPrintResult.ReportSource = report;
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("Danh sách kết quả này chưa có!", "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string option = cbSearchBy.Text;
            string searching = txbSearch.Text;
            if (searching == "")
                MessageBox.Show("Vui lòng nhập thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (option == "Mã HS")
                {
                    string ClassInfo = cbClass.Text;
                    int month = int.Parse(cbMonth.Text);
                    dgvResultList.DataSource = StudyResultController.viewListStudyResultByStudentId(month, ClassInfo, searching);
                }
                else
                {
                    string ClassInfo = cbClass.Text;
                    int month = int.Parse(cbMonth.Text);
                    dgvResultList.DataSource = StudyResultController.viewListStudyResultByStudentName(month, ClassInfo, searching);
                }
            }
        }
    }
}
