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
        }

        private void Init()
        {
            Disable_Control();
            Disable_Button();
            btnEditFood.Enabled = false;
            btnDeleteFood.Enabled = false;
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
            string result = "";
            int index = 2;
            foreach (DateTime date in listDaysOfWeek)
            {
                result += "Thứ " + index + ": " + date.ToString("dd-MM-yyyy") + ",\n";
                index++;
            }
            dtpFromDate.Value = listDaysOfWeek[0];
            dtpToDate.Value = dtpFromDate.Value.AddDays(4);
            MessageBox.Show(dtpFromDate.Value.ToString("yyyy-MM-dd"));
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
            MessageBox.Show("Bạn có chắc là muốn tạo thực đơn cho tuần này?", "Xác nhận", MessageBoxButtons.OKCancel);
        }
    }
}
