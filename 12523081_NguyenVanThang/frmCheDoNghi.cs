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

namespace _12523081_NguyenVanThang
{
    public partial class frmCheDoNghi : Form
    {
        public frmCheDoNghi()
        {
            InitializeComponent();
        }
        CheDoNghiCtrl CheDoNghiCtrl = new CheDoNghiCtrl();
        private void frmCheDoNghi_Load(object sender, EventArgs e)
        {
            LoadDGV();
            cboLoaiNghi.Items.Clear();
            cboLoaiNghi.Items.Add("Nghỉ phép");
            cboLoaiNghi.Items.Add("Nghỉ lễ");
            cboLoaiNghi.Items.Add("Nghỉ bệnh");
            cboLoaiNghi.Items.Add("Nghỉ thai sản");
        }
        void LoadDGV()
        {
            dgvCheDoNghi.DataSource = CheDoNghiCtrl.HienThi();
        }

        private void dgvCheDoNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgvCheDoNghi.Rows[i].Cells[0].Value != null)
            {
                txtMaNghi.Text = dgvCheDoNghi[0, i].Value.ToString();
                txtMaNV.Text = dgvCheDoNghi[1, i].Value.ToString();
                cboLoaiNghi.Text = dgvCheDoNghi[2, i].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(dgvCheDoNghi[3, i].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(dgvCheDoNghi[4, i].Value);
                txtLyDo.Text = dgvCheDoNghi[5, i].Value.ToString();
            }
        }

      

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CheDoNghiCtrl ctrl = new CheDoNghiCtrl();

                if (ctrl.KiemTraTrungMa(txtMaNghi.Text))
                {
                    MessageBox.Show("Mã nghỉ đã tồn tại, vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayBatDau = dtpNgayBatDau.Value;
                DateTime ngayKetThuc = dtpNgayKetThuc.Value;

                if (ngayBatDau > ngayKetThuc)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soNgayNghi = (ngayKetThuc - ngayBatDau).Days + 1;
                string loaiNghi = cboLoaiNghi.SelectedItem.ToString();

                bool hopLe = false;
                switch (loaiNghi)
                {
                    case "Nghỉ phép":
                        hopLe = soNgayNghi >= 1 && soNgayNghi <= 12;
                        break;
                    case "Nghỉ lễ":
                        hopLe = soNgayNghi >= 1 && soNgayNghi <= 5;
                        break;
                    case "Nghỉ bệnh":
                        hopLe = soNgayNghi >= 1 && soNgayNghi <= 30;
                        break;
                    case "Nghỉ thai sản":
                        hopLe = soNgayNghi >= 30 && soNgayNghi <= 180;
                        break;
                }
                if (!hopLe)
                {
                    MessageBox.Show($"Số ngày nghỉ không hợp lệ cho loại \"{loaiNghi}\". Vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CheDoNghi cheDoNghi = new CheDoNghi();
                cheDoNghi.MaNghi = txtMaNghi.Text;
                cheDoNghi.MaNhanVien = labelMaNV.Text;
                cheDoNghi.LoaiNghi = loaiNghi;
                cheDoNghi.NgayBatDau = ngayBatDau;
                cheDoNghi.NgayKetThuc = ngayKetThuc;
                cheDoNghi.LyDo = txtLyDo.Text;

                ctrl.Them(cheDoNghi);
                LoadDGV();

                MessageBox.Show("Thêm chế độ nghỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CheDoNghi cheDoNghi = new CheDoNghi();
                cheDoNghi.MaNghi = txtMaNghi.Text;
                cheDoNghi.MaNhanVien = labelMaNV.Text;
                cheDoNghi.LoaiNghi = cboLoaiNghi.SelectedItem.ToString();
                cheDoNghi.NgayBatDau = dtpNgayBatDau.Value;
                cheDoNghi.NgayKetThuc = dtpNgayKetThuc.Value;
                cheDoNghi.LyDo = txtLyDo.Text;

                CheDoNghiCtrl.Sua(cheDoNghi);
                MessageBox.Show("Cập nhật chế độ nghỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    CheDoNghiCtrl.Xoa(txtMaNghi.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDGV();
                }

               
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
                dgvCheDoNghi.DataSource= CheDoNghiCtrl.HienThiTimKiem(labelMaNV.Text);
                labelMaNV.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
    
    }
}
