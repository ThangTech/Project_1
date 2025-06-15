namespace _12523081_NguyenVanThang
{
    partial class frmBaoHiem
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
            this.lblBHNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.lblLoaiBH = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblNoiCap = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.cboLoaiBH = new System.Windows.Forms.ComboBox();
            this.dateNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dateNgayCap = new System.Windows.Forms.DateTimePicker();
            this.dgvBHNV = new System.Windows.Forms.DataGridView();
            this.MaBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LoaiBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.btnInDSBH = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMaBH = new System.Windows.Forms.Label();
            this.txtMaBH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHNV)).BeginInit();
            this.pnChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBHNV
            // 
            this.lblBHNV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBHNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBHNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBHNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBHNV.Location = new System.Drawing.Point(0, 0);
            this.lblBHNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBHNV.Name = "lblBHNV";
            this.lblBHNV.Size = new System.Drawing.Size(1165, 81);
            this.lblBHNV.TabIndex = 0;
            this.lblBHNV.Text = "BẢO HIỂM";
            this.lblBHNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(45, 174);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(108, 20);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblNgayCap
            // 
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(437, 115);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(79, 20);
            this.lblNgayCap.TabIndex = 7;
            this.lblNgayCap.Text = "Ngày cấp";
            // 
            // lblLoaiBH
            // 
            this.lblLoaiBH.AutoSize = true;
            this.lblLoaiBH.Location = new System.Drawing.Point(39, 237);
            this.lblLoaiBH.Name = "lblLoaiBH";
            this.lblLoaiBH.Size = new System.Drawing.Size(114, 20);
            this.lblLoaiBH.TabIndex = 5;
            this.lblLoaiBH.Text = "Loại bảo hiểm";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Location = new System.Drawing.Point(437, 171);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(107, 20);
            this.lblNgayHetHan.TabIndex = 9;
            this.lblNgayHetHan.Text = "Ngày hết hạn";
            // 
            // lblNoiCap
            // 
            this.lblNoiCap.AutoSize = true;
            this.lblNoiCap.Location = new System.Drawing.Point(437, 234);
            this.lblNoiCap.Name = "lblNoiCap";
            this.lblNoiCap.Size = new System.Drawing.Size(66, 20);
            this.lblNoiCap.TabIndex = 11;
            this.lblNoiCap.Text = "Nơi cấp";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(159, 171);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(207, 26);
            this.txtMaNV.TabIndex = 4;
            this.txtMaNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaNV_MouseClick);
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(526, 231);
            this.txtNoiCap.Multiline = true;
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(297, 71);
            this.txtNoiCap.TabIndex = 12;
            // 
            // cboLoaiBH
            // 
            this.cboLoaiBH.FormattingEnabled = true;
            this.cboLoaiBH.Items.AddRange(new object[] {
            "Bảo hiểm Y tế",
            "Bảo hiểm xã hội"});
            this.cboLoaiBH.Location = new System.Drawing.Point(159, 234);
            this.cboLoaiBH.Name = "cboLoaiBH";
            this.cboLoaiBH.Size = new System.Drawing.Size(207, 28);
            this.cboLoaiBH.TabIndex = 6;
            // 
            // dateNgayHetHan
            // 
            this.dateNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayHetHan.Location = new System.Drawing.Point(616, 166);
            this.dateNgayHetHan.Name = "dateNgayHetHan";
            this.dateNgayHetHan.Size = new System.Drawing.Size(207, 26);
            this.dateNgayHetHan.TabIndex = 10;
            // 
            // dateNgayCap
            // 
            this.dateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayCap.Location = new System.Drawing.Point(616, 110);
            this.dateNgayCap.Name = "dateNgayCap";
            this.dateNgayCap.Size = new System.Drawing.Size(207, 26);
            this.dateNgayCap.TabIndex = 8;
            // 
            // dgvBHNV
            // 
            this.dgvBHNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBHNV.ColumnHeadersHeight = 35;
            this.dgvBHNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaoHiem,
            this.MaNhanVien,
            this.LoaiBaoHiem,
            this.NgayCap,
            this.NgayHetHan,
            this.NoiCap});
            this.dgvBHNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBHNV.Location = new System.Drawing.Point(0, 356);
            this.dgvBHNV.Name = "dgvBHNV";
            this.dgvBHNV.RowHeadersWidth = 51;
            this.dgvBHNV.RowTemplate.Height = 24;
            this.dgvBHNV.Size = new System.Drawing.Size(1165, 258);
            this.dgvBHNV.TabIndex = 14;
            this.dgvBHNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBHNV_CellClick);
            // 
            // MaBaoHiem
            // 
            this.MaBaoHiem.DataPropertyName = "MaBaoHiem";
            this.MaBaoHiem.HeaderText = "Mã BH";
            this.MaBaoHiem.MinimumWidth = 6;
            this.MaBaoHiem.Name = "MaBaoHiem";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // LoaiBaoHiem
            // 
            this.LoaiBaoHiem.DataPropertyName = "LoaiBaoHiem";
            this.LoaiBaoHiem.HeaderText = "Loại Bảo hiểm";
            this.LoaiBaoHiem.MinimumWidth = 6;
            this.LoaiBaoHiem.Name = "LoaiBaoHiem";
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.MinimumWidth = 6;
            this.NgayCap.Name = "NgayCap";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // NoiCap
            // 
            this.NoiCap.DataPropertyName = "NoiCap";
            this.NoiCap.HeaderText = "Nơi Cấp";
            this.NoiCap.MinimumWidth = 6;
            this.NoiCap.Name = "NoiCap";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.SkyBlue;
            this.pnChucNang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnChucNang.Controls.Add(this.btnInDSBH);
            this.pnChucNang.Controls.Add(this.btnTimKiem);
            this.pnChucNang.Controls.Add(this.btnThem);
            this.pnChucNang.Controls.Add(this.btnThoat);
            this.pnChucNang.Controls.Add(this.btnXoa);
            this.pnChucNang.Controls.Add(this.btnSua);
            this.pnChucNang.Location = new System.Drawing.Point(868, 110);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(297, 209);
            this.pnChucNang.TabIndex = 13;
            // 
            // btnInDSBH
            // 
            this.btnInDSBH.Image = global::_12523081_NguyenVanThang.Properties.Resources.print_20;
            this.btnInDSBH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInDSBH.Location = new System.Drawing.Point(158, 141);
            this.btnInDSBH.Name = "btnInDSBH";
            this.btnInDSBH.Size = new System.Drawing.Size(119, 32);
            this.btnInDSBH.TabIndex = 15;
            this.btnInDSBH.Text = "In DS";
            this.btnInDSBH.UseVisualStyleBackColor = true;
            this.btnInDSBH.Click += new System.EventHandler(this.btnInDSBH_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 139);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 34);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::_12523081_NguyenVanThang.Properties.Resources._add_20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(24, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(158, 81);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 37);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::_12523081_NguyenVanThang.Properties.Resources._remove_20;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(24, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::_12523081_NguyenVanThang.Properties.Resources.modify_19;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(158, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 37);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMaBH
            // 
            this.lblMaBH.AutoSize = true;
            this.lblMaBH.Location = new System.Drawing.Point(48, 109);
            this.lblMaBH.Name = "lblMaBH";
            this.lblMaBH.Size = new System.Drawing.Size(105, 20);
            this.lblMaBH.TabIndex = 1;
            this.lblMaBH.Text = "Mã bảo hiểm";
            // 
            // txtMaBH
            // 
            this.txtMaBH.Location = new System.Drawing.Point(159, 106);
            this.txtMaBH.Name = "txtMaBH";
            this.txtMaBH.Size = new System.Drawing.Size(207, 26);
            this.txtMaBH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã nhân viên";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(159, 142);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(108, 20);
            this.labelMaNV.TabIndex = 16;
            this.labelMaNV.Text = "Mã nhân viên";
            // 
            // frmBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1165, 614);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaBH);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.dgvBHNV);
            this.Controls.Add(this.dateNgayCap);
            this.Controls.Add(this.dateNgayHetHan);
            this.Controls.Add(this.cboLoaiBH);
            this.Controls.Add(this.txtNoiCap);
            this.Controls.Add(this.txtMaBH);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblNoiCap);
            this.Controls.Add(this.lblNgayHetHan);
            this.Controls.Add(this.lblLoaiBH);
            this.Controls.Add(this.lblNgayCap);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblBHNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoHiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo hiểm";
            this.Load += new System.EventHandler(this.frmBaoHiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHNV)).EndInit();
            this.pnChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBHNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.Label lblLoaiBH;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblNoiCap;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.ComboBox cboLoaiBH;
        private System.Windows.Forms.DateTimePicker dateNgayHetHan;
        private System.Windows.Forms.DateTimePicker dateNgayCap;
        private System.Windows.Forms.DataGridView dgvBHNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMaBH;
        private System.Windows.Forms.TextBox txtMaBH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInDSBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaoHiem;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaNV;
    }
}