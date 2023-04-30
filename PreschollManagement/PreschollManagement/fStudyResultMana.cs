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
                MessageBox.Show("Ok");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fCreateStudyResult form = new fCreateStudyResult();
            form.ShowDialog();
        }
    }
}
