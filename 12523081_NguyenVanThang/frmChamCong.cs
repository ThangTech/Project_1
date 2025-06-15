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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }
     

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            combox();
            LoadDGV();
        }
        public void combox()
        {
            MaNV.DataSource = NhanVienCtrl.HienThi();
            MaNV.ValueMember = "MaNhanVien";
            MaNV.DisplayMember = "TenNhanVien";
        }
        NhanVienCtrl NhanVienCtrl =new NhanVienCtrl();
        ChamCongCtrl ChamCongCtrl=new ChamCongCtrl();
        ChamCongHangNgayCtrl ChamCongHangNgayCtrl =new ChamCongHangNgayCtrl();
        private NhanVien _nhanVienDuocChonHienTai = null;
        void LoadDGV()
        {
            string thangnam;
            if (dtp.Value.Month < 10) { thangnam = dtp.Value.Year + "0" + dtp.Value.Month; }
            else { thangnam = dtp.Value.Year + "" + dtp.Value.Month; }

            DataTable dtChamCong = ChamCongCtrl.HienThi(int.Parse(thangnam)); // Lấy dữ liệu chấm công

            
            if (!dtChamCong.Columns.Contains("NhanVien_TrangThaiLamViec"))
            {
                dtChamCong.Columns.Add("NhanVien_TrangThaiLamViec", typeof(bool));
            }

            
            foreach (DataRow ccRow in dtChamCong.Rows)
            {
                if (ccRow["MaNhanVien"] != null && ccRow["MaNhanVien"] != DBNull.Value)
                {
                    string maNV = ccRow["MaNhanVien"].ToString();
                    NhanVien nv = NhanVienCtrl.LayNhanVienTheoMa(maNV); 
                    if (nv != null)
                    {
                        ccRow["NhanVien_TrangThaiLamViec"] = nv.TinhTrang; 
                    }
                    else
                    {
                       
                        ccRow["NhanVien_TrangThaiLamViec"] = DBNull.Value;
                    }
                }
            }

            dgvChamCong.DataSource = null; 
            dgvChamCong.DataSource = dtChamCong;

            
            if (dgvChamCong.Columns["NhanVien_TrangThaiLamViec"] != null)
            {
                dgvChamCong.Columns["NhanVien_TrangThaiLamViec"].HeaderText = "NV Còn Làm Việc";
            }

           
            foreach (DataGridViewRow dgvRow in dgvChamCong.Rows)
            {
                if (dgvRow.Cells["NhanVien_TrangThaiLamViec"].Value != null &&
                    dgvRow.Cells["NhanVien_TrangThaiLamViec"].Value != DBNull.Value)
                {
                    bool nvConLamViec = Convert.ToBoolean(dgvRow.Cells["NhanVien_TrangThaiLamViec"].Value);
                    if (!nvConLamViec) 
                    {
                        dgvRow.DefaultCellStyle.BackColor = Color.LightGray; 
                        
                    }
                    else
                    {
                        dgvRow.DefaultCellStyle.BackColor = SystemColors.Window; 
                    }
                }
            }
        }
        private void chkChamCongAll_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkChamCongTatCa.Checked) 
            //{
            //    DateTime layNgayTuDTP = dtp.Value; 
            //    foreach (DataGridViewRow row in dgvChamCong.Rows)
            //    {
            //        DataGridViewComboBoxCell tingTrang = (DataGridViewComboBoxCell)row.Cells["clnTinhTrang"];
            //        if (tingTrang != null )
            //        {
            //            tingTrang.Value = "Đi làm"; 
            //        }
            //        row.Cells["clnNgayChamCong"].Value = layNgayTuDTP.ToString("yyyy-MM-dd"); 
            //    }
            //}
            //else
            //{
            //    foreach (DataGridViewRow row in dgvChamCong.Rows)
            //    {
            //          row.Cells["clnTinhTrang"].Value = "Chưa xác định";
            //          row.Cells["clnNgayChamCong"].Value = DBNull.Value;
            //    }
            //}
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            //string thangnam;
            //if (dtp.Value.Month < 10)
            //{
            //    thangnam = dtp.Value.Year + "0" + dtp.Value.Month;
            //}
            //else
            //{
            //    thangnam = dtp.Value.Year + "" + dtp.Value.Month;
            //}
            //dgvChamCong.DataSource = ChamCongCtrl.HienThi(int.Parse(thangnam));
            LoadDGV();
            //}
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string thangnam;
            if (dtp.Value.Month < 10) { thangnam = dtp.Value.Year + "0" + dtp.Value.Month; }
            else { thangnam = dtp.Value.Year + "" + dtp.Value.Month; }

            try
            {
                if (chkChamCongTatCa.Checked == true) 
                {
                    int successCount = 0;
                    DataTable dsNhanVienDangLam = NhanVienCtrl.LayDSChamCong(); 

                    if (dsNhanVienDangLam.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có nhân viên nào (đang làm việc) để thực hiện chấm công tất cả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (DataRow dataRow in dsNhanVienDangLam.Rows)
                    {
                        foreach (DataRow data in ChamCongHangNgayCtrl.HienThiTimKiemTongCong(dataRow["MaNhanVien"].ToString(), int.Parse(thangnam)).Rows)
                        {
                            ChamCong chamCong = new ChamCong();
                            chamCong.MaNhanVien = dataRow["MaNhanVien"].ToString();
                            chamCong.TongNgayCong = data["TongCong"].ToString();
                            chamCong.NgayCham = dtp.Value;


                            chamCong.TinhTrang = "Đã tính số ngày";

                            chamCong.ThangNam = int.Parse(thangnam);




                            if (ChamCongCtrl.HienThiTimKiem(chamCong.MaNhanVien, chamCong.ThangNam).Rows.Count == 0)
                            {
                                ChamCongCtrl.Them(chamCong);
                            }
                            else
                            {

                                ChamCongCtrl.Sua(chamCong);
                            }
                        }
                        successCount++;
                    }
                    if (successCount > 0)
                        MessageBox.Show($"Đã cập nhật chấm công cho {successCount} nhân viên đang làm việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else 
                {
                    if (_nhanVienDuocChonHienTai == null)
                    {
                        if (!string.IsNullOrEmpty(labelMaNV.Text))
                        {
                            _nhanVienDuocChonHienTai = NhanVienCtrl.LayNhanVienTheoMa(labelMaNV.Text);
                        }
                        if (_nhanVienDuocChonHienTai == null)
                        {
                            MessageBox.Show("Vui lòng chọn nhân viên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                   
                    if (!_nhanVienDuocChonHienTai.TinhTrang) 
                    {
                        MessageBox.Show($"Nhân viên '{_nhanVienDuocChonHienTai.TenNhanVien}' (Trạng thái: False) đã nghỉ việc. Không thể cập nhật chấm công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    
                    ChamCong chamCong = new ChamCong();
                    chamCong.MaNhanVien = _nhanVienDuocChonHienTai.MaNhanVien;

                   
                    if (string.IsNullOrWhiteSpace(textBoxNgayCong.Text) || !int.TryParse(textBoxNgayCong.Text, out _))
                    {
                        MessageBox.Show("Tổng ngày công không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNgayCong.Focus();
                        return;
                    }
                    chamCong.TongNgayCong = textBoxNgayCong.Text;
                    chamCong.NgayCham = dtp.Value; 

                    chamCong.TinhTrang = "Cập nhật lại số ngày";

                    chamCong.ThangNam = int.Parse(thangnam);

                    if (ChamCongCtrl.HienThiTimKiem(chamCong.MaNhanVien, chamCong.ThangNam).Rows.Count == 0)
                    {
                        ChamCongCtrl.Them(chamCong);
                    }
                    else
                    {
                        ChamCongCtrl.Sua(chamCong);
                    }
                    MessageBox.Show("Cập nhật chấm công cho nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật chấm công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string thangnam;
            //if(dtp.Value.Month<10)
            //{
            //    thangnam=dtp.Value.Year+"0"+dtp.Value.Month;
            //}
            //else
            //{
            //    thangnam=dtp.Value.Year+""+dtp.Value.Month;
            //}

            //try
            //{
            //    if (chkChamCongTatCa.Checked == true)
            //    {
            //        foreach (DataRow dataRow in NhanVienCtrl.LayDSChamCong().Rows)
            //        {
            //            ChamCong chamCong = new ChamCong();
            //            chamCong.MaNhanVien = dataRow[0].ToString();
            //            chamCong.TongNgayCong = "26";
            //            chamCong.NgayCham = dtp.Value;
            //            chamCong.TinhTrang = "false";
            //            chamCong.ThangNam = int.Parse(thangnam);
            //            ChamCongCtrl.Them(chamCong);
            //        }
            //    }
            //    else
            //    {

            //        ChamCong chamCong = new ChamCong();
            //        chamCong.MaNhanVien = labelMaNV.Text;
            //        chamCong.TongNgayCong = textBoxNgayCong.Text;
            //        chamCong.NgayCham = dtp.Value;
            //        chamCong.TinhTrang = "false";
            //        chamCong.ThangNam = int.Parse(thangnam);
            //        if (ChamCongCtrl.HienThiTimKiem(labelMaNV.Text, int.Parse(thangnam)).Rows.Count == 0)
            //        {
            //            ChamCongCtrl.Them(chamCong);
            //        }
            //        else
            //        {
            //            ChamCongCtrl.Sua(chamCong);


            //        }
            //        LoadDGV();
            //        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi cập nhật chấm công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvChamCong.DataSource = ChamCongCtrl.HienThiTimKiemNV(labelMaNV.Text);
                MessageBox.Show("Tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void textBoxNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                e.Handled = true; 
                frmBangNV frmBangNV = new frmBangNV();
                layma layma = new layma(frmBangNV.manv);
                layma(textBoxNhanVien.Text);
                frmBangNV.DelegateMaNV += FrmBangNV_DelegateMaNV;
                frmBangNV.ShowDialog();
                return;
            }    
        }

        private void FrmBangNV_DelegateMaNV(object sender, DelegateCtrl e)
        {
            textBoxNhanVien.Text = e.tennv;
            labelMaNV.Text = e.manv;

            _nhanVienDuocChonHienTai = NhanVienCtrl.LayNhanVienTheoMa(e.manv);

            if (_nhanVienDuocChonHienTai != null)
            {
                
                if (!_nhanVienDuocChonHienTai.TinhTrang) 
                {
                    MessageBox.Show($"Nhân viên '{_nhanVienDuocChonHienTai.TenNhanVien}' (Trạng thái: False) đã nghỉ việc. Không thể thực hiện chấm công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCapNhat.Enabled = false;
                    
                    textBoxNgayCong.Enabled = false;
                }
                else
                {
                    btnCapNhat.Enabled = true;
                    textBoxNgayCong.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên đã chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
                textBoxNgayCong.Enabled = false;
                _nhanVienDuocChonHienTai = null; 
            }
            //textBoxNhanVien.Text = e.tennv;
            //labelMaNV.Text = e.manv;
            //throw new NotImplementedException();
        }

        private void textBoxNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
