namespace GUI
{
    partial class frmInDSNS
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
            this.crystalReportInDSNS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new GUI.CrystalReport1();
            this.SuspendLayout();
            // 
            // crystalReportInDSNS
            // 
            this.crystalReportInDSNS.ActiveViewIndex = 0;
            this.crystalReportInDSNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportInDSNS.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportInDSNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportInDSNS.Location = new System.Drawing.Point(0, 0);
            this.crystalReportInDSNS.Name = "crystalReportInDSNS";
            this.crystalReportInDSNS.ReportSource = this.CrystalReport11;
            this.crystalReportInDSNS.Size = new System.Drawing.Size(1133, 575);
            this.crystalReportInDSNS.TabIndex = 0;
            // 
            // frmInDSNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 575);
            this.Controls.Add(this.crystalReportInDSNS);
            this.Name = "frmInDSNS";
            this.Text = "frmInDSNS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalReport1 CrystalReport11;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportInDSNS;
    }
}