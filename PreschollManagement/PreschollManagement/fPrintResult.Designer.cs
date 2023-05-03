
namespace PreschollManagement
{
    partial class fPrintResult
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
            this.rptvPrintResult = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvPrintResult
            // 
            this.rptvPrintResult.ActiveViewIndex = -1;
            this.rptvPrintResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvPrintResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvPrintResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvPrintResult.Location = new System.Drawing.Point(0, 0);
            this.rptvPrintResult.Name = "rptvPrintResult";
            this.rptvPrintResult.Size = new System.Drawing.Size(800, 450);
            this.rptvPrintResult.TabIndex = 0;
            // 
            // fPrintResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvPrintResult);
            this.Name = "fPrintResult";
            this.Text = "In kết quả học tập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptvPrintResult;
    }
}