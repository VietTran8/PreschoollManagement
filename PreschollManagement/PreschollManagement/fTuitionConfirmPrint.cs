using PreschollManagement.Controller;
using PreschollManagement.Model;
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
    public partial class fTuitionConfirmPrint : Form
    {

        public fTuitionConfirmPrint()
        {
            InitializeComponent();
        }

        private void Load_ListClass()
        {
            cbClass.Items.Clear();
            List<Class> list = ClassController.getListClass();
            foreach (Class each in list)
            {
                cbClass.Items.Add(each.Name);
            }
        }

        private void fTuitionConfirmPrint_Load(object sender, EventArgs e)
        {
            Load_ListClass();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string Class = cbClass.Text;
            if (Class == "" || textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                int year = int.Parse(textBox1.Text);
                TuitionController con = new TuitionController();
                DataTable table = TuitionController.printStudentList(Class, year);
                rptTuition report = new rptTuition();
                report.SetDataSource(table);

                fPrintTuition form = new fPrintTuition();
                form.rptvTuition.ReportSource = report;
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
