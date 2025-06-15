namespace _12523081_NguyenVanThang
{
    partial class frmBangLuong
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
            this.components = new System.ComponentModel.Container();
            this.lblBLNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.cboHSL = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnLuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaLuong = new System.Windows.Forms.Label();
            this.txtMaLuong = new System.Windows.Forms.TextBox();
            this.lblSoNgayLam = new System.Windows.Forms.Label();
            this.txtSoNgayLam = new System.Windows.Forms.TextBox();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.errorProviderNhapSo = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInBangLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapnhatTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNhapSo)).BeginInit();
            this.pnChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBLNV
            // 
            this.lblBLNV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBLNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBLNV.Location = new System.Drawing.Point(0, 0);
            this.lblBLNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBLNV.Name = "lblBLNV";
            this.lblBLNV.Size = new System.Drawing.Size(1219, 77);
            this.lblBLNV.TabIndex = 0;
            this.lblBLNV.Text = "BẢNG LƯƠNG";
            this.lblBLNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(39, 210);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(108, 20);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(39, 269);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(110, 20);
            this.lblLuongCoBan.TabIndex = 5;
            this.lblLuongCoBan.Text = "Lương cơ bản";
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Location = new System.Drawing.Point(322, 269);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(45, 20);
            this.lblVND.TabIndex = 7;
            this.lblVND.Text = "VND";
            // 
            // cboHSL
            // 
            this.cboHSL.FormattingEnabled = true;
            this.cboHSL.Location = new System.Drawing.Point(540, 147);
            this.cboHSL.Name = "cboHSL";
            this.cboHSL.Size = new System.Drawing.Size(158, 28);
            this.cboHSL.TabIndex = 13;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(158, 207);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(158, 26);
            this.txtMaNV.TabIndex = 4;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(158, 266);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(158, 26);
            this.txtLuongCB.TabIndex = 6;
            this.txtLuongCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLuongCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongCB_KeyPress);
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
            this.dgvBangLuong.Location = new System.Drawing.Point(0, 444);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.Size = new System.Drawing.Size(1219, 238);
            this.dgvBangLuong.TabIndex = 15;
            this.dgvBangLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangLuong_CellClick);
            // 
            // ThangNam
            // 
            this.ThangNam.DataPropertyName = "ThangNam";
            this.ThangNam.HeaderText = "Mã Lương";
            this.ThangNam.MinimumWidth = 6;
            this.ThangNam.Name = "ThangNam";
            this.ThangNam.ReadOnly = true;
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
            // clnLuongCB
            // 
            this.clnLuongCB.DataPropertyName = "LuongCoBan";
            this.clnLuongCB.HeaderText = "Lương cơ bản";
            this.clnLuongCB.MinimumWidth = 6;
            this.clnLuongCB.Name = "clnLuongCB";
            this.clnLuongCB.ReadOnly = true;
            // 
            // SoNgayLam
            // 
            this.SoNgayLam.DataPropertyName = "SoNgayLam";
            this.SoNgayLam.HeaderText = "Số ngày làm";
            this.SoNgayLam.MinimumWidth = 6;
            this.SoNgayLam.Name = "SoNgayLam";
            this.SoNgayLam.ReadOnly = true;
            // 
            // KhongCong
            // 
            this.KhongCong.DataPropertyName = "KhongCong";
            this.KhongCong.HeaderText = "Không công";
            this.KhongCong.MinimumWidth = 6;
            this.KhongCong.Name = "KhongCong";
            this.KhongCong.ReadOnly = true;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.MinimumWidth = 6;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng Lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            // 
            // lblMaLuong
            // 
            this.lblMaLuong.AutoSize = true;
            this.lblMaLuong.Location = new System.Drawing.Point(39, 153);
            this.lblMaLuong.Name = "lblMaLuong";
            this.lblMaLuong.Size = new System.Drawing.Size(77, 20);
            this.lblMaLuong.TabIndex = 1;
            this.lblMaLuong.Text = "Mã lương";
            // 
            // txtMaLuong
            // 
            this.txtMaLuong.Location = new System.Drawing.Point(158, 150);
            this.txtMaLuong.Name = "txtMaLuong";
            this.txtMaLuong.Size = new System.Drawing.Size(158, 26);
            this.txtMaLuong.TabIndex = 2;
            // 
            // lblSoNgayLam
            // 
            this.lblSoNgayLam.AutoSize = true;
            this.lblSoNgayLam.Location = new System.Drawing.Point(421, 150);
            this.lblSoNgayLam.Name = "lblSoNgayLam";
            this.lblSoNgayLam.Size = new System.Drawing.Size(101, 20);
            this.lblSoNgayLam.TabIndex = 8;
            this.lblSoNgayLam.Text = "Số ngày làm";
            // 
            // txtSoNgayLam
            // 
            this.txtSoNgayLam.Location = new System.Drawing.Point(540, 269);
            this.txtSoNgayLam.Name = "txtSoNgayLam";
            this.txtSoNgayLam.Size = new System.Drawing.Size(158, 26);
            this.txtSoNgayLam.TabIndex = 9;
            this.txtSoNgayLam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgayLam_KeyPress);
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Location = new System.Drawing.Point(421, 210);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(70, 20);
            this.lblPhuCap.TabIndex = 10;
            this.lblPhuCap.Text = "Phụ cấp";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(540, 207);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(158, 26);
            this.txtPhuCap.TabIndex = 11;
            this.txtPhuCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhuCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhuCap_KeyPress);
            // 
            // errorProviderNhapSo
            // 
            this.errorProviderNhapSo.ContainerControl = this;
            // 
            // pnChucNang
            // 
            this.pnChucNang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChucNang.Controls.Add(this.btnCapnhatTatCa);
            this.pnChucNang.Controls.Add(this.cboPB);
            this.pnChucNang.Controls.Add(this.lblPhongBan);
            this.pnChucNang.Controls.Add(this.dateTimePicker1);
            this.pnChucNang.Controls.Add(this.btnXoa);
            this.pnChucNang.Controls.Add(this.btnSua);
            this.pnChucNang.Controls.Add(this.btnThem);
            this.pnChucNang.Controls.Add(this.btnTimKiem);
            this.pnChucNang.Controls.Add(this.btnInBangLuong);
            this.pnChucNang.Controls.Add(this.btnThoat);
            this.pnChucNang.Location = new System.Drawing.Point(752, 80);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(467, 358);
            this.pnChucNang.TabIndex = 14;
            // 
            // cboPB
            // 
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Location = new System.Drawing.Point(135, 61);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(200, 28);
            this.cboPB.TabIndex = 10;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(23, 64);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(88, 20);
            this.lblPhongBan.TabIndex = 9;
            this.lblPhongBan.Text = "Phòng ban";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::_12523081_NguyenVanThang.Properties.Resources._remove_20;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(26, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(182, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::_12523081_NguyenVanThang.Properties.Resources.save_20;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(242, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(182, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Lưu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::_12523081_NguyenVanThang.Properties.Resources._add_20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(26, 97);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(182, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(242, 243);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(182, 42);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInBangLuong
            // 
            this.btnInBangLuong.Image = global::_12523081_NguyenVanThang.Properties.Resources.print_20;
            this.btnInBangLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBangLuong.Location = new System.Drawing.Point(26, 245);
            this.btnInBangLuong.Name = "btnInBangLuong";
            this.btnInBangLuong.Size = new System.Drawing.Size(182, 38);
            this.btnInBangLuong.TabIndex = 4;
            this.btnInBangLuong.Text = "In danh sách";
            this.btnInBangLuong.UseVisualStyleBackColor = true;
            this.btnInBangLuong.Click += new System.EventHandler(this.btnInBangLuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(242, 172);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Không công";
            // 
            // btnCapnhatTatCa
            // 
            this.btnCapnhatTatCa.Image = global::_12523081_NguyenVanThang.Properties.Resources.information_25;
            this.btnCapnhatTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhatTatCa.Location = new System.Drawing.Point(135, 309);
            this.btnCapnhatTatCa.Name = "btnCapnhatTatCa";
            this.btnCapnhatTatCa.Size = new System.Drawing.Size(182, 42);
            this.btnCapnhatTatCa.TabIndex = 11;
            this.btnCapnhatTatCa.Text = "Cập nhật tất cả";
            this.btnCapnhatTatCa.UseVisualStyleBackColor = true;
            this.btnCapnhatTatCa.Click += new System.EventHandler(this.btnCapnhatTatCa_Click);
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1219, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.txtSoNgayLam);
            this.Controls.Add(this.txtMaLuong);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.cboHSL);
            this.Controls.Add(this.lblPhuCap);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.lblLuongCoBan);
            this.Controls.Add(this.lblSoNgayLam);
            this.Controls.Add(this.lblMaLuong);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblBLNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNhapSo)).EndInit();
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBLNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.ComboBox cboHSL;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Label lblMaLuong;
        private System.Windows.Forms.TextBox txtMaLuong;
        private System.Windows.Forms.Label lblSoNgayLam;
        private System.Windows.Forms.TextBox txtSoNgayLam;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProviderNhapSo;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Button btnInBangLuong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPB;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Button btnCapnhatTatCa;
    }
}