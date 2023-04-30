
namespace PreschollManagement
{
    partial class fStudentPrint
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
            this.rptvStudentList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvStudentList
            // 
            this.rptvStudentList.ActiveViewIndex = -1;
            this.rptvStudentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvStudentList.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvStudentList.Location = new System.Drawing.Point(0, 0);
            this.rptvStudentList.Name = "rptvStudentList";
            this.rptvStudentList.Size = new System.Drawing.Size(1053, 558);
            this.rptvStudentList.TabIndex = 0;
            // 
            // fStudentPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 558);
            this.Controls.Add(this.rptvStudentList);
            this.Name = "fStudentPrint";
            this.Text = "In danh sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptvStudentList;
    }
}