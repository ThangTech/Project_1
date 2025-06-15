namespace _12523081_NguyenVanThang.ThongKe
{
    partial class FrmThongKeBangLuong
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
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.lblSoNgayLam = new System.Windows.Forms.Label();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblMaLuong = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblBLNV = new System.Windows.Forms.Label();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongkeBD = new System.Windows.Forms.Button();
            this.pnChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(169, 97);
            this.txtSoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(209, 22);
            this.txtSoNgay.TabIndex = 30;
            this.txtSoNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoNgay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSoNgay_MouseClick);
            // 
            // lblSoNgayLam
            // 
            this.lblSoNgayLam.AutoSize = true;
            this.lblSoNgayLam.Location = new System.Drawing.Point(52, 101);
            this.lblSoNgayLam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNgayLam.Name = "lblSoNgayLam";
            this.lblSoNgayLam.Size = new System.Drawing.Size(64, 17);
            this.lblSoNgayLam.TabIndex = 27;
            this.lblSoNgayLam.Text = "Tìm kiếm";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChucNang.Controls.Add(this.btnThongkeBD);
            this.pnChucNang.Controls.Add(this.btnThoat);
            this.pnChucNang.Controls.Add(this.checkBox1);
            this.pnChucNang.Controls.Add(this.txtSoNgay);
            this.pnChucNang.Controls.Add(this.lblSoNgayLam);
            this.pnChucNang.Controls.Add(this.dateTimePicker1);
            this.pnChucNang.Controls.Add(this.btnTimKiem);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnChucNang.Location = new System.Drawing.Point(0, 95);
            this.pnChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1292, 301);
            this.pnChucNang.TabIndex = 32;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(169, 143);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 21);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Tìm kiếm mã NV";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(579, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(243, 52);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(-227, 331);
            this.lblLuongCoBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(95, 17);
            this.lblLuongCoBan.TabIndex = 24;
            this.lblLuongCoBan.Text = "Lương cơ bản";
            // 
            // lblMaLuong
            // 
            this.lblMaLuong.AutoSize = true;
            this.lblMaLuong.Location = new System.Drawing.Point(-227, 188);
            this.lblMaLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLuong.Name = "lblMaLuong";
            this.lblMaLuong.Size = new System.Drawing.Size(66, 17);
            this.lblMaLuong.TabIndex = 20;
            this.lblMaLuong.Text = "Mã lương";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(-227, 258);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(93, 17);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblBLNV
            // 
            this.lblBLNV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBLNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBLNV.Location = new System.Drawing.Point(0, 0);
            this.lblBLNV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBLNV.Name = "lblBLNV";
            this.lblBLNV.Size = new System.Drawing.Size(1292, 95);
            this.lblBLNV.TabIndex = 19;
            this.lblBLNV.Text = "Thống kê ngày công";
            this.lblBLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBLNV.Click += new System.EventHandler(this.lblBLNV_Click);
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng Lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.MinimumWidth = 6;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            // 
            // KhongCong
            // 
            this.KhongCong.DataPropertyName = "KhongCong";
            this.KhongCong.HeaderText = "Không công";
            this.KhongCong.MinimumWidth = 6;
            this.KhongCong.Name = "KhongCong";
            this.KhongCong.ReadOnly = true;
            // 
            // SoNgayLam
            // 
            this.SoNgayLam.DataPropertyName = "SoNgayLam";
            this.SoNgayLam.HeaderText = "Số ngày làm";
            this.SoNgayLam.MinimumWidth = 6;
            this.SoNgayLam.Name = "SoNgayLam";
            this.SoNgayLam.ReadOnly = true;
            // 
            // clnLuongCB
            // 
            this.clnLuongCB.DataPropertyName = "LuongCoBan";
            this.clnLuongCB.HeaderText = "Lương cơ bản";
            this.clnLuongCB.MinimumWidth = 6;
            this.clnLuongCB.Name = "clnLuongCB";
            this.clnLuongCB.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ThangNam
            // 
            this.ThangNam.DataPropertyName = "ThangNam";
            this.ThangNam.HeaderText = "Mã Lương";
            this.ThangNam.MinimumWidth = 6;
            this.ThangNam.Name = "ThangNam";
            this.ThangNam.ReadOnly = true;
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThangNam,
            this.MaNhanVien,
            this.clnLuongCB,
            this.SoNgayLam,
            this.KhongCong,
            this.PhuCap,
            this.TongLuong});
            this.dgvBangLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBangLuong.Location = new System.Drawing.Point(0, 396);
            this.dgvBangLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.Size = new System.Drawing.Size(1292, 415);
            this.dgvBangLuong.TabIndex = 33;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.icons8_exit_21;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(579, 112);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(243, 52);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongkeBD
            // 
            this.btnThongkeBD.Image = global::_12523081_NguyenVanThang.Properties.Resources.statistics_201;
            this.btnThongkeBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongkeBD.Location = new System.Drawing.Point(579, 201);
            this.btnThongkeBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongkeBD.Name = "btnThongkeBD";
            this.btnThongkeBD.Size = new System.Drawing.Size(243, 52);
            this.btnThongkeBD.TabIndex = 33;
            this.btnThongkeBD.Text = "Thống kê dạng biểu đồ";
            this.btnThongkeBD.UseVisualStyleBackColor = true;
            this.btnThongkeBD.Click += new System.EventHandler(this.btnThongkeBD_Click);
            // 
            // FrmThongKeBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 811);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.lblLuongCoBan);
            this.Controls.Add(this.lblMaLuong);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblBLNV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKeBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.FrmThongKeBangLuong_Load);
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label lblSoNgayLam;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblMaLuong;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblBLNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLuongCB;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnThongkeBD;
        private System.Windows.Forms.Button btnThoat;
    }
}