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
    public partial class frmBangLuong : Form
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }
        NhanVienCtrl NhanVienCtrl = new NhanVienCtrl();
        ChamCongCtrl ChamCongCtrl = new ChamCongCtrl();
        BangLuongCtrl BangLuongCtrl=new BangLuongCtrl();
        PhongBanCtrl PhongBanCtrl = new PhongBanCtrl();
        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            Combo();
            LoadDGV();
            LoadHSL();
        }
        public void Combo()
        {
            MaNhanVien.DataSource = NhanVienCtrl.HienThi();
            MaNhanVien.ValueMember = "MaNhanVien";
            MaNhanVien.DisplayMember = "TenNhanVien";
            cboPB.DataSource = PhongBanCtrl.HienThi();
            cboPB.ValueMember = "MaPhongBan";
            cboPB.DisplayMember = "TenPhongBan";
        }
        public void LoadDGV()

        {
            string thangnam;
            if (dateTimePicker1.Value.Month < 10)
            {
                thangnam = dateTimePicker1.Value.Year + "0" + dateTimePicker1.Value.Month;
            }
            else
            {
                thangnam = dateTimePicker1.Value.Year + "" + dateTimePicker1.Value.Month;
            }
            dgvBangLuong.DataSource = BangLuongCtrl.HienThi(int.Parse(thangnam));
           
        }
        void LoadHSL()
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load hệ số lương: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgvBangLuong.Rows[i].Cells[0].Value != null)
            {
                txtMaLuong.Text = dgvBangLuong[0, i].Value.ToString();
                txtMaNV.Text = dgvBangLuong[1, i].Value.ToString();
                txtLuongCB.Text = dgvBangLuong[2, i].Value.ToString();
                cboHSL.Text = dgvBangLuong[3, i].Value.ToString();
                txtSoNgayLam.Text = dgvBangLuong[4, i].Value.ToString();
                txtPhuCap.Text = dgvBangLuong[5, i].Value.ToString();               
            }
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProviderNhapSo.SetError(txtLuongCB,"Vui lòng nhập số!");
            }
            else
                this.errorProviderNhapSo.Clear();
        }

        private void txtSoNgayLam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProviderNhapSo.SetError(txtSoNgayLam, "Vui lòng nhập số!");
            }
            else
                this.errorProviderNhapSo.Clear();
        }


        private void txtPhuCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.errorProviderNhapSo.SetError(txtPhuCap, "Vui lòng nhập số!");
            }
            else
                this.errorProviderNhapSo.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private decimal TinhTongLuong(string maNhanVien, decimal luongCoBan, int heSoLuong, int soNgayLam, decimal phuCap)
        //{
        //    //string sT = $"Select isnull(sum(SoTien), 0) from KhenThuongPhat where MaNhanVien = '{maNhanVien}' and Loai = N'Khen Thưởng'";
        //    //decimal tongTienThuong = Convert.ToDecimal(db.TruyVanExcuteScalar(sT));

        //    //string sP = $"Select isnull(sum(SoTien), 0) from KhenThuongPhat where MaNhanVien = '{maNhanVien}' and Loai = N'Phạt'";
        //    //decimal tongTienPhat = Convert.ToDecimal(db.TruyVanExcuteScalar(sP));

        //    //decimal tongLuong = ((luongCoBan * heSoLuong / 26) * soNgayLam) + tongTienThuong - tongTienPhat + phuCap;
        //    //return Math.Round(tongLuong, 0);
        //}

        private void btnTinhTongLuong_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBangLuong.Rows)
            {
                if (row.Cells["clnLuongCB"].Value == null ||
                    row.Cells["clnHeSoLuong"].Value == null ||
                    row.Cells["clnSoNgayLam"].Value == null ||
                    row.Cells["clnPhuCap"].Value == null ||
                    row.Cells["clnMaNV"].Value == null)
                {
                    continue;
                }
                string maLuong = row.Cells["clnMaLuong"].Value.ToString();
                decimal luongCoBan = Convert.ToDecimal(row.Cells["clnLuongCB"].Value);
                int heSoLuong = Convert.ToInt32(row.Cells["clnHeSoLuong"].Value);
                int soNgayLam = Convert.ToInt32(row.Cells["clnSoNgayLam"].Value);
                decimal phuCap = Convert.ToDecimal(row.Cells["clnPhuCap"].Value);
                string maNhanVien = row.Cells["clnMaNV"].Value.ToString();
              
                //decimal tongLuong = TinhTongLuong(maNhanVien, luongCoBan, heSoLuong, soNgayLam, phuCap);
                //row.Cells["clnTongLuong"].Value = tongLuong;

                //string sqlUpdate = "Update BangLuong Set TongLuong = " + tongLuong + " Where MaLuong = '" + maLuong + "'";
                //db.TruyVanExcuteNonQuery(sqlUpdate);
            }
            MessageBox.Show("Đã tính tổng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool KiemTraNhapThongTin()
        {
            if (txtMaLuong.Text == "" || txtMaNV.Text == "" || txtLuongCB.Text == "" || cboHSL.Text == "")

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string thangnam;
                if (dateTimePicker1.Value.Month < 10)
                {
                    thangnam = dateTimePicker1.Value.Year + "0" + dateTimePicker1.Value.Month;
                }
                else {
                    thangnam = dateTimePicker1.Value.Year + "" + dateTimePicker1.Value.Month;
                }
                foreach (DataRow dataRow in NhanVienCtrl.LayDSChamCong().Rows)
                {
                    foreach (DataRow row in ChamCongCtrl.HienThiTimKiem(dataRow[0].ToString(), int.Parse(thangnam)).Rows)
                    {
                        BangLuong bangLuong = new BangLuong();
                        bangLuong.MaNhanVien = dataRow[0].ToString();
                        bangLuong.ThangNam = int.Parse(thangnam);
                        bangLuong.LuongCoBan = float.Parse(dataRow[12].ToString()) * float.Parse(dataRow[13].ToString());
                        bangLuong.PhuCap = float.Parse(dataRow[14].ToString());
                        bangLuong.KhongCong = (26 - int.Parse(row[2].ToString())) * (float.Parse(dataRow[12].ToString()) * float.Parse(dataRow[13].ToString()) / 26);
                        bangLuong.TongLuong = bangLuong.LuongCoBan + bangLuong.PhuCap - bangLuong.KhongCong;
                        bangLuong.SoNgayLam = int.Parse(row[2].ToString());
                        if (BangLuongCtrl.HienThiTimKiem(dataRow[0].ToString(), int.Parse(thangnam)).Rows.Count == 0)
                        {
                            BangLuongCtrl.Them(bangLuong);
                        }
                        else
                        {

                        }
                    }
                }
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
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
                string thangnam;
                if (dateTimePicker1.Value.Month < 10)
                {
                    thangnam = dateTimePicker1.Value.Year + "0" + dateTimePicker1.Value.Month;
                }
                else
                {
                    thangnam = dateTimePicker1.Value.Year + "" + dateTimePicker1.Value.Month;
                }
                   
                BangLuong bangLuong = new BangLuong();
                bangLuong.MaNhanVien = txtMaNV.Text;
                bangLuong.ThangNam = int.Parse(txtMaLuong.Text);
                bangLuong.LuongCoBan =float.Parse( txtLuongCB.Text);
                bangLuong.PhuCap = float.Parse(txtPhuCap.Text);
                bangLuong.KhongCong = (26 - int.Parse(cboHSL.Text)) * (bangLuong.LuongCoBan / 26);
                bangLuong.TongLuong = bangLuong.LuongCoBan + bangLuong.PhuCap - bangLuong.KhongCong;
                bangLuong.SoNgayLam = int.Parse(cboHSL.Text);
               
               
                    BangLuongCtrl.Sua(bangLuong);
               
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtMaLuong.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //db.KetNoi();
                    //string sqlDelete = $"Delete from BangLuong where MaLuong = '{txtMaLuong.Text}'";
                    //db.TruyVanExcuteNonQuery(sqlDelete);
                    //db.NgatKetNoi();

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //db.KetNoi();
                //string timKiem = txtMaNV.Text.Trim();
                //string sqlSearch = "Select b.MaLuong, b.MaNhanVien, b.LuongCoBan, n.HeSoLuong, b.SoNgayLam, b.PhuCap " +
                //                   "From BangLuong b Inner Join NhanVien n On b.MaNhanVien = n.MaNhanVien " +
                //                   "Where b.MaNhanVien Like '%" + timKiem + "%'";

                //dgvBangLuong.Rows.Clear(); 
                //dr = db.TruyVanExcuteReader(sqlSearch);
                //while (dr.Read())
                //{
                //    dgvBangLuong.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                //}
                //dr.Close();
                //db.NgatKetNoi();

                if (dgvBangLuong.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                //db.KetNoi();
                //string sql = "Select top 5 b.MaNhanVien, n.TenNhanVien, b.TongLuong " +
                //     "from BangLuong b " +
                //     "inner join NhanVien n ON b.MaNhanVien = n.MaNhanVien " +
                //     "order by b.TongLuong Desc";

                //dt = db.Table(sql);

                //string ketQua = "Top 5 nhân sự có lương cao nhất:\n";
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    ketQua += "Mã NV: " + dt.Rows[i]["MaNhanVien"] + ", Tên NV: " + dt.Rows[i]["TenNhanVien"] + ", Tổng Lương: " + dt.Rows[i]["TongLuong"] + "\n";
                //}
                //db.NgatKetNoi();
                //MessageBox.Show(ketQua, "Thống kê lương cao nhất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        FrmInDSBangLuong FrmInDSBangLuong;
        private void btnInBangLuong_Click(object sender, EventArgs e)
        {
            string thangnam;
            if (dateTimePicker1.Value.Month < 10)
            {
                thangnam = dateTimePicker1.Value.Year + "0" + dateTimePicker1.Value.Month;
            }
            else
            {
                thangnam = dateTimePicker1.Value.Year + "" + dateTimePicker1.Value.Month;
            }
            if (FrmInDSBangLuong == null || FrmInDSBangLuong.IsDisposed == true)
            {
                FrmInDSBangLuong = new FrmInDSBangLuong();
                LayMaPhongThangNam layMaphong =new LayMaPhongThangNam(FrmInDSBangLuong.layma);
                layMaphong(cboPB.SelectedValue.ToString(), thangnam);
                FrmInDSBangLuong.Show();
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapnhatTatCa_Click(object sender, EventArgs e)
        {
            try
            {
               
                int soNgayLamMoi = int.Parse(cboHSL.Text);

               
                foreach (DataGridViewRow row in dgvBangLuong.Rows)
                {
                    
                    if (row.IsNewRow) continue;

                    
                    BangLuong bangLuong = new BangLuong();

                    
                    bangLuong.MaNhanVien = row.Cells["MaNhanVien"].Value.ToString();
                    bangLuong.ThangNam = int.Parse(row.Cells["ThangNam"].Value.ToString());
                    bangLuong.LuongCoBan = float.Parse(row.Cells["clnLuongCB"].Value.ToString());
                    bangLuong.PhuCap = float.Parse(row.Cells["PhuCap"].Value.ToString());

                  
                    bangLuong.SoNgayLam = soNgayLamMoi;
                    bangLuong.KhongCong = (26 - bangLuong.SoNgayLam) * (bangLuong.LuongCoBan / 26);
                    if (bangLuong.KhongCong < 0) bangLuong.KhongCong = 0; 
                    bangLuong.TongLuong = bangLuong.LuongCoBan + bangLuong.PhuCap - bangLuong.KhongCong;

                   
                    BangLuongCtrl.Sua(bangLuong);
                }

                
                MessageBox.Show("Cập nhật tất cả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
