using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCtrl;
using DataLayer;
using _12523081_NguyenVanThang.Report;

namespace _12523081_NguyenVanThang
{
    public partial class frmBaoHiem : Form
    {
        public frmBaoHiem()
        {
            InitializeComponent();
        }
     
        BaoHiemCtrl BaoHiemCtrl = new BaoHiemCtrl();
        NhanVienCtrl NhanVienCtrl=new NhanVienCtrl();
        private void frmBaoHiem_Load(object sender, EventArgs e)
        {
            Combo();
            LoadDGV();
            loadLoaiBaoHiem();
        }
        void LoadDGV()
        {
            dgvBHNV.DataSource = BaoHiemCtrl.HienThi();
        }
        void Combo()
        {
            MaNhanVien.DataSource=NhanVienCtrl.HienThi();
            MaNhanVien.ValueMember = "MaNhanVien";
            MaNhanVien.DisplayMember = "TenNhanVien";
           
        }
        void loadLoaiBaoHiem()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load Loại Bảo Hiểm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBHNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgvBHNV.Rows[i].Cells[0].Value != null)
            {
                txtMaBH.Text = dgvBHNV[0, i].Value.ToString();
                labelMaNV.Text = dgvBHNV[1, i].Value.ToString();
                cboLoaiBH.Text = dgvBHNV[2, i].Value.ToString();
                dateNgayCap.Value = Convert.ToDateTime(dgvBHNV[3, i].Value);
                dateNgayHetHan.Value = Convert.ToDateTime(dgvBHNV[4, i].Value);
                txtNoiCap.Text = dgvBHNV[5, i].Value.ToString();
            }
        }
        private bool KiemTraThongTinBaoHiem(bool kiemTraMaBH)
        {
           
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BaoHiemCtrl ctrl = new BaoHiemCtrl();

                
                if (ctrl.KiemTraTrungMa(txtMaBH.Text))
                {
                    MessageBox.Show("Mã bảo hiểm đã tồn tại, vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if ((dateNgayHetHan.Value - dateNgayCap.Value).TotalDays < 180)
                {
                    MessageBox.Show("Thời hạn bảo hiểm phải ít nhất 6 tháng kể từ ngày cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                BaoHiem baoHiem = new BaoHiem();
                baoHiem.MaBaoHiem = txtMaBH.Text;
                baoHiem.MaNhanVien = labelMaNV.Text;
                baoHiem.LoaiBaoHiem = cboLoaiBH.SelectedItem.ToString();
                baoHiem.NgayCap = dateNgayCap.Value;
                baoHiem.NgayHetHan = dateNgayHetHan.Value;
                baoHiem.NoiCap = txtNoiCap.Text;

                
                ctrl.Them(baoHiem);

                
                LoadDGV();
                MessageBox.Show("Thêm bảo hiểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                BaoHiem baoHiem = new BaoHiem();
                baoHiem.MaBaoHiem = txtMaBH.Text;
                baoHiem.MaNhanVien = labelMaNV.Text;
                baoHiem.LoaiBaoHiem = cboLoaiBH.SelectedItem.ToString();
                baoHiem.NgayCap = dateNgayCap.Value;
                baoHiem.NgayHetHan = dateNgayHetHan.Value;
                baoHiem.NoiCap = txtNoiCap.Text;

                BaoHiemCtrl.Sua(baoHiem);

                MessageBox.Show("Cập nhật bảo hiểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BaoHiemCtrl.Xoa(txtMaBH.Text);
                MessageBox.Show("Xóa bảo hiểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        FormInDSBaoHiem FormInDSBaoHiem;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnInDSBH_Click(object sender, EventArgs e)
        {
            if (FormInDSBaoHiem == null || FormInDSBaoHiem.IsDisposed == true)
            {
                FormInDSBaoHiem= new FormInDSBaoHiem();
                
                FormInDSBaoHiem.Show();
            }

            //frmInBaoHiem frmInBaoHiem = new frmInBaoHiem();
            //this.Hide();

            //CrystalReportBaoHiem report = new CrystalReportBaoHiem();
            //report.Refresh(); 
            //frmInBaoHiem.crystalReportInBH.ReportSource = report; 

            //frmInBaoHiem.ShowDialog();
            //this.Show();
        }

        private void txtMaNV_MouseClick(object sender, MouseEventArgs e)
        {
            frmBangNV frmBangNV = new frmBangNV();
            layma layma = new layma(frmBangNV.manv);
            layma(txtMaNV.Text);
            frmBangNV.DelegateMaNV += FrmBangNV_DelegateMaNV; ;
            frmBangNV.ShowDialog();
        }

        private void FrmBangNV_DelegateMaNV(object sender, DelegateCtrl e)
        {
            labelMaNV.Text = e.manv;
            txtMaNV.Text = e.tennv;
           // throw new NotImplementedException();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                frmBangNV frmBangNV = new frmBangNV();
                layma layma = new layma(frmBangNV.manv);
                layma(txtMaNV.Text);
                frmBangNV.DelegateMaNV += FrmBangNV_DelegateMaNV; ;
                frmBangNV.ShowDialog();
            }
                
        }
    }
}
