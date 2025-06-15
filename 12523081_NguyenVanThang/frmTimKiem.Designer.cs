namespace GUI
{
    partial class frmTimKiem
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
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblNDCT = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.cboLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.Location = new System.Drawing.Point(0, 0);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(1155, 83);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "TÌM KIẾM";
            this.lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNDCT
            // 
            this.lblNDCT.AutoSize = true;
            this.lblNDCT.Location = new System.Drawing.Point(233, 213);
            this.lblNDCT.Name = "lblNDCT";
            this.lblNDCT.Size = new System.Drawing.Size(135, 20);
            this.lblNDCT.TabIndex = 1;
            this.lblNDCT.Text = "Nội dung cần tìm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(374, 210);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(290, 26);
            this.txtTimKiem.TabIndex = 2;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 285);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(1155, 437);
            this.dgvTimKiem.TabIndex = 4;
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Image = global::GUI.Properties.Resources.result_19;
            this.btnXemKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemKQ.Location = new System.Drawing.Point(682, 206);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(175, 34);
            this.btnXemKQ.TabIndex = 3;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // cboLoaiTimKiem
            // 
            this.cboLoaiTimKiem.FormattingEnabled = true;
            this.cboLoaiTimKiem.Location = new System.Drawing.Point(374, 143);
            this.cboLoaiTimKiem.Name = "cboLoaiTimKiem";
            this.cboLoaiTimKiem.Size = new System.Drawing.Size(290, 28);
            this.cboLoaiTimKiem.TabIndex = 5;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(175, 146);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(186, 20);
            this.lblDanhMuc.TabIndex = 1;
            this.lblDanhMuc.Text = "Chọn danh mục cần tìm";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(954, 206);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 34);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1155, 722);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboLoaiTimKiem);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.lblNDCT);
            this.Controls.Add(this.lblTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblNDCT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.ComboBox cboLoaiTimKiem;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Button btnThoat;
    }
}