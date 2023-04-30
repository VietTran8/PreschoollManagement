
namespace PreschollManagement
{
    partial class fTuitionManagement
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
            this.picPrint = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbInfoTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbListStudent = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rdoByName = new System.Windows.Forms.RadioButton();
            this.rdoById = new System.Windows.Forms.RadioButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.gpFunctions = new System.Windows.Forms.GroupBox();
            this.picAddStudent = new System.Windows.Forms.PictureBox();
            this.picEditStudent = new System.Windows.Forms.PictureBox();
            this.picDeleteStudent = new System.Windows.Forms.PictureBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txbStudentLastName = new System.Windows.Forms.TextBox();
            this.txbStudentFirstName = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbStudentId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStudentId = new System.Windows.Forms.ComboBox();
            this.gbFees = new System.Windows.Forms.GroupBox();
            this.txbOtherFees = new System.Windows.Forms.TextBox();
            this.lbOtherFees = new System.Windows.Forms.Label();
            this.txbAlimony = new System.Windows.Forms.TextBox();
            this.lbAlimony = new System.Windows.Forms.Label();
            this.txbInsurance = new System.Windows.Forms.TextBox();
            this.lbInsurance = new System.Windows.Forms.Label();
            this.txbTuition = new System.Windows.Forms.TextBox();
            this.lbTuition = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txbMethodPayment = new System.Windows.Forms.TextBox();
            this.lbMethodPayment = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lbPaymentDate = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbTuitionId = new System.Windows.Forms.Label();
            this.txbTuitionId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbListStudent.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gpFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPrint
            // 
            this.picPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrint.Image = global::PreschollManagement.Properties.Resources.icons8_print_94;
            this.picPrint.Location = new System.Drawing.Point(967, 45);
            this.picPrint.Name = "picPrint";
            this.picPrint.Size = new System.Drawing.Size(80, 81);
            this.picPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrint.TabIndex = 3;
            this.picPrint.TabStop = false;
            this.picPrint.Click += new System.EventHandler(this.picPrint_Click);
            this.picPrint.MouseEnter += new System.EventHandler(this.picPrint_MouseEnter);
            this.picPrint.MouseLeave += new System.EventHandler(this.picPrint_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(236, 935);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 45);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(338, 935);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lbInfoTitle
            // 
            this.lbInfoTitle.AutoSize = true;
            this.lbInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInfoTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbInfoTitle.Location = new System.Drawing.Point(110, 9);
            this.lbInfoTitle.Name = "lbInfoTitle";
            this.lbInfoTitle.Size = new System.Drawing.Size(206, 22);
            this.lbInfoTitle.TabIndex = 27;
            this.lbInfoTitle.Text = "THÔNG TIN HỌC PHÍ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1443, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbListStudent
            // 
            this.gbListStudent.BackColor = System.Drawing.Color.Transparent;
            this.gbListStudent.Controls.Add(this.dataGridView1);
            this.gbListStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListStudent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbListStudent.Location = new System.Drawing.Point(463, 444);
            this.gbListStudent.Name = "gbListStudent";
            this.gbListStudent.Size = new System.Drawing.Size(1455, 542);
            this.gbListStudent.TabIndex = 12;
            this.gbListStudent.TabStop = false;
            this.gbListStudent.Text = "DANH SÁCH HỌC SINH";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSearch.Location = new System.Drawing.Point(381, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Leave += new System.EventHandler(this.btnSearch_Leave);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.rdoByName);
            this.gbSearch.Controls.Add(this.rdoById);
            this.gbSearch.Controls.Add(this.txbSearch);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbSearch.Location = new System.Drawing.Point(980, 128);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(478, 119);
            this.gbSearch.TabIndex = 11;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Tìm kiếm";
            // 
            // rdoByName
            // 
            this.rdoByName.AutoSize = true;
            this.rdoByName.BackColor = System.Drawing.Color.Transparent;
            this.rdoByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoByName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoByName.Location = new System.Drawing.Point(240, 78);
            this.rdoByName.Name = "rdoByName";
            this.rdoByName.Size = new System.Drawing.Size(135, 26);
            this.rdoByName.TabIndex = 6;
            this.rdoByName.TabStop = true;
            this.rdoByName.Text = "Tìm theo tên";
            this.rdoByName.UseVisualStyleBackColor = false;
            // 
            // rdoById
            // 
            this.rdoById.AutoSize = true;
            this.rdoById.BackColor = System.Drawing.Color.Transparent;
            this.rdoById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoById.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoById.Location = new System.Drawing.Point(25, 78);
            this.rdoById.Name = "rdoById";
            this.rdoById.Size = new System.Drawing.Size(197, 26);
            this.rdoById.TabIndex = 5;
            this.rdoById.TabStop = true;
            this.rdoById.Text = "Tìm theo mã học phí";
            this.rdoById.UseVisualStyleBackColor = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(25, 35);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(350, 28);
            this.txbSearch.TabIndex = 4;
            // 
            // gpFunctions
            // 
            this.gpFunctions.BackColor = System.Drawing.Color.Transparent;
            this.gpFunctions.Controls.Add(this.picAddStudent);
            this.gpFunctions.Controls.Add(this.picPrint);
            this.gpFunctions.Controls.Add(this.picEditStudent);
            this.gpFunctions.Controls.Add(this.picDeleteStudent);
            this.gpFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFunctions.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gpFunctions.Location = new System.Drawing.Point(463, 273);
            this.gpFunctions.Name = "gpFunctions";
            this.gpFunctions.Size = new System.Drawing.Size(1455, 154);
            this.gpFunctions.TabIndex = 13;
            this.gpFunctions.TabStop = false;
            this.gpFunctions.Text = "CHỨC NĂNG";
            // 
            // picAddStudent
            // 
            this.picAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.picAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddStudent.Image = global::PreschollManagement.Properties.Resources.add_person;
            this.picAddStudent.Location = new System.Drawing.Point(517, 45);
            this.picAddStudent.Name = "picAddStudent";
            this.picAddStudent.Size = new System.Drawing.Size(80, 81);
            this.picAddStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddStudent.TabIndex = 14;
            this.picAddStudent.TabStop = false;
            this.picAddStudent.Click += new System.EventHandler(this.picAddStudent_Click);
            this.picAddStudent.MouseEnter += new System.EventHandler(this.picAddStudent_MouseEnter);
            this.picAddStudent.MouseLeave += new System.EventHandler(this.picAddStudent_MouseLeave);
            // 
            // picEditStudent
            // 
            this.picEditStudent.BackColor = System.Drawing.Color.Maroon;
            this.picEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditStudent.Enabled = false;
            this.picEditStudent.Image = global::PreschollManagement.Properties.Resources.edit_icon;
            this.picEditStudent.Location = new System.Drawing.Point(812, 45);
            this.picEditStudent.Name = "picEditStudent";
            this.picEditStudent.Size = new System.Drawing.Size(80, 81);
            this.picEditStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditStudent.TabIndex = 2;
            this.picEditStudent.TabStop = false;
            this.picEditStudent.EnabledChanged += new System.EventHandler(this.picEditStudent_EnabledChanged);
            this.picEditStudent.Click += new System.EventHandler(this.picEditStudent_Click);
            this.picEditStudent.MouseEnter += new System.EventHandler(this.picEditStudent_MouseEnter);
            this.picEditStudent.MouseLeave += new System.EventHandler(this.picEditStudent_MouseLeave);
            // 
            // picDeleteStudent
            // 
            this.picDeleteStudent.BackColor = System.Drawing.Color.Maroon;
            this.picDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDeleteStudent.Enabled = false;
            this.picDeleteStudent.Image = global::PreschollManagement.Properties.Resources.remove_icon;
            this.picDeleteStudent.Location = new System.Drawing.Point(659, 45);
            this.picDeleteStudent.Name = "picDeleteStudent";
            this.picDeleteStudent.Size = new System.Drawing.Size(80, 81);
            this.picDeleteStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeleteStudent.TabIndex = 1;
            this.picDeleteStudent.TabStop = false;
            this.picDeleteStudent.EnabledChanged += new System.EventHandler(this.picDeleteStudent_EnabledChanged);
            this.picDeleteStudent.MouseEnter += new System.EventHandler(this.picDeleteStudent_MouseEnter);
            this.picDeleteStudent.MouseLeave += new System.EventHandler(this.picDeleteStudent_MouseLeave);
            // 
            // cbClass
            // 
            this.cbClass.Enabled = false;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(235, 182);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(177, 34);
            this.cbClass.TabIndex = 8;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitle.Location = new System.Drawing.Point(915, 53);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(626, 46);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "QUẢN LÝ THÔNG TIN HỌC PHÍ";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbFirstName.Location = new System.Drawing.Point(232, 245);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(114, 22);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "Tên học sinh";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbLastName.Location = new System.Drawing.Point(24, 245);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(105, 22);
            this.lbLastName.TabIndex = 6;
            this.lbLastName.Text = "Họ học sinh";
            // 
            // txbStudentLastName
            // 
            this.txbStudentLastName.Enabled = false;
            this.txbStudentLastName.Location = new System.Drawing.Point(236, 273);
            this.txbStudentLastName.Name = "txbStudentLastName";
            this.txbStudentLastName.Size = new System.Drawing.Size(177, 32);
            this.txbStudentLastName.TabIndex = 5;
            // 
            // txbStudentFirstName
            // 
            this.txbStudentFirstName.Enabled = false;
            this.txbStudentFirstName.Location = new System.Drawing.Point(24, 273);
            this.txbStudentFirstName.Name = "txbStudentFirstName";
            this.txbStudentFirstName.Size = new System.Drawing.Size(177, 32);
            this.txbStudentFirstName.TabIndex = 4;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.BackColor = System.Drawing.Color.Transparent;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbClass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbClass.Location = new System.Drawing.Point(231, 153);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(40, 22);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Lớp";
            // 
            // lbStudentId
            // 
            this.lbStudentId.AutoSize = true;
            this.lbStudentId.BackColor = System.Drawing.Color.Transparent;
            this.lbStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStudentId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbStudentId.Location = new System.Drawing.Point(23, 154);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(106, 22);
            this.lbStudentId.TabIndex = 1;
            this.lbStudentId.Text = "Mã học sinh";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cbStudentId);
            this.panel1.Controls.Add(this.gbFees);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.txbMethodPayment);
            this.panel1.Controls.Add(this.lbMethodPayment);
            this.panel1.Controls.Add(this.dtpPaymentDate);
            this.panel1.Controls.Add(this.lbPaymentDate);
            this.panel1.Controls.Add(this.dtpExpirationDate);
            this.panel1.Controls.Add(this.lbExpirationDate);
            this.panel1.Controls.Add(this.txbYear);
            this.panel1.Controls.Add(this.lbYear);
            this.panel1.Controls.Add(this.lbTuitionId);
            this.panel1.Controls.Add(this.txbTuitionId);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbInfoTitle);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.lbFirstName);
            this.panel1.Controls.Add(this.lbLastName);
            this.panel1.Controls.Add(this.txbStudentLastName);
            this.panel1.Controls.Add(this.txbStudentFirstName);
            this.panel1.Controls.Add(this.lbClass);
            this.panel1.Controls.Add(this.lbStudentId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 998);
            this.panel1.TabIndex = 9;
            // 
            // cbStudentId
            // 
            this.cbStudentId.FormattingEnabled = true;
            this.cbStudentId.Location = new System.Drawing.Point(28, 182);
            this.cbStudentId.Name = "cbStudentId";
            this.cbStudentId.Size = new System.Drawing.Size(172, 34);
            this.cbStudentId.TabIndex = 14;
            // 
            // gbFees
            // 
            this.gbFees.Controls.Add(this.txbOtherFees);
            this.gbFees.Controls.Add(this.lbOtherFees);
            this.gbFees.Controls.Add(this.txbAlimony);
            this.gbFees.Controls.Add(this.lbAlimony);
            this.gbFees.Controls.Add(this.txbInsurance);
            this.gbFees.Controls.Add(this.lbInsurance);
            this.gbFees.Controls.Add(this.txbTuition);
            this.gbFees.Controls.Add(this.lbTuition);
            this.gbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFees.Location = new System.Drawing.Point(12, 683);
            this.gbFees.Name = "gbFees";
            this.gbFees.Size = new System.Drawing.Size(407, 234);
            this.gbFees.TabIndex = 44;
            this.gbFees.TabStop = false;
            this.gbFees.Text = "Các khoản phí";
            // 
            // txbOtherFees
            // 
            this.txbOtherFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOtherFees.Location = new System.Drawing.Point(219, 149);
            this.txbOtherFees.Name = "txbOtherFees";
            this.txbOtherFees.Size = new System.Drawing.Size(177, 32);
            this.txbOtherFees.TabIndex = 42;
            this.txbOtherFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbOtherFees_KeyPress);
            // 
            // lbOtherFees
            // 
            this.lbOtherFees.AutoSize = true;
            this.lbOtherFees.BackColor = System.Drawing.Color.Transparent;
            this.lbOtherFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbOtherFees.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbOtherFees.Location = new System.Drawing.Point(219, 121);
            this.lbOtherFees.Name = "lbOtherFees";
            this.lbOtherFees.Size = new System.Drawing.Size(79, 22);
            this.lbOtherFees.TabIndex = 41;
            this.lbOtherFees.Text = "Phí khác";
            // 
            // txbAlimony
            // 
            this.txbAlimony.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAlimony.Location = new System.Drawing.Point(11, 149);
            this.txbAlimony.Name = "txbAlimony";
            this.txbAlimony.Size = new System.Drawing.Size(177, 32);
            this.txbAlimony.TabIndex = 40;
            this.txbAlimony.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAlimony_KeyPress);
            // 
            // lbAlimony
            // 
            this.lbAlimony.AutoSize = true;
            this.lbAlimony.BackColor = System.Drawing.Color.Transparent;
            this.lbAlimony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAlimony.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbAlimony.Location = new System.Drawing.Point(11, 121);
            this.lbAlimony.Name = "lbAlimony";
            this.lbAlimony.Size = new System.Drawing.Size(98, 22);
            this.lbAlimony.TabIndex = 39;
            this.lbAlimony.Text = "Cấp dưỡng";
            // 
            // txbInsurance
            // 
            this.txbInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInsurance.Location = new System.Drawing.Point(219, 65);
            this.txbInsurance.Name = "txbInsurance";
            this.txbInsurance.Size = new System.Drawing.Size(177, 32);
            this.txbInsurance.TabIndex = 38;
            this.txbInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInsurance_KeyPress);
            // 
            // lbInsurance
            // 
            this.lbInsurance.AutoSize = true;
            this.lbInsurance.BackColor = System.Drawing.Color.Transparent;
            this.lbInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInsurance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbInsurance.Location = new System.Drawing.Point(219, 37);
            this.lbInsurance.Name = "lbInsurance";
            this.lbInsurance.Size = new System.Drawing.Size(85, 22);
            this.lbInsurance.TabIndex = 37;
            this.lbInsurance.Text = "Bảo hiểm";
            // 
            // txbTuition
            // 
            this.txbTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTuition.Location = new System.Drawing.Point(11, 65);
            this.txbTuition.Name = "txbTuition";
            this.txbTuition.Size = new System.Drawing.Size(177, 32);
            this.txbTuition.TabIndex = 36;
            this.txbTuition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTuition_KeyPress);
            // 
            // lbTuition
            // 
            this.lbTuition.AutoSize = true;
            this.lbTuition.BackColor = System.Drawing.Color.Transparent;
            this.lbTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTuition.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTuition.Location = new System.Drawing.Point(11, 37);
            this.lbTuition.Name = "lbTuition";
            this.lbTuition.Size = new System.Drawing.Size(71, 22);
            this.lbTuition.TabIndex = 35;
            this.lbTuition.Text = "Học phí";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Chưa đóng",
            "Đã đóng"});
            this.cbStatus.Location = new System.Drawing.Point(236, 361);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(177, 34);
            this.cbStatus.TabIndex = 43;
            this.cbStatus.Text = "Chưa đóng";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbStatus.Location = new System.Drawing.Point(232, 333);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(92, 22);
            this.lbStatus.TabIndex = 42;
            this.lbStatus.Text = "Trạng thái";
            // 
            // txbMethodPayment
            // 
            this.txbMethodPayment.Location = new System.Drawing.Point(24, 629);
            this.txbMethodPayment.Name = "txbMethodPayment";
            this.txbMethodPayment.Size = new System.Drawing.Size(389, 32);
            this.txbMethodPayment.TabIndex = 41;
            // 
            // lbMethodPayment
            // 
            this.lbMethodPayment.AutoSize = true;
            this.lbMethodPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbMethodPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMethodPayment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbMethodPayment.Location = new System.Drawing.Point(24, 601);
            this.lbMethodPayment.Name = "lbMethodPayment";
            this.lbMethodPayment.Size = new System.Drawing.Size(201, 22);
            this.lbMethodPayment.TabIndex = 40;
            this.lbMethodPayment.Text = "Phương thức thanh toán";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(23, 540);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(389, 32);
            this.dtpPaymentDate.TabIndex = 39;
            // 
            // lbPaymentDate
            // 
            this.lbPaymentDate.AutoSize = true;
            this.lbPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.lbPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPaymentDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbPaymentDate.Location = new System.Drawing.Point(23, 512);
            this.lbPaymentDate.Name = "lbPaymentDate";
            this.lbPaymentDate.Size = new System.Drawing.Size(208, 22);
            this.lbPaymentDate.TabIndex = 38;
            this.lbPaymentDate.Text = "Ngày đóng (mm/dd/yyyy)";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(24, 453);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(389, 32);
            this.dtpExpirationDate.TabIndex = 37;
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbExpirationDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbExpirationDate.Location = new System.Drawing.Point(24, 425);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(199, 22);
            this.lbExpirationDate.TabIndex = 35;
            this.lbExpirationDate.Text = "Hạn đóng (mm/dd/yyyy)";
            // 
            // txbYear
            // 
            this.txbYear.Location = new System.Drawing.Point(24, 361);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(177, 32);
            this.txbYear.TabIndex = 34;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.BackColor = System.Drawing.Color.Transparent;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbYear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbYear.Location = new System.Drawing.Point(24, 333);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(81, 22);
            this.lbYear.TabIndex = 33;
            this.lbYear.Text = "Năm học";
            // 
            // lbTuitionId
            // 
            this.lbTuitionId.AutoSize = true;
            this.lbTuitionId.BackColor = System.Drawing.Color.Transparent;
            this.lbTuitionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTuitionId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTuitionId.Location = new System.Drawing.Point(24, 69);
            this.lbTuitionId.Name = "lbTuitionId";
            this.lbTuitionId.Size = new System.Drawing.Size(97, 22);
            this.lbTuitionId.TabIndex = 31;
            this.lbTuitionId.Text = "Mã học phí";
            // 
            // txbTuitionId
            // 
            this.txbTuitionId.Enabled = false;
            this.txbTuitionId.Location = new System.Drawing.Point(24, 97);
            this.txbTuitionId.Name = "txbTuitionId";
            this.txbTuitionId.Size = new System.Drawing.Size(389, 32);
            this.txbTuitionId.TabIndex = 30;
            // 
            // fTuitionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.Chitty_Chitty_Bang_Bang;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 998);
            this.Controls.Add(this.gbListStudent);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gpFunctions);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "fTuitionManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTuitionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbListStudent.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gpFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFees.ResumeLayout(false);
            this.gbFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbInfoTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbListStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rdoByName;
        private System.Windows.Forms.RadioButton rdoById;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.GroupBox gpFunctions;
        private System.Windows.Forms.PictureBox picEditStudent;
        private System.Windows.Forms.PictureBox picDeleteStudent;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txbStudentLastName;
        private System.Windows.Forms.TextBox txbStudentFirstName;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbStudentId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbTuitionId;
        private System.Windows.Forms.TextBox txbTuitionId;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lbPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txbMethodPayment;
        private System.Windows.Forms.Label lbMethodPayment;
        private System.Windows.Forms.GroupBox gbFees;
        private System.Windows.Forms.TextBox txbOtherFees;
        private System.Windows.Forms.Label lbOtherFees;
        private System.Windows.Forms.TextBox txbAlimony;
        private System.Windows.Forms.Label lbAlimony;
        private System.Windows.Forms.TextBox txbInsurance;
        private System.Windows.Forms.Label lbInsurance;
        private System.Windows.Forms.TextBox txbTuition;
        private System.Windows.Forms.Label lbTuition;
        private System.Windows.Forms.PictureBox picAddStudent;
        private System.Windows.Forms.ComboBox cbStudentId;
    }
}