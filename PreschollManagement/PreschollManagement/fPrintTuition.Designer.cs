﻿
namespace PreschollManagement
{
    partial class fPrintTuition
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
            this.rptvTuition = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvTuition
            // 
            this.rptvTuition.ActiveViewIndex = -1;
            this.rptvTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvTuition.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvTuition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvTuition.Location = new System.Drawing.Point(0, 0);
            this.rptvTuition.Name = "rptvTuition";
            this.rptvTuition.Size = new System.Drawing.Size(800, 450);
            this.rptvTuition.TabIndex = 0;
            // 
            // fPrintTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvTuition);
            this.Name = "fPrintTuition";
            this.Text = "In danh sách học phí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptvTuition;
    }
}