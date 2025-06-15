using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _12523081_NguyenVanThang.ThongKe;
namespace _12523081_NguyenVanThang
{
    public partial class frmMenuQuanLy : Form
    {
        private string _username;
        
        public frmMenuQuanLy(string username)
        {
            InitializeComponent();
            _username = username;
        } 

        private void mnuHeThong_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát về màn hình đăng nhập không?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
               this.Close();
            }
        }
        frmPhongBan frmPhongBan;
        private void mnuQuanLy_PhongBan_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmPhongBan == null || frmPhongBan.IsDisposed)
            {
                frmPhongBan = new frmPhongBan();
                frmPhongBan.MdiParent = frmMenuQuanLy.ActiveForm;
                frmPhongBan.Show();

            }
            else
            {
                frmPhongBan.Activate();
            }
        }
        frmNhanVien frmNhanVien;
        private void mnuQuanLy_NhanVien_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (frmNhanVien == null || frmNhanVien.IsDisposed)
            {
                frmNhanVien = new frmNhanVien();
                frmNhanVien.MdiParent = frmMenuQuanLy.ActiveForm;
                frmNhanVien.Show();
            }
            else
            {
                frmNhanVien.Activate();
            }
        }
        frmChucVu frmChucVu;
        private void mnuQuanLy_ChucVu_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmChucVu == null || frmChucVu.IsDisposed)
            {
                frmChucVu = new frmChucVu();
                frmChucVu.MdiParent = frmMenuQuanLy.ActiveForm;
                frmChucVu.Show();

            }
            else
            {
                frmChucVu.Activate();
            }
        }
        frmBaoHiem frmBaoHiem;
        private void mnuBaoHiem_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmBaoHiem == null || frmBaoHiem.IsDisposed)
            {
                frmBaoHiem = new frmBaoHiem();
                frmBaoHiem.MdiParent = frmMenuQuanLy.ActiveForm;
                frmBaoHiem.Show();

            }
            else
            {
                frmBaoHiem.Activate();
            }
        }
        frmChamCong frmChamCong;
        private void mnuChamCong_Click(object sender, EventArgs e)
        {
          
        }
        frmBangLuong frmBangLuong;
        private void mnuBangLuong_Luong_Click(object sender, EventArgs e)
        {
            if (frmBangLuong == null || frmBangLuong.IsDisposed)
            {
                frmBangLuong = new frmBangLuong();
                frmBangLuong.MdiParent = frmMenuQuanLy.ActiveForm;
                frmBangLuong.Show();

            }
            else
            {
                frmBangLuong.Activate();
            }
        }
        frmThuongPhat frmThuongPhat;
        private void mnuBangLuong_ThuongPhat_Click(object sender, EventArgs e)
        {
            if (frmThuongPhat == null || frmThuongPhat.IsDisposed)
            {
                frmThuongPhat = new frmThuongPhat();
                frmThuongPhat.MdiParent = frmMenuQuanLy.ActiveForm;
                frmThuongPhat.Show();

            }
            else
            {
                frmThuongPhat.Activate();
            }
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            //frmTimKiem frmTK = new frmTimKiem();    
            //this.Hide();
            //frmTK.ShowDialog();
            //this.Show();
        }
        frmCheDoNghi frmCheDoNghi;
        private void mnuCheDoNghi_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmCheDoNghi == null || frmCheDoNghi.IsDisposed)
            {
                frmCheDoNghi = new frmCheDoNghi();
                frmCheDoNghi.MdiParent = frmMenuQuanLy.ActiveForm;
                frmCheDoNghi.Show();

            }
            else
            {
                frmCheDoNghi.Activate();
            }
        }
        private void mnuHeThong_ThongTin_Click(object sender, EventArgs e)
        {
            string thongTin = "Hệ thống Quản lý Nhân sự\n" +
                      "Phiên bản: Visual studio 2022\n" +                      
                      "Tác giả: Nguyễn Văn Thắng\n" +
                      "Liên hệ hỗ trợ:\n" +
                      "Email: thangtoppo@gmail.com\n" +
                      "Số điện thoại: 0329649661";

            MessageBox.Show(thongTin, "Thông tin ứng dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            string message = "Hướng dẫn sử dụng hệ thống:\n\n" +
              "1. Hệ thống:\n" +
              "   - Hiển thị thông tin.\n" +
              "   - Ấn thoát để thoát chương trình.\n\n" +
              "2. Quản lý:\n" +
              "   - Thêm, sửa, xóa và tìm kiếm thông tin nhân viên.\n" +
              "   - Quản lý phòng ban và chức vụ.\n\n" +
              "3. Chấm công:\n" +
              "   - Ghi nhận số ngày làm việc của nhân viên.\n\n" +
              "4. Bảng lương:\n" +
              "   - Tính lương nhân viên dựa trên hệ số lương, ngày công, và các khoản thưởng phạt.\n" +
              "   - In báo cáo bảng lương.\n\n" +
              "5. Bảo hiểm:\n" +
              "   - Quản lý thông tin bảo hiểm xã hội, y tế, thân thể của nhân viên.\n" +
              "   - Theo dõi ngày cấp và ngày hết hạn bảo hiểm.\n\n" +
              "6. Chế độ nghỉ:\n" +
              "   - Quản lý các loại nghỉ của nhân viên như nghỉ phép, nghỉ lễ, nghỉ bệnh và nghỉ thai sản.\n" +
              "   - Theo dõi ngày bắt đầu và ngày kết thúc kỳ nghỉ.\n" +
              "   - Thêm, sửa, xóa thông tin chế độ nghỉ.\n\n" +
              "7. Tìm kiếm:\n" +
              "   - Tìm kiếm thông tin nhân sự, bảng lương, bảo hiểm, phòng ban hoặc chức vụ, và chế độ nghỉ nhanh chóng.\n\n" +
              "Liên hệ hỗ trợ:\n" +
              "   - Email: thuantoppo@gmail.com\n" +
              "   - Số điện thoại: 0329649661";
            MessageBox.Show(message, "Hỗ trợ người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        FrmThongKeBangLuong FrmThongKeBangLuong;

        private void thốngKêNgàyCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (FrmThongKeBangLuong == null || FrmThongKeBangLuong.IsDisposed)
            {
                FrmThongKeBangLuong = new FrmThongKeBangLuong();
                FrmThongKeBangLuong.MdiParent = frmMenuQuanLy.ActiveForm;
                FrmThongKeBangLuong.Show();

            }
            else
            {
                FrmThongKeBangLuong.Activate();
            }
        }
       
        private void lọcDanhSáchChếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenuQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void chấmCôngThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmChamCong == null || frmChamCong.IsDisposed)
            {
                frmChamCong = new frmChamCong();
                frmChamCong.MdiParent = frmMenuQuanLy.ActiveForm;
                frmChamCong.Show();

            }
            else
            {
                frmChamCong.Activate();
            }
        }
        frmChamTungNgay frmChamTungNgay;
        private void chấmCôngHàngNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_username.ToLower() != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (frmChamTungNgay == null || frmChamTungNgay.IsDisposed)
            {
                frmChamTungNgay = new frmChamTungNgay();
                frmChamTungNgay.MdiParent = frmMenuQuanLy.ActiveForm;
                frmChamTungNgay.Show();

            }
            else
            {
                frmChamTungNgay.Activate();
            }
        }
    }
}
