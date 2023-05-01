
namespace PreschollManagement
{
    partial class fHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStudentMana = new System.Windows.Forms.Button();
            this.btnTuitionMana = new System.Windows.Forms.Button();
            this.btnStudyResults = new System.Windows.Forms.Button();
            this.btnMenuMana = new System.Windows.Forms.Button();
            this.menuHomePage = new System.Windows.Forms.MenuStrip();
            this.tsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAccountMana = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClassMana = new System.Windows.Forms.ToolStripMenuItem();
            this.picThumb = new System.Windows.Forms.PictureBox();
            this.picExitIcon = new System.Windows.Forms.PictureBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.menuHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentMana
            // 
            this.btnStudentMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentMana.Image = global::PreschollManagement.Properties.Resources.homepage_background;
            this.btnStudentMana.Location = new System.Drawing.Point(12, 61);
            this.btnStudentMana.Name = "btnStudentMana";
            this.btnStudentMana.Size = new System.Drawing.Size(304, 56);
            this.btnStudentMana.TabIndex = 0;
            this.btnStudentMana.Text = "Quản lý hồ sơ học sinh";
            this.btnStudentMana.UseVisualStyleBackColor = true;
            this.btnStudentMana.Click += new System.EventHandler(this.btnStudentMana_Click);
            // 
            // btnTuitionMana
            // 
            this.btnTuitionMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuitionMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuitionMana.Image = global::PreschollManagement.Properties.Resources.homepage_background;
            this.btnTuitionMana.Location = new System.Drawing.Point(12, 140);
            this.btnTuitionMana.Name = "btnTuitionMana";
            this.btnTuitionMana.Size = new System.Drawing.Size(304, 56);
            this.btnTuitionMana.TabIndex = 1;
            this.btnTuitionMana.Text = "Quản lý học phí";
            this.btnTuitionMana.UseVisualStyleBackColor = true;
            this.btnTuitionMana.Click += new System.EventHandler(this.btnTuitionMana_Click);
            // 
            // btnStudyResults
            // 
            this.btnStudyResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudyResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudyResults.Image = global::PreschollManagement.Properties.Resources.homepage_background;
            this.btnStudyResults.Location = new System.Drawing.Point(12, 218);
            this.btnStudyResults.Name = "btnStudyResults";
            this.btnStudyResults.Size = new System.Drawing.Size(304, 56);
            this.btnStudyResults.TabIndex = 2;
            this.btnStudyResults.Text = "Quản lý kết quả học tập";
            this.btnStudyResults.UseVisualStyleBackColor = true;
            this.btnStudyResults.Click += new System.EventHandler(this.btnStudyResults_Click);
            // 
            // btnMenuMana
            // 
            this.btnMenuMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuMana.Image = global::PreschollManagement.Properties.Resources.homepage_background;
            this.btnMenuMana.Location = new System.Drawing.Point(12, 297);
            this.btnMenuMana.Name = "btnMenuMana";
            this.btnMenuMana.Size = new System.Drawing.Size(304, 56);
            this.btnMenuMana.TabIndex = 3;
            this.btnMenuMana.Text = "Quản lý thực đơn";
            this.btnMenuMana.UseVisualStyleBackColor = true;
            this.btnMenuMana.Click += new System.EventHandler(this.btnMenuMana_Click);
            // 
            // menuHomePage
            // 
            this.menuHomePage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuHomePage.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuHomePage.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuHomePage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdmin});
            this.menuHomePage.Location = new System.Drawing.Point(0, 0);
            this.menuHomePage.Name = "menuHomePage";
            this.menuHomePage.Size = new System.Drawing.Size(1924, 36);
            this.menuHomePage.TabIndex = 4;
            this.menuHomePage.Text = "Admin";
            // 
            // tsAdmin
            // 
            this.tsAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAccountSetting,
            this.tsAccountMana,
            this.tsClassMana});
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(92, 30);
            this.tsAdmin.Text = "Quản trị";
            // 
            // tsAccountSetting
            // 
            this.tsAccountSetting.Name = "tsAccountSetting";
            this.tsAccountSetting.Size = new System.Drawing.Size(274, 34);
            this.tsAccountSetting.Text = "Cài đặt tài khoản";
            this.tsAccountSetting.Click += new System.EventHandler(this.tsAccountSetting_Click);
            // 
            // tsAccountMana
            // 
            this.tsAccountMana.Name = "tsAccountMana";
            this.tsAccountMana.Size = new System.Drawing.Size(274, 34);
            this.tsAccountMana.Text = "Quản lý người dùng";
            this.tsAccountMana.Click += new System.EventHandler(this.tsAccountMana_Click);
            // 
            // tsClassMana
            // 
            this.tsClassMana.Name = "tsClassMana";
            this.tsClassMana.Size = new System.Drawing.Size(274, 34);
            this.tsClassMana.Text = "Quản lý lớp học";
            this.tsClassMana.Click += new System.EventHandler(this.tsClassMana_Click);
            // 
            // picThumb
            // 
            this.picThumb.Dock = System.Windows.Forms.DockStyle.Right;
            this.picThumb.Image = global::PreschollManagement.Properties.Resources.homepage_background;
            this.picThumb.Location = new System.Drawing.Point(338, 36);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(1586, 931);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumb.TabIndex = 5;
            this.picThumb.TabStop = false;
            // 
            // picExitIcon
            // 
            this.picExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.picExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExitIcon.Image = global::PreschollManagement.Properties.Resources.Visualpharm_Must_Have_Log_Out_256;
            this.picExitIcon.Location = new System.Drawing.Point(116, 372);
            this.picExitIcon.Name = "picExitIcon";
            this.picExitIcon.Size = new System.Drawing.Size(79, 78);
            this.picExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExitIcon.TabIndex = 7;
            this.picExitIcon.TabStop = false;
            this.picExitIcon.Click += new System.EventHandler(this.picExitIcon_Click);
            this.picExitIcon.MouseEnter += new System.EventHandler(this.picExitIcon_MouseEnter);
            this.picExitIcon.MouseLeave += new System.EventHandler(this.picExitIcon_MouseLeave);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbExit.Location = new System.Drawing.Point(111, 453);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(71, 26);
            this.lbExit.TabIndex = 8;
            this.lbExit.Text = "Thoát";
            // 
            // fHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.formhomepage_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 967);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.picExitIcon);
            this.Controls.Add(this.picThumb);
            this.Controls.Add(this.btnMenuMana);
            this.Controls.Add(this.btnStudyResults);
            this.Controls.Add(this.btnTuitionMana);
            this.Controls.Add(this.btnStudentMana);
            this.Controls.Add(this.menuHomePage);
            this.MainMenuStrip = this.menuHomePage;
            this.Name = "fHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý trường mầm non";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHomePage_FormClosing_2);
            this.Load += new System.EventHandler(this.fHomePage_Load);
            this.menuHomePage.ResumeLayout(false);
            this.menuHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExitIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentMana;
        private System.Windows.Forms.Button btnTuitionMana;
        private System.Windows.Forms.Button btnStudyResults;
        private System.Windows.Forms.Button btnMenuMana;
        private System.Windows.Forms.MenuStrip menuHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsAccountSetting;
        private System.Windows.Forms.ToolStripMenuItem tsAccountMana;
        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.PictureBox picExitIcon;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.ToolStripMenuItem tsClassMana;
    }
}