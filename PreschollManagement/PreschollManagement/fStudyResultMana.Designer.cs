
namespace PreschollManagement
{
    partial class fStudyResultMana
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAwareness = new System.Windows.Forms.ComboBox();
            this.cbSocialAffection = new System.Windows.Forms.ComboBox();
            this.cbAesthetic = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbPhysical = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbAesthetic = new System.Windows.Forms.Label();
            this.lbSocialAffection = new System.Windows.Forms.Label();
            this.lbPhysical = new System.Windows.Forms.Label();
            this.lbAwareness = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txbResultId = new System.Windows.Forms.TextBox();
            this.txbStudentName = new System.Windows.Forms.TextBox();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbResultId = new System.Windows.Forms.Label();
            this.txbStudentId = new System.Windows.Forms.TextBox();
            this.lbStudentId = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lbMonth = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.gpListInfo = new System.Windows.Forms.GroupBox();
            this.dgvResultList = new System.Windows.Forms.DataGridView();
            this.pnlInfo.SuspendLayout();
            this.gbFunction.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.gpListInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.Controls.Add(this.gbFunction);
            this.pnlInfo.Controls.Add(this.gbResult);
            this.pnlInfo.Controls.Add(this.gbInfo);
            this.pnlInfo.Controls.Add(this.btnView);
            this.pnlInfo.Controls.Add(this.lbMonth);
            this.pnlInfo.Controls.Add(this.cbMonth);
            this.pnlInfo.Controls.Add(this.lbClass);
            this.pnlInfo.Controls.Add(this.cbClass);
            this.pnlInfo.Controls.Add(this.lbTittle);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1924, 404);
            this.pnlInfo.TabIndex = 0;
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.btnRefresh);
            this.gbFunction.Controls.Add(this.btnAdd);
            this.gbFunction.Controls.Add(this.btnPrint);
            this.gbFunction.Controls.Add(this.btnUpdate);
            this.gbFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFunction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFunction.Location = new System.Drawing.Point(1538, 68);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(334, 308);
            this.gbFunction.TabIndex = 24;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Chức năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRefresh.Location = new System.Drawing.Point(107, 187);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 39);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(107, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 39);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Tạo mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Location = new System.Drawing.Point(107, 253);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 39);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdate.Location = new System.Drawing.Point(107, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btnSave);
            this.gbResult.Controls.Add(this.btnCancel);
            this.gbResult.Controls.Add(this.cbAwareness);
            this.gbResult.Controls.Add(this.cbSocialAffection);
            this.gbResult.Controls.Add(this.cbAesthetic);
            this.gbResult.Controls.Add(this.cbLanguage);
            this.gbResult.Controls.Add(this.cbPhysical);
            this.gbResult.Controls.Add(this.lbLanguage);
            this.gbResult.Controls.Add(this.lbAesthetic);
            this.gbResult.Controls.Add(this.lbSocialAffection);
            this.gbResult.Controls.Add(this.lbPhysical);
            this.gbResult.Controls.Add(this.lbAwareness);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbResult.Location = new System.Drawing.Point(492, 152);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(1024, 224);
            this.gbResult.TabIndex = 23;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Kết quả rèn luyện";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Location = new System.Drawing.Point(786, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 52);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(673, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 52);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbAwareness
            // 
            this.cbAwareness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAwareness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAwareness.FormattingEnabled = true;
            this.cbAwareness.Items.AddRange(new object[] {
            "Chưa xét",
            "Đạt",
            "Chưa đạt"});
            this.cbAwareness.Location = new System.Drawing.Point(674, 74);
            this.cbAwareness.Name = "cbAwareness";
            this.cbAwareness.Size = new System.Drawing.Size(219, 34);
            this.cbAwareness.TabIndex = 26;
            // 
            // cbSocialAffection
            // 
            this.cbSocialAffection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSocialAffection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSocialAffection.FormattingEnabled = true;
            this.cbSocialAffection.Items.AddRange(new object[] {
            "Chưa xét",
            "Đạt",
            "Chưa đạt"});
            this.cbSocialAffection.Location = new System.Drawing.Point(399, 156);
            this.cbSocialAffection.Name = "cbSocialAffection";
            this.cbSocialAffection.Size = new System.Drawing.Size(219, 34);
            this.cbSocialAffection.TabIndex = 25;
            // 
            // cbAesthetic
            // 
            this.cbAesthetic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAesthetic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAesthetic.FormattingEnabled = true;
            this.cbAesthetic.Items.AddRange(new object[] {
            "Chưa xét",
            "Đạt",
            "Chưa đạt"});
            this.cbAesthetic.Location = new System.Drawing.Point(399, 74);
            this.cbAesthetic.Name = "cbAesthetic";
            this.cbAesthetic.Size = new System.Drawing.Size(219, 34);
            this.cbAesthetic.TabIndex = 24;
            // 
            // cbLanguage
            // 
            this.cbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Chưa xét",
            "Đạt",
            "Chưa đạt"});
            this.cbLanguage.Location = new System.Drawing.Point(118, 156);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(219, 34);
            this.cbLanguage.TabIndex = 23;
            // 
            // cbPhysical
            // 
            this.cbPhysical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPhysical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhysical.FormattingEnabled = true;
            this.cbPhysical.Items.AddRange(new object[] {
            "Chưa xét",
            "Đạt",
            "Chưa đạt"});
            this.cbPhysical.Location = new System.Drawing.Point(118, 74);
            this.cbPhysical.Name = "cbPhysical";
            this.cbPhysical.Size = new System.Drawing.Size(219, 34);
            this.cbPhysical.TabIndex = 22;
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLanguage.Location = new System.Drawing.Point(113, 124);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(115, 29);
            this.lbLanguage.TabIndex = 16;
            this.lbLanguage.Text = "Ngôn ngữ";
            // 
            // lbAesthetic
            // 
            this.lbAesthetic.AutoSize = true;
            this.lbAesthetic.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAesthetic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAesthetic.Location = new System.Drawing.Point(394, 42);
            this.lbAesthetic.Name = "lbAesthetic";
            this.lbAesthetic.Size = new System.Drawing.Size(109, 29);
            this.lbAesthetic.TabIndex = 20;
            this.lbAesthetic.Text = "Thẩm mỹ";
            // 
            // lbSocialAffection
            // 
            this.lbSocialAffection.AutoSize = true;
            this.lbSocialAffection.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSocialAffection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSocialAffection.Location = new System.Drawing.Point(394, 124);
            this.lbSocialAffection.Name = "lbSocialAffection";
            this.lbSocialAffection.Size = new System.Drawing.Size(176, 29);
            this.lbSocialAffection.TabIndex = 18;
            this.lbSocialAffection.Text = "Tình cảm xã hội";
            // 
            // lbPhysical
            // 
            this.lbPhysical.AutoSize = true;
            this.lbPhysical.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhysical.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPhysical.Location = new System.Drawing.Point(113, 42);
            this.lbPhysical.Name = "lbPhysical";
            this.lbPhysical.Size = new System.Drawing.Size(101, 29);
            this.lbPhysical.TabIndex = 9;
            this.lbPhysical.Text = "Thể chất";
            // 
            // lbAwareness
            // 
            this.lbAwareness.AutoSize = true;
            this.lbAwareness.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAwareness.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAwareness.Location = new System.Drawing.Point(669, 42);
            this.lbAwareness.Name = "lbAwareness";
            this.lbAwareness.Size = new System.Drawing.Size(121, 29);
            this.lbAwareness.TabIndex = 14;
            this.lbAwareness.Text = "Nhận thức";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txbResultId);
            this.gbInfo.Controls.Add(this.txbStudentName);
            this.gbInfo.Controls.Add(this.lbStudentName);
            this.gbInfo.Controls.Add(this.lbResultId);
            this.gbInfo.Controls.Add(this.txbStudentId);
            this.gbInfo.Controls.Add(this.lbStudentId);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbInfo.Location = new System.Drawing.Point(50, 62);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(418, 314);
            this.gbInfo.TabIndex = 22;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin";
            // 
            // txbResultId
            // 
            this.txbResultId.Location = new System.Drawing.Point(33, 66);
            this.txbResultId.Name = "txbResultId";
            this.txbResultId.Size = new System.Drawing.Size(353, 32);
            this.txbResultId.TabIndex = 1;
            // 
            // txbStudentName
            // 
            this.txbStudentName.Location = new System.Drawing.Point(33, 262);
            this.txbStudentName.Name = "txbStudentName";
            this.txbStudentName.Size = new System.Drawing.Size(353, 32);
            this.txbStudentName.TabIndex = 8;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStudentName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStudentName.Location = new System.Drawing.Point(28, 230);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(144, 29);
            this.lbStudentName.TabIndex = 7;
            this.lbStudentName.Text = "Tên học sinh";
            // 
            // lbResultId
            // 
            this.lbResultId.AutoSize = true;
            this.lbResultId.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbResultId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbResultId.Location = new System.Drawing.Point(28, 34);
            this.lbResultId.Name = "lbResultId";
            this.lbResultId.Size = new System.Drawing.Size(127, 29);
            this.lbResultId.TabIndex = 0;
            this.lbResultId.Text = "Mã kết quả";
            // 
            // txbStudentId
            // 
            this.txbStudentId.Location = new System.Drawing.Point(33, 164);
            this.txbStudentId.Name = "txbStudentId";
            this.txbStudentId.Size = new System.Drawing.Size(353, 32);
            this.txbStudentId.TabIndex = 3;
            // 
            // lbStudentId
            // 
            this.lbStudentId.AutoSize = true;
            this.lbStudentId.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStudentId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStudentId.Location = new System.Drawing.Point(28, 132);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(139, 29);
            this.lbStudentId.TabIndex = 2;
            this.lbStudentId.Text = "Mã học sinh";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(1185, 82);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(140, 53);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMonth.Location = new System.Drawing.Point(886, 88);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(85, 29);
            this.lbMonth.TabIndex = 12;
            this.lbMonth.Text = "Tháng:";
            // 
            // cbMonth
            // 
            this.cbMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(977, 87);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 34);
            this.cbMonth.TabIndex = 11;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClass.Location = new System.Drawing.Point(636, 88);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(58, 29);
            this.lbClass.TabIndex = 6;
            this.lbClass.Text = "Lớp:";
            // 
            // cbClass
            // 
            this.cbClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.DropDownWidth = 300;
            this.cbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(700, 87);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 34);
            this.cbClass.TabIndex = 5;
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTittle.Location = new System.Drawing.Point(710, 18);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(485, 37);
            this.lbTittle.TabIndex = 4;
            this.lbTittle.Text = "QUẢN LÝ KẾT QUẢ HỌC TẬP";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(610, 423);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(500, 32);
            this.txbSearch.TabIndex = 1;
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownWidth = 130;
            this.cbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Mã HS",
            "Tên HS"});
            this.cbSearchBy.Location = new System.Drawing.Point(1161, 421);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(103, 34);
            this.cbSearchBy.TabIndex = 2;
            this.cbSearchBy.Text = "Mã HS";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Location = new System.Drawing.Point(1283, 415);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.Controls.Add(this.gpListInfo);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlList.Location = new System.Drawing.Point(0, 473);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1924, 525);
            this.pnlList.TabIndex = 4;
            // 
            // gpListInfo
            // 
            this.gpListInfo.Controls.Add(this.dgvResultList);
            this.gpListInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gpListInfo.Location = new System.Drawing.Point(50, 15);
            this.gpListInfo.Name = "gpListInfo";
            this.gpListInfo.Size = new System.Drawing.Size(1822, 463);
            this.gpListInfo.TabIndex = 0;
            this.gpListInfo.TabStop = false;
            this.gpListInfo.Text = "Danh sách học sinh";
            // 
            // dgvResultList
            // 
            this.dgvResultList.AllowUserToAddRows = false;
            this.dgvResultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultList.Location = new System.Drawing.Point(6, 31);
            this.dgvResultList.Name = "dgvResultList";
            this.dgvResultList.ReadOnly = true;
            this.dgvResultList.RowHeadersVisible = false;
            this.dgvResultList.RowHeadersWidth = 62;
            this.dgvResultList.RowTemplate.Height = 28;
            this.dgvResultList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultList.Size = new System.Drawing.Size(1810, 426);
            this.dgvResultList.TabIndex = 0;
            this.dgvResultList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultList_CellClick);
            // 
            // fStudyResultMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.Chitty_Chitty_Bang_Bang;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 998);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.pnlInfo);
            this.DoubleBuffered = true;
            this.Name = "fStudyResultMana";
            this.Text = "Quản lý kết quả học tập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fStudyResultMana_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.gbFunction.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.gpListInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lbResultId;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox txbStudentId;
        private System.Windows.Forms.Label lbStudentId;
        private System.Windows.Forms.TextBox txbResultId;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lbPhysical;
        private System.Windows.Forms.TextBox txbStudentName;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lbAesthetic;
        private System.Windows.Forms.Label lbSocialAffection;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbAwareness;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.ComboBox cbAwareness;
        private System.Windows.Forms.ComboBox cbSocialAffection;
        private System.Windows.Forms.ComboBox cbAesthetic;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbPhysical;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.GroupBox gpListInfo;
        private System.Windows.Forms.DataGridView dgvResultList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
    }
}