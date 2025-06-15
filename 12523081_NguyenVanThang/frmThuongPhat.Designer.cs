namespace _12523081_NguyenVanThang
{
    partial class frmThuongPhat
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
            this.lblThuongPhat = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.lblVND = new System.Windows.Forms.Label();
            this.dgvThuongPhat = new System.Windows.Forms.DataGridView();
            this.lblMaKTP = new System.Windows.Forms.Label();
            this.txtMaKTP = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnInKTP = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.errorProviderNhapSo = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelMaNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNhanVien = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MaKTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongPhat)).BeginInit();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNhapSo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThuongPhat
            // 
            this.lblThuongPhat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblThuongPhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThuongPhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThuongPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThuongPhat.Location = new System.Drawing.Point(0, 0);
            this.lblThuongPhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuongPhat.Name = "lblThuongPhat";
            this.lblThuongPhat.Size = new System.Drawing.Size(1255, 76);
            this.lblThuongPhat.TabIndex = 0;
            this.lblThuongPhat.Text = "THƯỞNG PHẠT";
            this.lblThuongPhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(88, 304);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(43, 17);
            this.lblLyDo.TabIndex = 1;
            this.lblLyDo.Text = "Lý do";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(152, 305);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(292, 112);
            this.txtLyDo.TabIndex = 7;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(534, 111);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(36, 17);
            this.lblTien.TabIndex = 1;
            this.lblTien.Text = "Tiền";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(592, 108);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(226, 23);
            this.txtTien.TabIndex = 8;
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Location = new System.Drawing.Point(824, 111);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(37, 17);
            this.lblVND.TabIndex = 1;
            this.lblVND.Text = "VND";
            // 
            // dgvThuongPhat
            // 
            this.dgvThuongPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuongPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKTP,
            this.MaNhanVien,
            this.Loai,
            this.LyDo,
            this.SoTien,
            this.ThangNam});
            this.dgvThuongPhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThuongPhat.Location = new System.Drawing.Point(0, 450);
            this.dgvThuongPhat.Name = "dgvThuongPhat";
            this.dgvThuongPhat.RowHeadersWidth = 51;
            this.dgvThuongPhat.RowTemplate.Height = 24;
            this.dgvThuongPhat.Size = new System.Drawing.Size(1255, 292);
            this.dgvThuongPhat.TabIndex = 10;
            this.dgvThuongPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuongPhat_CellClick);
            // 
            // lblMaKTP
            // 
            this.lblMaKTP.AutoSize = true;
            this.lblMaKTP.Location = new System.Drawing.Point(35, 111);
            this.lblMaKTP.Name = "lblMaKTP";
            this.lblMaKTP.Size = new System.Drawing.Size(58, 17);
            this.lblMaKTP.TabIndex = 11;
            this.lblMaKTP.Text = "Mã KTP";
            // 
            // txtMaKTP
            // 
            this.txtMaKTP.Location = new System.Drawing.Point(152, 108);
            this.txtMaKTP.Name = "txtMaKTP";
            this.txtMaKTP.Size = new System.Drawing.Size(199, 23);
            this.txtMaKTP.TabIndex = 8;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(99, 239);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(35, 17);
            this.lblLoai.TabIndex = 12;
            this.lblLoai.Text = "Loại";
            // 
            // grbChucNang
            // 
            this.grbChucNang.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grbChucNang.Controls.Add(this.btnInKTP);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Location = new System.Drawing.Point(525, 239);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(316, 183);
            this.grbChucNang.TabIndex = 13;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnInKTP
            // 
            this.btnInKTP.Image = global::_12523081_NguyenVanThang.Properties.Resources.print_20;
            this.btnInKTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInKTP.Location = new System.Drawing.Point(17, 143);
            this.btnInKTP.Name = "btnInKTP";
            this.btnInKTP.Size = new System.Drawing.Size(281, 34);
            this.btnInKTP.TabIndex = 10;
            this.btnInKTP.Text = "In danh sách KTP";
            this.btnInKTP.UseVisualStyleBackColor = true;
            this.btnInKTP.Click += new System.EventHandler(this.btnInKTP_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::_12523081_NguyenVanThang.Properties.Resources._add_20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(17, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::_12523081_NguyenVanThang.Properties.Resources.save_20;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(174, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 32);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Sửa";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::_12523081_NguyenVanThang.Properties.Resources._remove_20;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(17, 94);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 32);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(174, 94);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(500, 153);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(65, 17);
            this.lblNgayTao.TabIndex = 1;
            this.lblNgayTao.Text = "Ngày tạo";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(592, 148);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(226, 23);
            this.dtpNgayTao.TabIndex = 14;
            this.dtpNgayTao.Leave += new System.EventHandler(this.dtpNgayTao_Leave);
            // 
            // errorProviderNhapSo
            // 
            this.errorProviderNhapSo.ContainerControl = this;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(149, 155);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(95, 17);
            this.labelMaNV.TabIndex = 20;
            this.labelMaNV.Text = "Mã Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên nhân viên";
            // 
            // textBoxNhanVien
            // 
            this.textBoxNhanVien.Location = new System.Drawing.Point(152, 190);
            this.textBoxNhanVien.Name = "textBoxNhanVien";
            this.textBoxNhanVien.Size = new System.Drawing.Size(165, 23);
            this.textBoxNhanVien.TabIndex = 17;
            this.textBoxNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhanVien_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(152, 239);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Khen/Phạt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MaKTP
            // 
            this.MaKTP.DataPropertyName = "MaKTP";
            this.MaKTP.HeaderText = "Mã ";
            this.MaKTP.Name = "MaKTP";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Tên nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loai";
            this.Loai.Name = "Loai";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.Name = "LyDo";
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.Name = "SoTien";
            // 
            // ThangNam
            // 
            this.ThangNam.DataPropertyName = "ThangNam";
            this.ThangNam.HeaderText = "Tháng năm";
            this.ThangNam.Name = "ThangNam";
            // 
            // frmThuongPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1255, 742);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.textBoxNhanVien);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblMaKTP);
            this.Controls.Add(this.dgvThuongPhat);
            this.Controls.Add(this.txtMaKTP);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.lblLyDo);
            this.Controls.Add(this.lblThuongPhat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThuongPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thưởng phạt";
            this.Load += new System.EventHandler(this.frmThuongPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongPhat)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNhapSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThuongPhat;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvThuongPhat;
        private System.Windows.Forms.Label lblMaKTP;
        private System.Windows.Forms.TextBox txtMaKTP;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.ErrorProvider errorProviderNhapSo;
        private System.Windows.Forms.Button btnInKTP;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKTP;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
    }
}