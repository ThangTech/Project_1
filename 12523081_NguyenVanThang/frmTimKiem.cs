using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        DataTable dt;
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            cboLoaiTimKiem.Items.Clear();
            cboLoaiTimKiem.Items.Add("Nhân viên");
            cboLoaiTimKiem.Items.Add("Bảng lương");
            cboLoaiTimKiem.Items.Add("Bảo hiểm");
            cboLoaiTimKiem.Items.Add("Phòng ban");
            cboLoaiTimKiem.Items.Add("Chức vụ");            
            cboLoaiTimKiem.SelectedIndex = 0;
        }
        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string timKiem = txtTimKiem.Text.Trim();
                string sqlSearch = "";
                string DanhMuc = cboLoaiTimKiem.SelectedItem.ToString();
                db.KetNoi();

                if (DanhMuc == "Nhân viên")
                {
                    sqlSearch = "Select MaNhanVien, TenNhanVien, MaPhongBan, MaChucVu From NhanVien " +
                                "Where MaNhanVien Like '%" + timKiem + "%' or TenNhanVien Like N'%" + timKiem + "%'";
                }             
                else if (DanhMuc == "Bảng lương")
                {
                    sqlSearch = "Select MaLuong, MaNhanVien, LuongCoBan, SoNgayLam, TongLuong From BangLuong " +
                                "Where MaLuong Like '%" + timKiem + "%' or MaNhanVien Like '%" + timKiem + "%'";
                }
                else if (DanhMuc == "Phòng ban")
                {
                    sqlSearch = "Select MaPhongBan, TenPhongBan From PhongBan " +
                                "Where MaPhongBan Like '%" + timKiem + "%' or TenPhongBan Like N'%" + timKiem + "%'";
                }
                else if (DanhMuc == "Chức vụ")
                {
                    sqlSearch = "Select MaChucVu, TenChucVu From ChucVu " +
                                "Where MaChucVu Like '%" + timKiem + "%' or TenChucVu Like N'%" + timKiem + "%'";
                }
                else if (DanhMuc == "Bảo hiểm")
                {
                    sqlSearch = "Select MaBaoHiem, MaNhanVien, LoaiBaoHiem, NgayCap, NgayHetHan From BaoHiem " +
                                "Where MaBaoHiem Like '%" + timKiem + "%' OR LoaiBaoHiem Like N'%" + timKiem + "%' " +
                                "OR MaNhanVien Like '%" + timKiem + "%'";
                }

                dt = db.Table(sqlSearch);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvTimKiem.DataSource = null; 
                    dgvTimKiem.DataSource = dt;  
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvTimKiem.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.NgatKetNoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
