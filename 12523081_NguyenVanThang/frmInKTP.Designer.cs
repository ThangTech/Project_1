namespace GUI
{
    partial class frmInKTP
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
            this.crystalReportInKTP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportThuongPhat1 = new GUI.CrystalReportThuongPhat();
            this.SuspendLayout();
            // 
            // crystalReportInKTP
            // 
            this.crystalReportInKTP.ActiveViewIndex = 0;
            this.crystalReportInKTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportInKTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportInKTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportInKTP.Location = new System.Drawing.Point(0, 0);
            this.crystalReportInKTP.Name = "crystalReportInKTP";
            this.crystalReportInKTP.ReportSource = this.CrystalReportThuongPhat1;
            this.crystalReportInKTP.Size = new System.Drawing.Size(1120, 581);
            this.crystalReportInKTP.TabIndex = 0;
            // 
            // frmInKTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 581);
            this.Controls.Add(this.crystalReportInKTP);
            this.Name = "frmInKTP";
            this.Text = "frmInKTP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalReportThuongPhat CrystalReportThuongPhat1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportInKTP;
    }
}