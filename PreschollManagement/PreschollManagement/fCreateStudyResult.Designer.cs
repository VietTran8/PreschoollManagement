
namespace PreschollManagement
{
    partial class fCreateStudyResult
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
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTittle.Location = new System.Drawing.Point(170, 65);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(477, 37);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "TẠO MỚI KẾT QUẢ HỌC TẬP";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.BackColor = System.Drawing.Color.Transparent;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClass.Location = new System.Drawing.Point(173, 135);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(99, 25);
            this.lbClass.TabIndex = 1;
            this.lbClass.Text = "Chọn lớp";
            // 
            // cbClass
            // 
            this.cbClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(177, 163);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(461, 34);
            this.cbClass.TabIndex = 2;
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
            this.cbMonth.Location = new System.Drawing.Point(177, 251);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(461, 34);
            this.cbMonth.TabIndex = 4;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.BackColor = System.Drawing.Color.Transparent;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMonth.Location = new System.Drawing.Point(173, 223);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(124, 25);
            this.lbMonth.TabIndex = 3;
            this.lbMonth.Text = "Chọn tháng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Location = new System.Drawing.Point(428, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tạo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(177, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fCreateStudyResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.formhomepage_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbTittle);
            this.DoubleBuffered = true;
            this.Name = "fCreateStudyResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo kết quả học tập mới";
            this.Load += new System.EventHandler(this.fCreateStudyResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}