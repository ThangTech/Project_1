namespace _12523081_NguyenVanThang
{
    partial class frmCheDoNghi
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
            this.cboLoaiNghi = new System.Windows.Forms.ComboBox();
            this.lblCLN = new System.Windows.Forms.Label();
            this.lblCDN = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblMaNghi = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaNghi = new System.Windows.Forms.TextBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvCheDoNghi = new System.Windows.Forms.DataGridView();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheDoNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiNghi
            // 
            this.cboLoaiNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiNghi.FormattingEnabled = true;
            this.cboLoaiNghi.Location = new System.Drawing.Point(231, 263);
            this.cboLoaiNghi.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiNghi.Name = "cboLoaiNghi";
            this.cboLoaiNghi.Size = new System.Drawing.Size(222, 24);
            this.cboLoaiNghi.TabIndex = 6;
            // 
            // lblCLN
            // 
            this.lblCLN.AutoSize = true;
            this.lblCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCLN.Location = new System.Drawing.Point(98, 266);
            this.lblCLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCLN.Name = "lblCLN";
            this.lblCLN.Size = new System.Drawing.Size(98, 17);
            this.lblCLN.TabIndex = 5;
            this.lblCLN.Text = "Chọn loại nghỉ";
            // 
            // lblCDN
            // 
            this.lblCDN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCDN.Location = new System.Drawing.Point(0, 0);
            this.lblCDN.Name = "lblCDN";
            this.lblCDN.Size = new System.Drawing.Size(1149, 79);
            this.lblCDN.TabIndex = 0;
            this.lblCDN.Text = "CHẾ ĐỘ NGHỈ";
            this.lblCDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(100, 339);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(93, 17);
            this.lblNgayBD.TabIndex = 7;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(100, 408);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(95, 17);
            this.lblNgayKT.TabIndex = 9;
            this.lblNgayKT.Text = "Ngày kết thúc";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(627, 128);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(43, 17);
            this.lblLyDo.TabIndex = 11;
            this.lblLyDo.Text = "Lý do";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(232, 334);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(222, 23);
            this.dtpNgayBatDau.TabIndex = 8;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(232, 403);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(222, 23);
            this.dtpNgayKetThuc.TabIndex = 10;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(701, 125);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(305, 115);
            this.txtLyDo.TabIndex = 12;
            // 
            // lblMaNghi
            // 
            this.lblMaNghi.AutoSize = true;
            this.lblMaNghi.Location = new System.Drawing.Point(99, 125);
            this.lblMaNghi.Name = "lblMaNghi";
            this.lblMaNghi.Size = new System.Drawing.Size(58, 17);
            this.lblMaNghi.TabIndex = 1;
            this.lblMaNghi.Text = "Mã nghỉ";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(99, 193);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(93, 17);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(231, 190);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(222, 23);
            this.txtMaNV.TabIndex = 4;
            this.txtMaNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaNV_MouseClick);
            // 
            // txtMaNghi
            // 
            this.txtMaNghi.Location = new System.Drawing.Point(231, 122);
            this.txtMaNghi.Name = "txtMaNghi";
            this.txtMaNghi.Size = new System.Drawing.Size(222, 23);
            this.txtMaNghi.TabIndex = 2;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnTimKiem);
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(631, 263);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(375, 188);
            this.grbChucNang.TabIndex = 13;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(91, 145);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 37);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(209, 92);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 37);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::_12523081_NguyenVanThang.Properties.Resources._remove_20;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(32, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::_12523081_NguyenVanThang.Properties.Resources.save_20;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(209, 34);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 37);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::_12523081_NguyenVanThang.Properties.Resources._add_20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(32, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvCheDoNghi
            // 
            this.dgvCheDoNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheDoNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheDoNghi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCheDoNghi.Location = new System.Drawing.Point(0, 457);
            this.dgvCheDoNghi.Name = "dgvCheDoNghi";
            this.dgvCheDoNghi.RowHeadersWidth = 51;
            this.dgvCheDoNghi.RowTemplate.Height = 24;
            this.dgvCheDoNghi.Size = new System.Drawing.Size(1149, 200);
            this.dgvCheDoNghi.TabIndex = 14;
            this.dgvCheDoNghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheDoNghi_CellClick);
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(229, 158);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(95, 17);
            this.labelMaNV.TabIndex = 18;
            this.labelMaNV.Text = "Mã Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Nhân viên";
            // 
            // frmCheDoNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1149, 657);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCheDoNghi);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.txtMaNghi);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblMaNghi);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblLyDo);
            this.Controls.Add(this.lblNgayKT);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.lblCDN);
            this.Controls.Add(this.lblCLN);
            this.Controls.Add(this.cboLoaiNghi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCheDoNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chế độ nghỉ";
            this.Load += new System.EventHandler(this.frmCheDoNghi_Load);
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheDoNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiNghi;
        private System.Windows.Forms.Label lblCLN;
        private System.Windows.Forms.Label lblCDN;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label lblMaNghi;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaNghi;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvCheDoNghi;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label label3;
    }
}