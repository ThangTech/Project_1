namespace _12523081_NguyenVanThang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.chkHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblQLNS = new System.Windows.Forms.Label();
            this.imageListChuaAnhLogin = new System.Windows.Forms.ImageList(this.components);
            this.lblAnhLogin = new System.Windows.Forms.Label();
            this.grbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(37, 56);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(90, 22);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(37, 100);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(83, 22);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.chkHienThiMatKhau);
            this.grbDangNhap.Controls.Add(this.btnThoat);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Controls.Add(this.txtMatKhau);
            this.grbDangNhap.Controls.Add(this.txtTaiKhoan);
            this.grbDangNhap.Controls.Add(this.lblTaiKhoan);
            this.grbDangNhap.Controls.Add(this.lblMatKhau);
            this.grbDangNhap.Location = new System.Drawing.Point(311, 107);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(458, 286);
            this.grbDangNhap.TabIndex = 2;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Đăng nhập";
            // 
            // chkHienThiMatKhau
            // 
            this.chkHienThiMatKhau.AutoSize = true;
            this.chkHienThiMatKhau.Location = new System.Drawing.Point(163, 151);
            this.chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            this.chkHienThiMatKhau.Size = new System.Drawing.Size(168, 26);
            this.chkHienThiMatKhau.TabIndex = 6;
            this.chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.chkHienThiMatKhau.UseVisualStyleBackColor = true;
            this.chkHienThiMatKhau.CheckedChanged += new System.EventHandler(this.chkHienThiMatKhau_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_12523081_NguyenVanThang.Properties.Resources.icons8_exit_21;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(263, 204);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = global::_12523081_NguyenVanThang.Properties.Resources.icons8_log_in_21;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(42, 204);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(146, 40);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(163, 97);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(232, 27);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(163, 53);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(232, 27);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // lblQLNS
            // 
            this.lblQLNS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblQLNS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQLNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLNS.Location = new System.Drawing.Point(0, 0);
            this.lblQLNS.Name = "lblQLNS";
            this.lblQLNS.Size = new System.Drawing.Size(835, 75);
            this.lblQLNS.TabIndex = 3;
            this.lblQLNS.Text = "QUẢN LÝ NHÂN SỰ";
            this.lblQLNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageListChuaAnhLogin
            // 
            this.imageListChuaAnhLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListChuaAnhLogin.ImageStream")));
            this.imageListChuaAnhLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListChuaAnhLogin.Images.SetKeyName(0, "login.png");
            this.imageListChuaAnhLogin.Images.SetKeyName(1, "icons8-login-50.png");
            // 
            // lblAnhLogin
            // 
            this.lblAnhLogin.ImageIndex = 0;
            this.lblAnhLogin.ImageList = this.imageListChuaAnhLogin;
            this.lblAnhLogin.Location = new System.Drawing.Point(12, 129);
            this.lblAnhLogin.Name = "lblAnhLogin";
            this.lblAnhLogin.Size = new System.Drawing.Size(262, 232);
            this.lblAnhLogin.TabIndex = 4;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(835, 435);
            this.Controls.Add(this.lblAnhLogin);
            this.Controls.Add(this.lblQLNS);
            this.Controls.Add(this.grbDangNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblQLNS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkHienThiMatKhau;
        private System.Windows.Forms.Label lblAnhLogin;
        private System.Windows.Forms.ImageList imageListChuaAnhLogin;
    }
}