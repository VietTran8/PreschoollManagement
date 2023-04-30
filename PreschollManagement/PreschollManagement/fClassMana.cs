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
    public partial class fClassMana : Form
    {
        private static bool isUpdate = false;
        public fClassMana()
        {
            InitializeComponent();
        }

        private void Disable_Control()
        {
            foreach (Control con in gbInfo.Controls)
            {
                if (con is TextBox)
                {
                    con.Enabled = false;
                }
            }
        }
        private void Enable_Control()
        {
            foreach (Control con in gbInfo.Controls)
            {
                if (con is TextBox)
                {
                    con.Enabled = true;
                }
            }
            txbClassId.Enabled = false;
        }

        private void fClassMana_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            //Disable some input controls
            Disable_Control();

            //Load class list from database
            Load_ClassList();

            //Disable some buttons
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            //Custom column header text
            dgvClassList.Columns[0].HeaderText = "Mã lớp";
            dgvClassList.Columns[1].HeaderText = "Tên lớp";
            dgvClassList.Columns[2].HeaderText = "Phòng";
            dgvClassList.Columns[3].HeaderText = "Khối lớp";
            dgvClassList.Columns[4].HeaderText = "Niên khóa";

            //Resize data grid view with full width
            dgvClassList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Unvisible row header
            dgvClassList.RowHeadersVisible = false;

            //Select full row
            dgvClassList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Clear textbox
            Clear_TextBox();

            btnAdd.Enabled = true;

        }

        private void Clear_TextBox()
        {
            //Clear textbox:
            foreach (Control con in gbInfo.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = "";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Enable_Control();
            Clear_TextBox();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            isUpdate = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Control();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            isUpdate = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Load_ClassList()
        {
            dgvClassList.DataSource = ClassController.getListClass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbClassLevel.Text == "" || txbClassName.Text == "" || txbFrom.Text == "" || txbTo.Text == "" ||
                txbRoom.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (int.Parse(txbFrom.Text) >= int.Parse(txbTo.Text))
                MessageBox.Show("Năm bắt đầu phải bé hơn năm kết thúc!", "Cảnh báo", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            else
            {
                if (!isUpdate)
                {


                    if (MessageBox.Show("Bạn có chắc là muốn thêm lớp học?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string className = txbClassName.Text,
                            room = txbRoom.Text,
                            classLevel = txbClassLevel.Text,
                            schoolYearFrom = txbFrom.Text,
                            schoolYearTo = txbTo.Text;
                        string message = ClassController.addClass(className, room, classLevel, schoolYearFrom, schoolYearTo);
                        MessageBox.Show(message, "Thông báo");
                        Init();
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc là muốn cập nhật lớp học?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string className = txbClassName.Text,
                                                room = txbRoom.Text,
                                                classLevel = txbClassLevel.Text,
                                                schoolYearFrom = txbFrom.Text,
                                                schoolYearTo = txbTo.Text,
                                                classId = txbClassId.Text;
                        string message = ClassController.updateClass(classId, className, room, classLevel, schoolYearFrom, schoolYearTo);
                        MessageBox.Show(message, "Thông báo");
                        Init();
                    }
                }
            }
        }

        //Display class info to textbox control
        private void dgvClassList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Disable_Control();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                DataGridViewRow selectedRow = dgvClassList.Rows[e.RowIndex];

                txbClassId.Text = selectedRow.Cells[0].Value.ToString(); 
                txbClassName.Text = selectedRow.Cells[1].Value.ToString();
                txbClassLevel.Text = selectedRow.Cells[3].Value.ToString();
                txbRoom.Text = selectedRow.Cells[2].Value.ToString();

                string[] schoolYear = selectedRow.Cells[4].Value.ToString().Split('-');

                txbFrom.Text = schoolYear[0].Trim();
                txbTo.Text = schoolYear[1].Trim();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa lớp "+txbClassName.Text+"?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string classId = txbClassId.Text;
                string message = ClassController.deleteClass(classId);
                MessageBox.Show(message, "Thông báo");
                Init();
            }
        }

        private void txbFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
