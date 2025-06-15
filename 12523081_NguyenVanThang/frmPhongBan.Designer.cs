namespace _12523081_NguyenVanThang
{
    partial class frmPhongBan
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
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.grpChucNangPB = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.grpChucNangPB.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhongBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhongBan.Location = new System.Drawing.Point(0, 0);
            this.lblPhongBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(1263, 83);
            this.lblPhongBan.TabIndex = 0;
            this.lblPhongBan.Text = "PHÒNG BAN";
            this.lblPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaPB
            // 
            this.lblMaPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(37, 184);
            this.lblMaPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(99, 17);
            this.lblMaPB.TabIndex = 1;
            this.lblMaPB.Text = "Mã phòng ban";
            // 
            // lblTenPB
            // 
            this.lblTenPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(37, 241);
            this.lblTenPB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(105, 17);
            this.lblTenPB.TabIndex = 3;
            this.lblTenPB.Text = "Tên phòng ban";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPB.Location = new System.Drawing.Point(177, 181);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(206, 23);
            this.txtMaPB.TabIndex = 2;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenPB.Location = new System.Drawing.Point(177, 234);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(206, 23);
            this.txtTenPB.TabIndex = 4;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPhongBan.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhongBan.Location = new System.Drawing.Point(504, 83);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 24;
            this.dgvPhongBan.Size = new System.Drawing.Size(759, 636);
            this.dgvPhongBan.TabIndex = 7;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // grpChucNangPB
            // 
            this.grpChucNangPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpChucNangPB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grpChucNangPB.Controls.Add(this.btnThem);
            this.grpChucNangPB.Controls.Add(this.btnThoat);
            this.grpChucNangPB.Controls.Add(this.btnXoa);
            this.grpChucNangPB.Controls.Add(this.btnSua);
            this.grpChucNangPB.Location = new System.Drawing.Point(41, 307);
            this.grpChucNangPB.Name = "grpChucNangPB";
            this.grpChucNangPB.Size = new System.Drawing.Size(358, 149);
            this.grpChucNangPB.TabIndex = 5;
            this.grpChucNangPB.TabStop = false;
            this.grpChucNangPB.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::_12523081_NguyenVanThang.Properties.Resources.add_17;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(27, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.close_20;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(213, 82);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::_12523081_NguyenVanThang.Properties.Resources.remove_19;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(27, 82);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::_12523081_NguyenVanThang.Properties.Resources.modify_19;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(213, 38);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grpTimKiem.Controls.Add(this.btnShowAll);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(41, 462);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(358, 149);
            this.grpTimKiem.TabIndex = 6;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Nhập nội dung cần tìm";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Image = global::_12523081_NguyenVanThang.Properties.Resources.show_property_20;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(206, 82);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(136, 32);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Hiện tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(23, 82);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(141, 32);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(23, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(319, 23);
            this.txtTimKiem.TabIndex = 0;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1263, 719);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpChucNangPB);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblPhongBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.grpChucNangPB.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grpChucNangPB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}