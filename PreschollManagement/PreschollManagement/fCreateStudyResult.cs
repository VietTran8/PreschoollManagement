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
    public partial class fCreateStudyResult : Form
    {
        public fCreateStudyResult()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbClass.Text == "" || cbMonth.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp và tháng", "Thông báo");
            }
            else
            {
                string classInfo = cbClass.Text;
                int month = int.Parse(cbMonth.Text);

                if (StudyResultController.resultsIsExists(classInfo, month))
                    MessageBox.Show("Danh sách kết quả này đã tồn tại!");
                else
                {
                    string message = StudyResultController.addNewList(month, classInfo);
                    MessageBox.Show(message, "Thông báo");
                }
            }
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

        private void fCreateStudyResult_Load(object sender, EventArgs e)
        {
            Load_ClassList();
        }
    }
}
