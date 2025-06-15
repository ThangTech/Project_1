namespace GUI
{
    partial class frmInBaoHiem
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
            this.crystalReportInBH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportBaoHiem1 = new GUI.CrystalReportBaoHiem();
            this.SuspendLayout();
            // 
            // crystalReportInBH
            // 
            this.crystalReportInBH.ActiveViewIndex = 0;
            this.crystalReportInBH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportInBH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportInBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportInBH.Location = new System.Drawing.Point(0, 0);
            this.crystalReportInBH.Name = "crystalReportInBH";
            this.crystalReportInBH.ReportSource = this.CrystalReportBaoHiem1;
            this.crystalReportInBH.Size = new System.Drawing.Size(1117, 584);
            this.crystalReportInBH.TabIndex = 0;
            // 
            // frmInBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 584);
            this.Controls.Add(this.crystalReportInBH);
            this.Name = "frmInBaoHiem";
            this.Text = "frmInBaoHiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalReportBaoHiem CrystalReportBaoHiem1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportInBH;
    }
}