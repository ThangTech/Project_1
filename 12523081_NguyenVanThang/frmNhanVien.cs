using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCtrl;
using DataLayer;
using _12523081_NguyenVanThang.Report;
namespace _12523081_NguyenVanThang
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienCtrl NhanVienCtrl =new NhanVienCtrl();
        ChucVuCtrl ChucVuCtrl =new ChucVuCtrl();
        PhongBanCtrl PhongBanCtrl =new PhongBanCtrl();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            LoadcboPB();
            LoadcboCV();
            Loadphikn();
        }
        void Loadphikn()
        {
           dgvTTNV.DataSource = NhanVienCtrl.HienThi();
        }
        void LoadcboPB()
        {
            MaPhongBan.DataSource = PhongBanCtrl.HienThi();
            MaPhongBan.DisplayMember = "TenPhongBan";
            MaPhongBan.ValueMember = "MaPhongBan";
            cboPB.DataSource=PhongBanCtrl.HienThi();
            cboPB.DisplayMember = "TenPhongBan";
            cboPB.ValueMember = "MaPhongBan";
          
        }
        void LoadcboCV()
        {
            MaChucVu.DataSource = ChucVuCtrl.HienThi();
            MaChucVu.DisplayMember = "TenChucVu";
            MaChucVu.ValueMember = "MaChucVu";
            cboCV.DataSource = ChucVuCtrl.HienThi();
            cboCV.DisplayMember = "TenChucVu";
            cboCV.ValueMember = "MaChucVu";
           
        }

        private void dgvTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNV.Text = dgvTTNV[0, i].Value.ToString();
            txtTenNV.Text = dgvTTNV[1, i].Value.ToString();
            cboPB.SelectedValue = dgvTTNV[2, i].Value.ToString();
            cboCV.SelectedValue = dgvTTNV[3, i].Value.ToString();
            string gt = dgvTTNV[4, i].Value.ToString();
            if (gt == "Nam")
            {
                checkBox1.Checked = true;
            }
            else if (gt == "Nữ")
            {
                checkBox1.Checked = false;
            }
            DateNgaySinh.Value = Convert.ToDateTime(dgvTTNV[5, i].Value);
            txtDiaChi.Text = dgvTTNV[6, i].Value.ToString();
            txtSoCMND.Text = dgvTTNV[7, i].Value.ToString();
            txtDienThoai.Text = dgvTTNV[8, i].Value.ToString();
            txtEmail.Text = dgvTTNV[9, i].Value.ToString();
            txtTrinhDo.Text = dgvTTNV[10, i].Value.ToString();
            DateNgayVaoLam.Value = Convert.ToDateTime(dgvTTNV[11, i].Value);
            txtMucLuong.Text = dgvTTNV[12, i].Value.ToString();
            cboHSL.SelectedItem = dgvTTNV[13, i].Value.ToString();
             txtPhuCap.Text    = dgvTTNV[14, i].Value.ToString();
        }
        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider.SetError(txtSoCMND, "Vui lòng nhập số!");
            }
            else
                this.errorProvider.Clear();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider.SetError(txtDienThoai,"Vui lòng nhập số!");
                txtDienThoai.MaxLength = 10;
            }
            else
                this.errorProvider.Clear();
        }
        private bool KTMaNV(string maNV)
        {
            try
            {
              
               
                return true ; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = txtMaNV.Text.Trim();
                nhanVien.TenNhanVien = txtTenNV.Text.Trim();
                nhanVien.MaChucVu = cboCV.SelectedValue.ToString();
                nhanVien.MaPhongBan = cboPB.SelectedValue.ToString();
                nhanVien.GioiTinh = checkBox1.Checked ? "Nam" : "Nữ";
                nhanVien.NgaySinh = DateNgaySinh.Value;
                nhanVien.DiaChi = txtDiaChi.Text.Trim();
                nhanVien.SoCMND = txtSoCMND.Text.Trim();
                nhanVien.DienThoai = txtDienThoai.Text.Trim();
                nhanVien.Email = txtEmail.Text.Trim();
                nhanVien.TrinhDo = txtTrinhDo.Text.Trim();
                nhanVien.NgayVaoLam = DateNgayVaoLam.Value;
                nhanVien.HeSoLuong = int.Parse(cboHSL.SelectedItem.ToString());
                nhanVien.MucLuong = double.Parse(txtMucLuong.Text);
                nhanVien.PhuCap = double.Parse(txtPhuCap.Text);
                nhanVien.TinhTrang = true;

                NhanVienCtrl ctrl = new NhanVienCtrl();
                if (ctrl.KiemTraTrungMa(nhanVien.MaNhanVien))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ctrl.CheckSDT(nhanVien.DienThoai))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ctrl.CheckCMND(nhanVien.SoCMND))
                {
                    MessageBox.Show("Số CMND đã tồn tại. Vui lòng nhập số khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ctrl.Them(nhanVien);

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadphikn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = txtMaNV.Text;
                nhanVien.TenNhanVien = txtTenNV.Text;
                nhanVien.MaChucVu = cboCV.SelectedValue.ToString();
                nhanVien.MaPhongBan = cboPB.SelectedValue.ToString();
                if (checkBox1.Checked == true)
                {
                    nhanVien.GioiTinh = "Nam";
                }
                else
                {
                    nhanVien.GioiTinh = "Nữ";
                }
                nhanVien.NgaySinh = DateNgaySinh.Value;
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.SoCMND = txtSoCMND.Text;
                nhanVien.DienThoai = txtDienThoai.Text;
                nhanVien.Email = txtEmail.Text;
                nhanVien.TrinhDo = txtTrinhDo.Text;
                nhanVien.NgayVaoLam = DateNgayVaoLam.Value;
                nhanVien.HeSoLuong = int.Parse(cboHSL.SelectedItem.ToString());
                nhanVien.MucLuong = double.Parse(txtMucLuong.Text);
                nhanVien.PhuCap = double.Parse(txtPhuCap.Text);
                NhanVienCtrl.Sua(nhanVien);



                Loadphikn();
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTTNV.DataSource = NhanVienCtrl.HienThiTimKiem(txtTenNV.Text);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                NhanVienCtrl.Xoa(txtMaNV.Text);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadphikn();
            } 
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FrmInDSNhanViencs FrmInDSNhanViencs;
        private void btnInDanhSachNV_Click(object sender, EventArgs e)
        {
            if(FrmInDSNhanViencs==null||FrmInDSNhanViencs.IsDisposed==true)
            {
                FrmInDSNhanViencs =new FrmInDSNhanViencs();
                LayMaPhong layMaPhong = new LayMaPhong(FrmInDSNhanViencs.layma);
                layMaPhong(cboPB.SelectedValue.ToString());
                FrmInDSNhanViencs.Show();
            }    
            //frmInDSNS InDSNS = new frmInDSNS();
            //this.Hide();

            //CrystalReport1 report = new CrystalReport1();
            //report.Refresh();
            //InDSNS.crystalReportInDSNS.ReportSource = report;

            //InDSNS.ShowDialog();
            //this.Show();
        }
    }
}
