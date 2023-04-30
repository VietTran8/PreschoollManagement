
namespace PreschollManagement
{
    partial class fResetPassword
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
            this.pnlResetPassword = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txbReNewPassword = new System.Windows.Forms.TextBox();
            this.lbReNewPassword = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResetPassword
            // 
            this.pnlResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnlResetPassword.Controls.Add(this.btnClose);
            this.pnlResetPassword.Controls.Add(this.btnConfirm);
            this.pnlResetPassword.Controls.Add(this.txbReNewPassword);
            this.pnlResetPassword.Controls.Add(this.lbReNewPassword);
            this.pnlResetPassword.Controls.Add(this.txbNewPassword);
            this.pnlResetPassword.Controls.Add(this.lbNewPassword);
            this.pnlResetPassword.Controls.Add(this.txbUsername);
            this.pnlResetPassword.Controls.Add(this.lbUsername);
            this.pnlResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlResetPassword.Location = new System.Drawing.Point(114, 63);
            this.pnlResetPassword.Name = "pnlResetPassword";
            this.pnlResetPassword.Size = new System.Drawing.Size(549, 333);
            this.pnlResetPassword.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsername.Location = new System.Drawing.Point(38, 30);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(142, 26);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tên tài khoản";
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txbUsername.Enabled = false;
            this.txbUsername.Location = new System.Drawing.Point(197, 27);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(315, 32);
            this.txbUsername.TabIndex = 1;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txbNewPassword.Location = new System.Drawing.Point(197, 114);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(315, 32);
            this.txbNewPassword.TabIndex = 3;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNewPassword.Location = new System.Drawing.Point(38, 117);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(143, 26);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "Mật khẩu mới";
            // 
            // txbReNewPassword
            // 
            this.txbReNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txbReNewPassword.Location = new System.Drawing.Point(197, 203);
            this.txbReNewPassword.Name = "txbReNewPassword";
            this.txbReNewPassword.Size = new System.Drawing.Size(315, 32);
            this.txbReNewPassword.TabIndex = 5;
            this.txbReNewPassword.UseSystemPasswordChar = true;
            // 
            // lbReNewPassword
            // 
            this.lbReNewPassword.AutoSize = true;
            this.lbReNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbReNewPassword.Location = new System.Drawing.Point(38, 206);
            this.lbReNewPassword.Name = "lbReNewPassword";
            this.lbReNewPassword.Size = new System.Drawing.Size(92, 26);
            this.lbReNewPassword.TabIndex = 4;
            this.lbReNewPassword.Text = "Nhập lại";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Location = new System.Drawing.Point(313, 269);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(199, 61);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Đặt lại";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(43, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(199, 61);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PreschollManagement.Properties.Resources.formhomepage_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlResetPassword);
            this.Name = "fResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp lại mật khẩu";
            this.Load += new System.EventHandler(this.fResetPassword_Load);
            this.pnlResetPassword.ResumeLayout(false);
            this.pnlResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResetPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txbReNewPassword;
        private System.Windows.Forms.Label lbReNewPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lbUsername;
    }
}