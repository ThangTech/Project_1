namespace _12523081_NguyenVanThang
{
    partial class frmChamCong
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
            this.lblChamCong = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnNgayChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.chkChamCongTatCa = new System.Windows.Forms.CheckBox();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNgayCong = new System.Windows.Forms.TextBox();
            this.textBoxNhanVien = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChamCong
            // 
            this.lblChamCong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblChamCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.Location = new System.Drawing.Point(0, 0);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(1153, 70);
            this.lblChamCong.TabIndex = 0;
            this.lblChamCong.Text = "CHẤM CÔNG";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeight = 29;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.clnNgayChamCong,
            this.TongNgayCong,
            this.clnTinhTrang,
            this.ThangNam});
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChamCong.Location = new System.Drawing.Point(0, 320);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(1153, 234);
            this.dgvChamCong.TabIndex = 3;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNhanVien";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnNgayChamCong
            // 
            this.clnNgayChamCong.DataPropertyName = "NgayChamCong";
            this.clnNgayChamCong.HeaderText = "Ngày Chấm Công";
            this.clnNgayChamCong.MinimumWidth = 6;
            this.clnNgayChamCong.Name = "clnNgayChamCong";
            this.clnNgayChamCong.ReadOnly = true;
            // 
            // TongNgayCong
            // 
            this.TongNgayCong.DataPropertyName = "TongNgayCong";
            this.TongNgayCong.HeaderText = "Tổng ngày công";
            this.TongNgayCong.Name = "TongNgayCong";
            // 
            // clnTinhTrang
            // 
            this.clnTinhTrang.DataPropertyName = "TinhTrang";
            this.clnTinhTrang.HeaderText = "Tình Trạng";
            this.clnTinhTrang.MinimumWidth = 6;
            this.clnTinhTrang.Name = "clnTinhTrang";
            this.clnTinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ThangNam
            // 
            this.ThangNam.DataPropertyName = "ThangNam";
            this.ThangNam.HeaderText = "Tháng năm";
            this.ThangNam.Name = "ThangNam";
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Location = new System.Drawing.Point(4, 194);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(76, 17);
            this.lblChonNgay.TabIndex = 4;
            this.lblChonNgay.Text = "Chọn ngày";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(99, 190);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 23);
            this.dtp.TabIndex = 5;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // chkChamCongTatCa
            // 
            this.chkChamCongTatCa.AutoSize = true;
            this.chkChamCongTatCa.Location = new System.Drawing.Point(89, 163);
            this.chkChamCongTatCa.Name = "chkChamCongTatCa";
            this.chkChamCongTatCa.Size = new System.Drawing.Size(137, 21);
            this.chkChamCongTatCa.TabIndex = 7;
            this.chkChamCongTatCa.Text = "Chấm công tất cả";
            this.chkChamCongTatCa.UseVisualStyleBackColor = true;
            this.chkChamCongTatCa.CheckedChanged += new System.EventHandler(this.chkChamCongAll_CheckedChanged);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.labelMaNV);
            this.panelChucNang.Controls.Add(this.label3);
            this.panelChucNang.Controls.Add(this.label2);
            this.panelChucNang.Controls.Add(this.btnTimKiem);
            this.panelChucNang.Controls.Add(this.label1);
            this.panelChucNang.Controls.Add(this.dtp);
            this.panelChucNang.Controls.Add(this.lblChonNgay);
            this.panelChucNang.Controls.Add(this.chkChamCongTatCa);
            this.panelChucNang.Controls.Add(this.textBoxNgayCong);
            this.panelChucNang.Controls.Add(this.textBoxNhanVien);
            this.panelChucNang.Controls.Add(this.btnCapNhat);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Location = new System.Drawing.Point(121, 87);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(520, 227);
            this.panelChucNang.TabIndex = 11;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(131, 11);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(95, 17);
            this.labelMaNV.TabIndex = 14;
            this.labelMaNV.Text = "Mã Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên nhân viên";
            // 
            // textBoxNgayCong
            // 
            this.textBoxNgayCong.Location = new System.Drawing.Point(134, 84);
            this.textBoxNgayCong.Name = "textBoxNgayCong";
            this.textBoxNgayCong.Size = new System.Drawing.Size(90, 23);
            this.textBoxNgayCong.TabIndex = 4;
            // 
            // textBoxNhanVien
            // 
            this.textBoxNhanVien.Location = new System.Drawing.Point(134, 46);
            this.textBoxNhanVien.Name = "textBoxNhanVien";
            this.textBoxNhanVien.Size = new System.Drawing.Size(165, 23);
            this.textBoxNhanVien.TabIndex = 3;
            this.textBoxNhanVien.TextChanged += new System.EventHandler(this.textBoxNhanVien_TextChanged);
            this.textBoxNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNhanVien_KeyPress);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::_12523081_NguyenVanThang.Properties.Resources._update_20;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(11, 123);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(141, 34);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(330, 123);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(158, 124);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(151, 33);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1153, 554);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.lblChamCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.CheckBox chkChamCongTatCa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.TextBox textBoxNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNgayCong;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
    }
}