
namespace PreschollManagement
{
    partial class fClassMana
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.lbSchoolYear = new System.Windows.Forms.Label();
            this.txbClassLevel = new System.Windows.Forms.TextBox();
            this.lbClassLevel = new System.Windows.Forms.Label();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.txbClassName = new System.Windows.Forms.TextBox();
            this.lbClassName = new System.Windows.Forms.Label();
            this.txbClassId = new System.Windows.Forms.TextBox();
            this.lbClassId = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.gbClassList = new System.Windows.Forms.GroupBox();
            this.dgvClassList = new System.Windows.Forms.DataGridView();
            this.pnlInfo.SuspendLayout();
            this.gbFunction.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbClassList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.gbFunction);
            this.pnlInfo.Controls.Add(this.gbInfo);
            this.pnlInfo.Controls.Add(this.lbTittle);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1924, 454);
            this.pnlInfo.TabIndex = 0;
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.btnCancel);
            this.gbFunction.Controls.Add(this.btnSave);
            this.gbFunction.Controls.Add(this.btnDelete);
            this.gbFunction.Controls.Add(this.btnEdit);
            this.gbFunction.Controls.Add(this.btnAdd);
            this.gbFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFunction.Location = new System.Drawing.Point(12, 330);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(1900, 100);
            this.gbFunction.TabIndex = 2;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Chức năng";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1226, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1036, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 46);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(842, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(654, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(461, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lbTo);
            this.gbInfo.Controls.Add(this.txbTo);
            this.gbInfo.Controls.Add(this.lbFrom);
            this.gbInfo.Controls.Add(this.txbFrom);
            this.gbInfo.Controls.Add(this.lbSchoolYear);
            this.gbInfo.Controls.Add(this.txbClassLevel);
            this.gbInfo.Controls.Add(this.lbClassLevel);
            this.gbInfo.Controls.Add(this.txbRoom);
            this.gbInfo.Controls.Add(this.lbRoom);
            this.gbInfo.Controls.Add(this.txbClassName);
            this.gbInfo.Controls.Add(this.lbClassName);
            this.gbInfo.Controls.Add(this.txbClassId);
            this.gbInfo.Controls.Add(this.lbClassId);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(12, 77);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(1900, 237);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin lớp học";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(518, 170);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(52, 26);
            this.lbTo.TabIndex = 12;
            this.lbTo.Text = "Đến";
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(576, 170);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(273, 32);
            this.txbTo.TabIndex = 11;
            this.txbTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTo_KeyPress);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(82, 173);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(36, 26);
            this.lbFrom.TabIndex = 10;
            this.lbFrom.Text = "Từ";
            // 
            // txbFrom
            // 
            this.txbFrom.Location = new System.Drawing.Point(124, 173);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.Size = new System.Drawing.Size(289, 32);
            this.txbFrom.TabIndex = 9;
            this.txbFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFrom_KeyPress);
            // 
            // lbSchoolYear
            // 
            this.lbSchoolYear.AutoSize = true;
            this.lbSchoolYear.Location = new System.Drawing.Point(82, 132);
            this.lbSchoolYear.Name = "lbSchoolYear";
            this.lbSchoolYear.Size = new System.Drawing.Size(120, 26);
            this.lbSchoolYear.TabIndex = 8;
            this.lbSchoolYear.Text = "Niên Khóa:";
            // 
            // txbClassLevel
            // 
            this.txbClassLevel.Location = new System.Drawing.Point(1462, 80);
            this.txbClassLevel.Name = "txbClassLevel";
            this.txbClassLevel.Size = new System.Drawing.Size(326, 32);
            this.txbClassLevel.TabIndex = 7;
            // 
            // lbClassLevel
            // 
            this.lbClassLevel.AutoSize = true;
            this.lbClassLevel.Location = new System.Drawing.Point(1457, 51);
            this.lbClassLevel.Name = "lbClassLevel";
            this.lbClassLevel.Size = new System.Drawing.Size(91, 26);
            this.lbClassLevel.TabIndex = 6;
            this.lbClassLevel.Text = "Khối lớp";
            // 
            // txbRoom
            // 
            this.txbRoom.Location = new System.Drawing.Point(1023, 80);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(326, 32);
            this.txbRoom.TabIndex = 5;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(1018, 51);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(75, 26);
            this.lbRoom.TabIndex = 4;
            this.lbRoom.Text = "Phòng";
            // 
            // txbClassName
            // 
            this.txbClassName.Location = new System.Drawing.Point(523, 80);
            this.txbClassName.Name = "txbClassName";
            this.txbClassName.Size = new System.Drawing.Size(326, 32);
            this.txbClassName.TabIndex = 3;
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Location = new System.Drawing.Point(518, 51);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(83, 26);
            this.lbClassName.TabIndex = 2;
            this.lbClassName.Text = "Tên lớp";
            // 
            // txbClassId
            // 
            this.txbClassId.Location = new System.Drawing.Point(87, 80);
            this.txbClassId.Name = "txbClassId";
            this.txbClassId.Size = new System.Drawing.Size(326, 32);
            this.txbClassId.TabIndex = 1;
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Location = new System.Drawing.Point(82, 51);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(77, 26);
            this.lbClassId.TabIndex = 0;
            this.lbClassId.Text = "Mã lớp";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(777, 27);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(328, 37);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // gbClassList
            // 
            this.gbClassList.Controls.Add(this.dgvClassList);
            this.gbClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClassList.Location = new System.Drawing.Point(12, 474);
            this.gbClassList.Name = "gbClassList";
            this.gbClassList.Size = new System.Drawing.Size(1900, 512);
            this.gbClassList.TabIndex = 1;
            this.gbClassList.TabStop = false;
            this.gbClassList.Text = "Danh sách lớp học";
            // 
            // dgvClassList
            // 
            this.dgvClassList.AllowUserToAddRows = false;
            this.dgvClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassList.Location = new System.Drawing.Point(16, 42);
            this.dgvClassList.Name = "dgvClassList";
            this.dgvClassList.ReadOnly = true;
            this.dgvClassList.RowHeadersWidth = 62;
            this.dgvClassList.RowTemplate.Height = 28;
            this.dgvClassList.Size = new System.Drawing.Size(1866, 453);
            this.dgvClassList.TabIndex = 0;
            this.dgvClassList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassList_CellClick);
            // 
            // fClassMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.studentmana_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 998);
            this.Controls.Add(this.gbClassList);
            this.Controls.Add(this.pnlInfo);
            this.DoubleBuffered = true;
            this.Name = "fClassMana";
            this.Text = "Quản lý lớp học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fClassMana_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.gbFunction.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbClassList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.Label lbSchoolYear;
        private System.Windows.Forms.TextBox txbClassLevel;
        private System.Windows.Forms.Label lbClassLevel;
        private System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.TextBox txbClassName;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.TextBox txbClassId;
        private System.Windows.Forms.Label lbClassId;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbClassList;
        private System.Windows.Forms.DataGridView dgvClassList;
    }
}