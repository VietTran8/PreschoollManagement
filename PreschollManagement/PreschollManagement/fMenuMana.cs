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
    public partial class fMenuMana : Form
    {
        public fMenuMana()
        {
            InitializeComponent();
            FormatDtp.FormatDateTimePicker(dtpFromDate, "dd-MM-yyyy");
            FormatDtp.FormatDateTimePicker(dtpToDate, "dd-MM-yyyy");
            dtpFromDate.Value = GetDaysOfWeek(dtpFromDate.Value, 2, 6)[0];
            dtpToDate.Value = dtpFromDate.Value.AddDays(4);
            Load_ListView();
        }

        private void Init()
        {
            Disable_Control();
            Disable_Button();
            btnEditFood.Enabled = false;
            btnDeleteFood.Enabled = false;


            if (MenuController.isExists(dtpFromDate.Text))
            {
                lvMenu.Visible = true;
                pnlCreate.Visible = false;
                txbMenuId.Text = MenuController.getId(dtpFromDate.Text);

            }
            else
            {
                lvMenu.Visible = false ;
                pnlCreate.Visible = true;
                txbMenuId.Text = "";

            }
        }


        private List<DateTime> GetDaysOfWeek(DateTime currentDay, int fromDay, int toDay) {
            DateTime startOfWeek = currentDay.AddDays(
                (int)System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
                (int)currentDay.DayOfWeek);
            List<DateTime> daysOfWeek = new List<DateTime>();
            for (int i = fromDay - 1; i < toDay; i++)
            {
                daysOfWeek.Add(startOfWeek.AddDays(i));
            }

            return daysOfWeek;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            List<DateTime> listDaysOfWeek = GetDaysOfWeek(dtpFromDate.Value, 2, 6);
            dtpFromDate.Value = listDaysOfWeek[0];
            dtpToDate.Value = dtpFromDate.Value.AddDays(4);
            if (MenuController.isExists(dtpFromDate.Text))
            {
                pnlCreate.Visible = false;
                lvMenu.Visible = true;
                txbMenuId.Text = MenuController.getId(dtpFromDate.Text);

            }
            else {
                pnlCreate.Visible = true;
                lvMenu.Visible = false;
                txbMenuId.Text = "";

            }
        }

        private void Disable_Control()
        {
            txbFoodId.Enabled = false;
            txbFoodName.Enabled = false;
            rtxbNote.Enabled = false;
            cbDay.Enabled = false;
            cbSession.Enabled = false;
        }
        private void Enable_Control()
        {
            txbFoodName.Enabled = true;
            rtxbNote.Enabled = true;
            cbDay.Enabled = true;
            cbSession.Enabled = true;
        }

        private void Enable_Button()
        {
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void Disable_Button()
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void fMenuMana_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Enable_Control();
            Enable_Button();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCreateMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn tạo thực đơn cho tuần này?", "Xác nhận", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string startDate = dtpFromDate.Text;
                string endDate = dtpToDate.Text;

                string message = MenuController.create(startDate, endDate);
                MessageBox.Show(message, "Thông báo");
                if (message == "Tạo mới thực đơn thành công!" || message == "Thực đơn này đã tồn tại!")
                {
                    pnlCreate.Visible = false;
                    lvMenu.Visible = true;
                    txbMenuId.Text = MenuController.getId(dtpFromDate.Text);
                }
                else
                {
                    pnlCreate.Visible = true;
                    lvMenu.Visible = false;
                    txbMenuId.Text = "";
                }

            }
        }

        private void Load_ListView()
        {
            ListViewGroup thu2 = new ListViewGroup("Thứ 2");
            ListViewGroup thu3 = new ListViewGroup("Thứ 3");
            ListViewGroup thu4 = new ListViewGroup("Thứ 4");
            ListViewGroup thu5 = new ListViewGroup("Thứ 5");
            ListViewGroup thu6 = new ListViewGroup("Thứ 6");

            lvMenu.Groups.AddRange(new ListViewGroup[] { thu2, thu3, thu4, thu5, thu6});

            lvMenu.Columns.Add("Tên món");
            lvMenu.Columns.Add("Buổi");
            lvMenu.Columns.Add("Ghi chú");

            lvMenu.Items.Add(new ListViewItem(new[] { "Ntga", "Xees", "Gasd" }, thu2));

        }
    }
}
