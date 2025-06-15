namespace _12523081_NguyenVanThang
{
    partial class frmNhanVien
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
            this.lblTTNS = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblSoCM = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblHSL = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dgvTTNV = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.cboHSL = new System.Windows.Forms.ComboBox();
            this.DateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.DateNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnInDanhSachNV = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNV)).BeginInit();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTTNS
            // 
            this.lblTTNS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTTNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTTNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTTNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTNS.Location = new System.Drawing.Point(0, 0);
            this.lblTTNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTTNS.Name = "lblTTNS";
            this.lblTTNS.Size = new System.Drawing.Size(1401, 73);
            this.lblTTNS.TabIndex = 0;
            this.lblTTNS.Text = "THÔNG TIN NHÂN SỰ";
            this.lblTTNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(32, 106);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(93, 17);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(32, 156);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(99, 17);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(32, 208);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(77, 17);
            this.lblPhongBan.TabIndex = 1;
            this.lblPhongBan.Text = "Phòng ban";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(32, 258);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(59, 17);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(32, 312);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 17);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(32, 366);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaySinh.TabIndex = 1;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(529, 109);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(529, 263);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(61, 17);
            this.lblTrinhDo.TabIndex = 1;
            this.lblTrinhDo.Text = "Trình độ";
            // 
            // lblSoCM
            // 
            this.lblSoCM.AutoSize = true;
            this.lblSoCM.Location = new System.Drawing.Point(529, 159);
            this.lblSoCM.Name = "lblSoCM";
            this.lblSoCM.Size = new System.Drawing.Size(69, 17);
            this.lblSoCM.TabIndex = 1;
            this.lblSoCM.Text = "Số CMND";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(530, 209);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(72, 17);
            this.lblDienThoai.TabIndex = 1;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblHSL
            // 
            this.lblHSL.AutoSize = true;
            this.lblHSL.Location = new System.Drawing.Point(28, 424);
            this.lblHSL.Name = "lblHSL";
            this.lblHSL.Size = new System.Drawing.Size(84, 17);
            this.lblHSL.TabIndex = 1;
            this.lblHSL.Text = "Hệ số lương";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(529, 367);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(94, 17);
            this.lblNgayVaoLam.TabIndex = 1;
            this.lblNgayVaoLam.Text = "Ngày vào làm";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(530, 320);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // dgvTTNV
            // 
            this.dgvTTNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.MaPhongBan,
            this.MaChucVu,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.SoCMND,
            this.DienThoai,
            this.Email,
            this.TrinhDo,
            this.NgayVaoLam,
            this.HeSoLuong,
            this.MucLuong,
            this.PhuCap,
            this.TinhTrang});
            this.dgvTTNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTTNV.Location = new System.Drawing.Point(0, 510);
            this.dgvTTNV.Name = "dgvTTNV";
            this.dgvTTNV.RowHeadersWidth = 51;
            this.dgvTTNV.RowTemplate.Height = 24;
            this.dgvTTNV.Size = new System.Drawing.Size(1401, 256);
            this.dgvTTNV.TabIndex = 5;
            this.dgvTTNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTNV_CellClick);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(157, 103);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 23);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(157, 153);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 23);
            this.txtTenNV.TabIndex = 6;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(633, 156);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(206, 23);
            this.txtSoCMND.TabIndex = 6;
            this.txtSoCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoCMND_KeyPress);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(633, 206);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(206, 23);
            this.txtDienThoai.TabIndex = 6;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(633, 260);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(206, 23);
            this.txtTrinhDo.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(633, 314);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(633, 103);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(339, 23);
            this.txtDiaChi.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // cboPB
            // 
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Location = new System.Drawing.Point(157, 205);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(200, 24);
            this.cboPB.TabIndex = 7;
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Location = new System.Drawing.Point(157, 255);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(200, 24);
            this.cboCV.TabIndex = 7;
            // 
            // cboHSL
            // 
            this.cboHSL.FormattingEnabled = true;
            this.cboHSL.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboHSL.Location = new System.Drawing.Point(157, 421);
            this.cboHSL.Name = "cboHSL";
            this.cboHSL.Size = new System.Drawing.Size(200, 24);
            this.cboHSL.TabIndex = 7;
            // 
            // DateNgaySinh
            // 
            this.DateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNgaySinh.Location = new System.Drawing.Point(157, 360);
            this.DateNgaySinh.Name = "DateNgaySinh";
            this.DateNgaySinh.Size = new System.Drawing.Size(200, 23);
            this.DateNgaySinh.TabIndex = 8;
            // 
            // DateNgayVaoLam
            // 
            this.DateNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNgayVaoLam.Location = new System.Drawing.Point(633, 362);
            this.DateNgayVaoLam.Name = "DateNgayVaoLam";
            this.DateNgayVaoLam.Size = new System.Drawing.Size(206, 23);
            this.DateNgayVaoLam.TabIndex = 8;
            // 
            // grpChucNang
            // 
            this.grpChucNang.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grpChucNang.Controls.Add(this.btnInDanhSachNV);
            this.grpChucNang.Controls.Add(this.btnTimKiem);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnThoat);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Location = new System.Drawing.Point(1048, 181);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(311, 268);
            this.grpChucNang.TabIndex = 10;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnInDanhSachNV
            // 
            this.btnInDanhSachNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInDanhSachNV.Image = global::_12523081_NguyenVanThang.Properties.Resources.print_20;
            this.btnInDanhSachNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInDanhSachNV.Location = new System.Drawing.Point(24, 189);
            this.btnInDanhSachNV.Name = "btnInDanhSachNV";
            this.btnInDanhSachNV.Size = new System.Drawing.Size(118, 35);
            this.btnInDanhSachNV.TabIndex = 12;
            this.btnInDanhSachNV.Text = "In DS";
            this.btnInDanhSachNV.UseVisualStyleBackColor = false;
            this.btnInDanhSachNV.Click += new System.EventHandler(this.btnInDanhSachNV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(167, 113);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 39);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Image = global::_12523081_NguyenVanThang.Properties.Resources._add_20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(24, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 39);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Image = global::_12523081_NguyenVanThang.Properties.Resources._update_20;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(167, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 39);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(167, 185);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Image = global::_12523081_NguyenVanThang.Properties.Resources._remove_20;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(24, 113);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 39);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(157, 312);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Nam/Nữ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Location = new System.Drawing.Point(633, 418);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(206, 23);
            this.txtMucLuong.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mức lương";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // MaPhongBan
            // 
            this.MaPhongBan.DataPropertyName = "MaPhongBan";
            this.MaPhongBan.HeaderText = "Phòng ban";
            this.MaPhongBan.Name = "MaPhongBan";
            this.MaPhongBan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaPhongBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Chức vụ";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            this.SoCMND.HeaderText = "CMND";
            this.SoCMND.Name = "SoCMND";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // TrinhDo
            // 
            this.TrinhDo.DataPropertyName = "TrinhDo";
            this.TrinhDo.HeaderText = "Trình độ";
            this.TrinhDo.Name = "TrinhDo";
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày vào làm";
            this.NgayVaoLam.Name = "NgayVaoLam";
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ số lương";
            this.HeSoLuong.Name = "HeSoLuong";
            // 
            // MucLuong
            // 
            this.MucLuong.DataPropertyName = "MucLuong";
            this.MucLuong.HeaderText = "Mức lương";
            this.MucLuong.Name = "MucLuong";
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.Name = "PhuCap";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(633, 463);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(206, 23);
            this.txtPhuCap.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phụ cấp";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1401, 766);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.DateNgayVaoLam);
            this.Controls.Add(this.DateNgaySinh);
            this.Controls.Add(this.cboHSL);
            this.Controls.Add(this.cboCV);
            this.Controls.Add(this.cboPB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTrinhDo);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.dgvTTNV);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTrinhDo);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.lblNgayVaoLam);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblHSL);
            this.Controls.Add(this.lblSoCM);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTTNS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNV)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTNS;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblSoCM;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblHSL;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvTTNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboPB;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.ComboBox cboHSL;
        private System.Windows.Forms.DateTimePicker DateNgaySinh;
        private System.Windows.Forms.DateTimePicker DateNgayVaoLam;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnInDanhSachNV;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMucLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaPhongBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Label label2;
    }
}