
namespace PreschollManagement
{
    partial class fAccountConfig
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
            this.txbOldPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowNewPass = new System.Windows.Forms.Button();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowRePass = new System.Windows.Forms.Button();
            this.txbReNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbOldPassword
            // 
            this.txbOldPassword.Location = new System.Drawing.Point(20, 48);
            this.txbOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbOldPassword.Name = "txbOldPassword";
            this.txbOldPassword.Size = new System.Drawing.Size(466, 32);
            this.txbOldPassword.TabIndex = 0;
            this.txbOldPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnShowPassword);
            this.groupBox1.Controls.Add(this.txbOldPassword);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(267, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(614, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu cũ";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowPassword.Location = new System.Drawing.Point(497, 44);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(108, 42);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.Text = "Xem";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnShowNewPass);
            this.groupBox2.Controls.Add(this.txbNewPassword);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(267, 183);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(614, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mật khẩu mới";
            // 
            // btnShowNewPass
            // 
            this.btnShowNewPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowNewPass.Location = new System.Drawing.Point(497, 45);
            this.btnShowNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowNewPass.Name = "btnShowNewPass";
            this.btnShowNewPass.Size = new System.Drawing.Size(108, 42);
            this.btnShowNewPass.TabIndex = 6;
            this.btnShowNewPass.Text = "Xem";
            this.btnShowNewPass.UseVisualStyleBackColor = true;
            this.btnShowNewPass.Click += new System.EventHandler(this.btnShowNewPass_Click);
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(20, 48);
            this.txbNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(466, 32);
            this.txbNewPassword.TabIndex = 0;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnShowRePass);
            this.groupBox3.Controls.Add(this.txbReNewPassword);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(267, 330);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(614, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập lại mật khẩu mới";
            // 
            // btnShowRePass
            // 
            this.btnShowRePass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowRePass.Location = new System.Drawing.Point(497, 44);
            this.btnShowRePass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowRePass.Name = "btnShowRePass";
            this.btnShowRePass.Size = new System.Drawing.Size(108, 42);
            this.btnShowRePass.TabIndex = 7;
            this.btnShowRePass.Text = "Xem";
            this.btnShowRePass.UseVisualStyleBackColor = true;
            this.btnShowRePass.Click += new System.EventHandler(this.btnShowRePass_Click);
            // 
            // txbReNewPassword
            // 
            this.txbReNewPassword.Location = new System.Drawing.Point(20, 48);
            this.txbReNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbReNewPassword.Name = "txbReNewPassword";
            this.txbReNewPassword.Size = new System.Drawing.Size(466, 32);
            this.txbReNewPassword.TabIndex = 0;
            this.txbReNewPassword.UseSystemPasswordChar = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(650, 491);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(231, 52);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Thay đổi mật khẩu";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 491);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fAccountConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.studentmana_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 585);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fAccountConfig";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbOldPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbReNewPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnShowNewPass;
        private System.Windows.Forms.Button btnShowRePass;
    }
}