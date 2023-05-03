
namespace PreschollManagement
{
    partial class fMenuMana
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.gbFoodInfo = new System.Windows.Forms.GroupBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbSession = new System.Windows.Forms.ComboBox();
            this.rtxbNote = new System.Windows.Forms.RichTextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.txbFoodId = new System.Windows.Forms.TextBox();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.lbSession = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbFoodId = new System.Windows.Forms.Label();
            this.gbMenuInfo = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txbMenuId = new System.Windows.Forms.TextBox();
            this.lbMenuCode = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.btnCreateMenu = new System.Windows.Forms.Button();
            this.lbNoti = new System.Windows.Forms.Label();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.gbFunction.SuspendLayout();
            this.gbFoodInfo.SuspendLayout();
            this.gbMenuInfo.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.pnlCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gbFunction);
            this.panel1.Controls.Add(this.gbFoodInfo);
            this.panel1.Controls.Add(this.gbMenuInfo);
            this.panel1.Controls.Add(this.lbTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 519);
            this.panel1.TabIndex = 0;
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.btnSave);
            this.gbFunction.Controls.Add(this.btnCancel);
            this.gbFunction.Controls.Add(this.btnEditFood);
            this.gbFunction.Controls.Add(this.btnDeleteFood);
            this.gbFunction.Controls.Add(this.btnAddFood);
            this.gbFunction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbFunction.Location = new System.Drawing.Point(477, 388);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(1418, 105);
            this.gbFunction.TabIndex = 0;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Chức năng";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(1104, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(872, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditFood.Location = new System.Drawing.Point(646, 31);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(145, 50);
            this.btnEditFood.TabIndex = 9;
            this.btnEditFood.Text = "Sửa món";
            this.btnEditFood.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.Red;
            this.btnDeleteFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFood.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteFood.Location = new System.Drawing.Point(423, 31);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(145, 50);
            this.btnDeleteFood.TabIndex = 8;
            this.btnDeleteFood.Text = "Xóa món";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddFood.Location = new System.Drawing.Point(192, 31);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(145, 50);
            this.btnAddFood.TabIndex = 7;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // gbFoodInfo
            // 
            this.gbFoodInfo.Controls.Add(this.cbDay);
            this.gbFoodInfo.Controls.Add(this.cbSession);
            this.gbFoodInfo.Controls.Add(this.rtxbNote);
            this.gbFoodInfo.Controls.Add(this.lbNote);
            this.gbFoodInfo.Controls.Add(this.txbFoodId);
            this.gbFoodInfo.Controls.Add(this.txbFoodName);
            this.gbFoodInfo.Controls.Add(this.lbFoodName);
            this.gbFoodInfo.Controls.Add(this.lbSession);
            this.gbFoodInfo.Controls.Add(this.lbDay);
            this.gbFoodInfo.Controls.Add(this.lbFoodId);
            this.gbFoodInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbFoodInfo.Location = new System.Drawing.Point(477, 104);
            this.gbFoodInfo.Name = "gbFoodInfo";
            this.gbFoodInfo.Size = new System.Drawing.Size(1418, 270);
            this.gbFoodInfo.TabIndex = 4;
            this.gbFoodInfo.TabStop = false;
            this.gbFoodInfo.Text = "Thông tin món ăn";
            // 
            // cbDay
            // 
            this.cbDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbDay.Location = new System.Drawing.Point(55, 159);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(313, 34);
            this.cbDay.TabIndex = 13;
            // 
            // cbSession
            // 
            this.cbSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSession.FormattingEnabled = true;
            this.cbSession.Items.AddRange(new object[] {
            "Trưa",
            "Xế",
            "Chiều"});
            this.cbSession.Location = new System.Drawing.Point(532, 159);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(313, 34);
            this.cbSession.TabIndex = 12;
            // 
            // rtxbNote
            // 
            this.rtxbNote.Location = new System.Drawing.Point(994, 81);
            this.rtxbNote.Name = "rtxbNote";
            this.rtxbNote.Size = new System.Drawing.Size(380, 108);
            this.rtxbNote.TabIndex = 11;
            this.rtxbNote.Text = "";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(989, 52);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(87, 26);
            this.lbNote.TabIndex = 10;
            this.lbNote.Text = "Ghi chú";
            // 
            // txbFoodId
            // 
            this.txbFoodId.Location = new System.Drawing.Point(55, 81);
            this.txbFoodId.Name = "txbFoodId";
            this.txbFoodId.Size = new System.Drawing.Size(313, 32);
            this.txbFoodId.TabIndex = 8;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(532, 81);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(313, 32);
            this.txbFoodName.TabIndex = 7;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Location = new System.Drawing.Point(527, 52);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(97, 26);
            this.lbFoodName.TabIndex = 6;
            this.lbFoodName.Text = "Tên món";
            // 
            // lbSession
            // 
            this.lbSession.AutoSize = true;
            this.lbSession.Location = new System.Drawing.Point(527, 130);
            this.lbSession.Name = "lbSession";
            this.lbSession.Size = new System.Drawing.Size(56, 26);
            this.lbSession.TabIndex = 4;
            this.lbSession.Text = "Buổi";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(50, 130);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(48, 26);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "Thứ";
            // 
            // lbFoodId
            // 
            this.lbFoodId.AutoSize = true;
            this.lbFoodId.Location = new System.Drawing.Point(50, 52);
            this.lbFoodId.Name = "lbFoodId";
            this.lbFoodId.Size = new System.Drawing.Size(91, 26);
            this.lbFoodId.TabIndex = 0;
            this.lbFoodId.Text = "Mã món";
            // 
            // gbMenuInfo
            // 
            this.gbMenuInfo.Controls.Add(this.btnView);
            this.gbMenuInfo.Controls.Add(this.lbToDate);
            this.gbMenuInfo.Controls.Add(this.lbFromDate);
            this.gbMenuInfo.Controls.Add(this.dtpToDate);
            this.gbMenuInfo.Controls.Add(this.dtpFromDate);
            this.gbMenuInfo.Controls.Add(this.txbMenuId);
            this.gbMenuInfo.Controls.Add(this.lbMenuCode);
            this.gbMenuInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbMenuInfo.Location = new System.Drawing.Point(37, 104);
            this.gbMenuInfo.Name = "gbMenuInfo";
            this.gbMenuInfo.Size = new System.Drawing.Size(410, 389);
            this.gbMenuInfo.TabIndex = 3;
            this.gbMenuInfo.TabStop = false;
            this.gbMenuInfo.Text = "Thông tin thực đơn";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.PaleGreen;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnView.Location = new System.Drawing.Point(206, 303);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(174, 50);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbToDate.Location = new System.Drawing.Point(15, 209);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(171, 26);
            this.lbToDate.TabIndex = 6;
            this.lbToDate.Text = "Đến thứ 6, ngày:";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFromDate.Location = new System.Drawing.Point(15, 128);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(203, 26);
            this.lbFromDate.TabIndex = 5;
            this.lbFromDate.Text = "Tuần từ thứ 2, ngày:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(20, 238);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(360, 32);
            this.dtpToDate.TabIndex = 4;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(20, 157);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(360, 32);
            this.dtpFromDate.TabIndex = 3;
            // 
            // txbMenuId
            // 
            this.txbMenuId.Enabled = false;
            this.txbMenuId.Location = new System.Drawing.Point(20, 81);
            this.txbMenuId.Name = "txbMenuId";
            this.txbMenuId.Size = new System.Drawing.Size(360, 32);
            this.txbMenuId.TabIndex = 2;
            // 
            // lbMenuCode
            // 
            this.lbMenuCode.AutoSize = true;
            this.lbMenuCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMenuCode.Location = new System.Drawing.Point(15, 52);
            this.lbMenuCode.Name = "lbMenuCode";
            this.lbMenuCode.Size = new System.Drawing.Size(131, 26);
            this.lbMenuCode.TabIndex = 1;
            this.lbMenuCode.Text = "Mã thực đơn";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTittle.Location = new System.Drawing.Point(36, 38);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(355, 37);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.pnlCreate);
            this.gbMenu.Controls.Add(this.lvMenu);
            this.gbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbMenu.Location = new System.Drawing.Point(37, 512);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(1858, 452);
            this.gbMenu.TabIndex = 1;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Thực đơn";
            // 
            // pnlCreate
            // 
            this.pnlCreate.Controls.Add(this.btnCreateMenu);
            this.pnlCreate.Controls.Add(this.lbNoti);
            this.pnlCreate.Location = new System.Drawing.Point(416, 121);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(1061, 221);
            this.pnlCreate.TabIndex = 1;
            // 
            // btnCreateMenu
            // 
            this.btnCreateMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateMenu.Location = new System.Drawing.Point(302, 104);
            this.btnCreateMenu.Name = "btnCreateMenu";
            this.btnCreateMenu.Size = new System.Drawing.Size(481, 73);
            this.btnCreateMenu.TabIndex = 12;
            this.btnCreateMenu.Text = "Tạo thực đơn cho tuần này";
            this.btnCreateMenu.UseVisualStyleBackColor = false;
            this.btnCreateMenu.Click += new System.EventHandler(this.btnCreateMenu_Click);
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoti.ForeColor = System.Drawing.Color.DimGray;
            this.lbNoti.Location = new System.Drawing.Point(45, 46);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(996, 32);
            this.lbNoti.TabIndex = 1;
            this.lbNoti.Text = "Thực đơn tuần này hiện chưa có, bạn có muốn tạo mới thực đơn cho tuần này?";
            // 
            // lvMenu
            // 
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(20, 58);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(1819, 372);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            this.lvMenu.Visible = false;
            // 
            // fMenuMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.Chitty_Chitty_Bang_Bang;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 998);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "fMenuMana";
            this.Text = "Quản lý thực đơn của trẻ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMenuMana_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFunction.ResumeLayout(false);
            this.gbFoodInfo.ResumeLayout(false);
            this.gbFoodInfo.PerformLayout();
            this.gbMenuInfo.ResumeLayout(false);
            this.gbMenuInfo.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMenuCode;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.GroupBox gbFoodInfo;
        private System.Windows.Forms.GroupBox gbMenuInfo;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txbMenuId;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.RichTextBox rtxbNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txbFoodId;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label lbSession;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbFoodId;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Button btnCreateMenu;
        private System.Windows.Forms.Label lbNoti;
    }
}