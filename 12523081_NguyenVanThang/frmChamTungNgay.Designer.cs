namespace _12523081_NguyenVanThang
{
    partial class frmChamTungNgay
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
            this.labelMaNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.textBoxNgayCong = new System.Windows.Forms.TextBox();
            this.textBoxNhanVien = new System.Windows.Forms.TextBox();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnNgayChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChamCong = new System.Windows.Forms.Label();
            this.panelChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(180, 85);
            this.labelMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(95, 17);
            this.labelMaNV.TabIndex = 14;
            this.labelMaNV.Text = "Mã Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên nhân viên";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(137, 276);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(265, 22);
            this.dtp.TabIndex = 5;
            this.dtp.Leave += new System.EventHandler(this.dtp_Leave);
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Location = new System.Drawing.Point(11, 281);
            this.lblChonNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(76, 17);
            this.lblChonNgay.TabIndex = 4;
            this.lblChonNgay.Text = "Chọn ngày";
            // 
            // textBoxNgayCong
            // 
            this.textBoxNgayCong.Location = new System.Drawing.Point(184, 162);
            this.textBoxNgayCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNgayCong.Name = "textBoxNgayCong";
            this.textBoxNgayCong.Size = new System.Drawing.Size(119, 22);
            this.textBoxNgayCong.TabIndex = 4;
            // 
            // textBoxNhanVien
            // 
            this.textBoxNhanVien.Location = new System.Drawing.Point(184, 116);
            this.textBoxNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNhanVien.Name = "textBoxNhanVien";
            this.textBoxNhanVien.Size = new System.Drawing.Size(219, 22);
            this.textBoxNhanVien.TabIndex = 3;
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.label4);
            this.panelChucNang.Controls.Add(this.comboBoxPhongBan);
            this.panelChucNang.Controls.Add(this.labelMaNV);
            this.panelChucNang.Controls.Add(this.label3);
            this.panelChucNang.Controls.Add(this.label2);
            this.panelChucNang.Controls.Add(this.btnTimKiem);
            this.panelChucNang.Controls.Add(this.label1);
            this.panelChucNang.Controls.Add(this.dtp);
            this.panelChucNang.Controls.Add(this.lblChonNgay);
            this.panelChucNang.Controls.Add(this.textBoxNgayCong);
            this.panelChucNang.Controls.Add(this.textBoxNhanVien);
            this.panelChucNang.Controls.Add(this.btnCapNhat);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucNang.Location = new System.Drawing.Point(0, 86);
            this.panelChucNang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(1285, 336);
            this.panelChucNang.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phòng";
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(184, 31);
            this.comboBoxPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(219, 24);
            this.comboBoxPhongBan.TabIndex = 0;
            this.comboBoxPhongBan.Leave += new System.EventHandler(this.comboBoxPhongBan_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(216, 194);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(201, 41);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::_12523081_NguyenVanThang.Properties.Resources._update_20;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(20, 193);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(188, 42);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(445, 193);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(171, 42);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeight = 29;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.clnNgayChamCong,
            this.clnTinhTrang,
            this.ThangNam});
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChamCong.Location = new System.Drawing.Point(0, 498);
            this.dgvChamCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(1285, 288);
            this.dgvChamCong.TabIndex = 13;
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);
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
            this.clnNgayChamCong.DataPropertyName = "ChamCong";
            this.clnNgayChamCong.HeaderText = "Ngày Chấm Công";
            this.clnNgayChamCong.MinimumWidth = 6;
            this.clnNgayChamCong.Name = "clnNgayChamCong";
            this.clnNgayChamCong.ReadOnly = true;
            // 
            // clnTinhTrang
            // 
            this.clnTinhTrang.DataPropertyName = "NgayChamCong";
            this.clnTinhTrang.HeaderText = "Tình Trạng";
            this.clnTinhTrang.MinimumWidth = 6;
            this.clnTinhTrang.Name = "clnTinhTrang";
            this.clnTinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ThangNam
            // 
            this.ThangNam.DataPropertyName = "ThangNam";
            this.ThangNam.HeaderText = "Tháng năm";
            this.ThangNam.MinimumWidth = 6;
            this.ThangNam.Name = "ThangNam";
            // 
            // lblChamCong
            // 
            this.lblChamCong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblChamCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.Location = new System.Drawing.Point(0, 0);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(1285, 86);
            this.lblChamCong.TabIndex = 12;
            this.lblChamCong.Text = "CHẤM CÔNG";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChamTungNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 786);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.lblChamCong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChamTungNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công theo ngày";
            this.Load += new System.EventHandler(this.frmChamTungNgay_Load);
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.TextBox textBoxNgayCong;
        private System.Windows.Forms.TextBox textBoxNhanVien;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangNam;
    }
}