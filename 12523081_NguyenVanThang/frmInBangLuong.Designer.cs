namespace _12523081_NguyenVanThang
{
    partial class frmInBangLuong
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
            this.crystalReportBangLuong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportBangLuong1 = new _12523081_NguyenVanThang.CrystalReportBangLuong();
            this.SuspendLayout();
            // 
            // crystalReportBangLuong
            // 
            this.crystalReportBangLuong.ActiveViewIndex = 0;
            this.crystalReportBangLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportBangLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportBangLuong.Location = new System.Drawing.Point(0, 0);
            this.crystalReportBangLuong.Name = "crystalReportBangLuong";
            this.crystalReportBangLuong.ReportSource = this.CrystalReportBangLuong1;
            this.crystalReportBangLuong.Size = new System.Drawing.Size(1128, 568);
            this.crystalReportBangLuong.TabIndex = 0;
            // 
            // frmInBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 568);
            this.Controls.Add(this.crystalReportBangLuong);
            this.Name = "frmInBangLuong";
            this.Text = "frmInBangLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalReportBangLuong CrystalReportBangLuong1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportBangLuong;
    }
}