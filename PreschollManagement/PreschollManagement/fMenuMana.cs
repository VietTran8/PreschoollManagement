using PreschollManagement.Controller;
using PreschollManagement.Model;
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

        private static bool isUpdate = false;
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
            clearInput();
            btnDeleteFood.Enabled = false;

            btnAddFood.Enabled = true;


            if (MenuController.isExists(dtpFromDate.Text))
            {
                lvMenu.Visible = true;
                pnlCreate.Visible = false;
                txbMenuId.Text = MenuController.getId(dtpFromDate.Text);
                Load_ListView();

            }
            else
            {
                lvMenu.Visible = false;
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
                Load_ListView();

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
            btnAddFood.Enabled = false;
            Enable_Control();
            Enable_Button();
            btnDeleteFood.Enabled = false;
            btnEditFood.Enabled = false;
            clearInput();

            isUpdate = false;
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
                    Load_ListView();
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
            lvMenu.Items.Clear();
            lvMenu.Columns.Clear();
            ListViewGroup thu2 = new ListViewGroup("Thứ 2");
            ListViewGroup thu3 = new ListViewGroup("Thứ 3");
            ListViewGroup thu4 = new ListViewGroup("Thứ 4");
            ListViewGroup thu5 = new ListViewGroup("Thứ 5");
            ListViewGroup thu6 = new ListViewGroup("Thứ 6");

            lvMenu.Groups.AddRange(new ListViewGroup[] { thu2, thu3, thu4, thu5, thu6 });

            ListViewGroup[] listGroup = { null, null, thu2, thu3, thu4, thu5, thu6 };

            lvMenu.Columns.Add("Mã món");
            lvMenu.Columns.Add("Tên món");
            lvMenu.Columns.Add("Buổi");
            lvMenu.Columns.Add("Ghi chú");

            List<Food> list = MenuController.GetFoods(txbMenuId.Text);
            foreach (Food food in list)
            {
                lvMenu.Items.Add(new ListViewItem(new[] { food.Id, food.Name, food.Session, food.Note }, listGroup[food.Day]));
            }

            AutoResizeColumn(4);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string foodName = txbFoodName.Text;
            
            string session = cbSession.Text;
            string note = rtxbNote.Text;
            string menuId = txbMenuId.Text;
            if (foodName == "" || cbDay.Text == "" || session == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int day = int.Parse(cbDay.Text);
                if (!isUpdate)
                {
                    string message = MenuController.addFood(foodName, day, session, note, menuId);
                    MessageBox.Show(message, "Thông báo");
                    Init();
                }
                else
                {
                    string foodId = txbFoodId.Text;
                    string message = MenuController.updateFood(foodName, day, session, note, foodId);
                    MessageBox.Show(message, "Thông báo");
                    Init();
                }
            }
        }

        private void AutoResizeColumn(int numberOfColumns)
        {
            lvMenu.BeginUpdate();
            int colWidth = lvMenu.Width / numberOfColumns;
            foreach (ColumnHeader header in lvMenu.Columns)
            {
                header.Width = colWidth;
            }
            lvMenu.EndUpdate();
        }

        private void changeColorDisable(Control con)
        {
            con.BackColor = Color.LightGray;
            con.ForeColor = Color.DarkGray;
        }

        private void btnView_EnabledChanged(object sender, EventArgs e)
        {
            if (btnView.Enabled)
            {
                btnView.BackColor = Color.LightGreen;
                btnView.ForeColor = Color.Black;
            }
            else 
            {
                changeColorDisable(btnView);
            }
        }

        private void btnAddFood_EnabledChanged(object sender, EventArgs e)
        {
            if (btnAddFood.Enabled)
            {
                btnAddFood.BackColor = Color.LightGreen;
                btnAddFood.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(btnAddFood);
            }
        }

        private void btnDeleteFood_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDeleteFood.Enabled)
            {
                btnDeleteFood.BackColor = Color.Red;
                btnDeleteFood.ForeColor = Color.White;
            }
            else
            {
                changeColorDisable(btnDeleteFood);
            }
        }

        private void btnEditFood_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEditFood.Enabled)
            {
                btnEditFood.BackColor = Color.DodgerBlue;
                btnEditFood.ForeColor = Color.White;
            }
            else
            {
                changeColorDisable(btnEditFood);
            }
        }

        private void btnCancel_EnabledChanged(object sender, EventArgs e)
        {
            if (btnCancel.Enabled)
            {
                btnCancel.BackColor = Color.Red;
                btnCancel.ForeColor = Color.White;
            }
            else
            {
                changeColorDisable(btnCancel);
            }
        }

        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                btnSave.BackColor = Color.LightGreen;
                btnSave.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(btnSave);
            }
        }

        private void clearInput()
        {
            txbFoodId.Text = "";
            txbFoodName.Text = "";
            rtxbNote.Text = "";
            cbDay.Text = string.Empty;
            cbSession.Text = string.Empty;
        }

        private void txbFoodId_EnabledChanged(object sender, EventArgs e)
        {
            if (txbFoodId.Enabled)
            {
                txbFoodId.BackColor = Color.White;
                txbFoodId.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(txbFoodId);
            }
        }

        private void txbFoodName_EnabledChanged(object sender, EventArgs e)
        {
            if (txbFoodName.Enabled)
            {
                txbFoodName.BackColor = Color.White;
                txbFoodName.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(txbFoodName);
            }
        }

        private void rtxbNote_EnabledChanged(object sender, EventArgs e)
        {
            if (rtxbNote.Enabled)
            {
                rtxbNote.BackColor = Color.White;
                rtxbNote.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(rtxbNote);
            }
        }

        private void cbDay_EnabledChanged(object sender, EventArgs e)
        {
            if (cbDay.Enabled)
            {
                cbDay.BackColor = Color.White;
                cbDay.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(cbDay);
            }
        }

        private void cbSession_EnabledChanged(object sender, EventArgs e)
        {
            if (cbSession.Enabled)
            {
                cbSession.BackColor = Color.White;
                cbSession.ForeColor = Color.Black;
            }
            else
            {
                changeColorDisable(cbSession);
            }
        }
        
        private void lvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMenu.SelectedItems.Count > 0)
            {
                btnEditFood.Enabled = true;
                btnDeleteFood.Enabled = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                string foodId = lvMenu.SelectedItems[0].SubItems[0].Text;
                string foodName = lvMenu.SelectedItems[0].SubItems[1].Text;
                string session = lvMenu.SelectedItems[0].SubItems[2].Text;
                string note = lvMenu.SelectedItems[0].SubItems[3].Text;
                string[] day = lvMenu.SelectedItems[0].Group.Header.Split(' ');

                txbFoodId.Text = foodId;
                txbFoodName.Text = foodName;
                cbSession.Text = session;
                rtxbNote.Text = note;
                cbDay.Text = day[1];
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            btnEditFood.Enabled = false;
            Enable_Control();
            Enable_Button();
            btnDeleteFood.Enabled = false;
            btnAddFood.Enabled = false;
            isUpdate = true;
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string foodId = txbFoodId.Text;

            string message = MenuController.deleteFood(foodId);

            MessageBox.Show(message, "Thông báo");
            Init();
        }
    }
}
