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
    public partial class fHomePage : Form
    {
        public fHomePage()
        {
            InitializeComponent();
        }

        private void picExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsAccountSetting_Click(object sender, EventArgs e)
        {
            fAccountConfig form = new fAccountConfig();
            form.ShowDialog();
        }

        private void fHomePage_FormClosing_2(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnStudentMana_Click(object sender, EventArgs e)
        {
            fProfileManagement form = new fProfileManagement();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void picExitIcon_MouseEnter(object sender, EventArgs e)
        {
            picExitIcon.BackColor = Color.CornflowerBlue;
        }

        private void picExitIcon_MouseLeave(object sender, EventArgs e)
        {
            picExitIcon.BackColor = Color.Transparent;
        }

        private void btnTuitionMana_Click(object sender, EventArgs e)
        {
            fTuitionManagement form = new fTuitionManagement();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnStudyResults_Click(object sender, EventArgs e)
        {
            fStudyResultMana form = new fStudyResultMana();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void tsClassMana_Click(object sender, EventArgs e)
        {
            fClassMana form = new fClassMana();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void tsAccountMana_Click(object sender, EventArgs e)
        {
            fAccountMana form = new fAccountMana();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnMenuMana_Click(object sender, EventArgs e)
        {
            fMenuMana form = new fMenuMana();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
