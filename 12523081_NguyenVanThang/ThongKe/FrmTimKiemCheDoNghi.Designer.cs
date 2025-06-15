namespace _12523081_NguyenVanThang.ThongKe
{
    partial class FrmTimKiemCheDoNghi
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
            this.dgvCheDoNghi = new System.Windows.Forms.DataGridView();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblCDN = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheDoNghi)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCheDoNghi
            // 
            this.dgvCheDoNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheDoNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheDoNghi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCheDoNghi.Location = new System.Drawing.Point(0, 328);
            this.dgvCheDoNghi.Name = "dgvCheDoNghi";
            this.dgvCheDoNghi.RowHeadersWidth = 51;
            this.dgvCheDoNghi.RowTemplate.Height = 24;
            this.dgvCheDoNghi.Size = new System.Drawing.Size(1039, 341);
            this.dgvCheDoNghi.TabIndex = 33;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnTimKiem);
            this.grbChucNang.Controls.Add(this.txtMaNV);
            this.grbChucNang.Controls.Add(this.lblMaNV);
            this.grbChucNang.Location = new System.Drawing.Point(28, 99);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(375, 340);
            this.grbChucNang.TabIndex = 32;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(147, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(222, 20);
            this.txtMaNV.TabIndex = 23;
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(15, 53);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(72, 13);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblCDN
            // 
            this.lblCDN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCDN.Location = new System.Drawing.Point(0, 0);
            this.lblCDN.Name = "lblCDN";
            this.lblCDN.Size = new System.Drawing.Size(1039, 79);
            this.lblCDN.TabIndex = 19;
            this.lblCDN.Text = "CHẾ ĐỘ NGHỈ";
            this.lblCDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::_12523081_NguyenVanThang.Properties.Resources.search_employee;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(88, 164);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 37);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmTimKiemCheDoNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 669);
            this.Controls.Add(this.dgvCheDoNghi);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.lblCDN);
            this.Name = "FrmTimKiemCheDoNghi";
            this.Text = "FrmTimKiemCheDoNghi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheDoNghi)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvCheDoNghi;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblCDN;
    }
}