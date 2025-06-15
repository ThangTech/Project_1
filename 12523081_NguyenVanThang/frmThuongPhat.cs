using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using DataCtrl;
using DataLayer;
using _12523081_NguyenVanThang.Report;
namespace _12523081_NguyenVanThang
{
    public partial class frmThuongPhat : Form
    {
        public frmThuongPhat()
        {
            InitializeComponent();
        }
        //DBHelper dB = new DBHelper();
        //SqlCommand cmd;
        //SqlDataAdapter da;
        //DataTable dt;
        KhenThuongPhatCtrl KhenThuongPhatCtrl = new KhenThuongPhatCtrl();
        NhanVienCtrl NhanVienCtrl = new NhanVienCtrl();
        private void frmThuongPhat_Load(object sender, EventArgs e)
        {
            Combobox();
            LoadDGV();
        }
        public void LoadDGV(string maPhongBan = null)
        {
            string thangnam;
            if(dtpNgayTao.Value.Month<10)
            {
                thangnam = dtpNgayTao.Value.Year + "0" + dtpNgayTao.Value.Month;
            }    
            else
            {
                thangnam = dtpNgayTao.Value.Year + "" + dtpNgayTao.Value.Month;
            }    
            try
            {
              dgvThuongPhat.DataSource=KhenThuongPhatCtrl.HienThiTimKiem(thangnam);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổ dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Combobox()
        {
            MaNhanVien.DataSource = NhanVienCtrl.HienThi();
            MaNhanVien.ValueMember = "MaNhanVien";
            MaNhanVien.DisplayMember = "TenNhanVien";
        }
        private void dgvThuongPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaKTP.Text = dgvThuongPhat[0, i].Value.ToString();
                labelMaNV.Text = dgvThuongPhat[1, i].Value.ToString();
                string loai = dgvThuongPhat[2, i].Value.ToString();
                if (loai == "Khen Thưởng")
                {
                    checkBox1.Checked = true;
                }
                else if (loai == "Phạt")
                {
                    checkBox1.Checked = false;
                }
                txtLyDo.Text = dgvThuongPhat[3, i].Value.ToString();
                txtTien.Text = dgvThuongPhat[4, i].Value.ToString();
                if (DateTime.TryParse(dgvThuongPhat[5, i].Value.ToString(), out DateTime ngayTao))
                {
                    dtpNgayTao.Value = ngayTao;
                }
                else
                {
                    dtpNgayTao.Value = DateTime.Now;
                }
            }
        }
        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.errorProviderNhapSo.SetError(txtTien,"Vui lòng nhập số");
            }
            else this.errorProviderNhapSo.Clear();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
                 KhenThuongPhat khenThuongPhat =new KhenThuongPhat();
             khenThuongPhat.MaKTP = txtMaKTP.Text;
             khenThuongPhat.MaNhanVien = labelMaNV.Text;
            if(checkBox1.Checked) 
                {
                     khenThuongPhat.Loai =  "Khen";
                }
                else
                {
                    khenThuongPhat.Loai = "Phạt";
                }
                    khenThuongPhat.LyDo = txtLyDo.Text;
            khenThuongPhat.SoTien =double.Parse( txtTien.Text);
            string thangnam;
            if(dtpNgayTao.Value.Month<10)
            {
                thangnam=dtpNgayTao.Value.Year+"0"+dtpNgayTao.Value.Month;
            }   
            else
            {
                thangnam = dtpNgayTao.Value.Year + "" + dtpNgayTao.Value.Month;
            }
            khenThuongPhat.ThangNam = int.Parse(thangnam);

            try
            {
                KhenThuongPhatCtrl ctrl = new KhenThuongPhatCtrl();

                
                if (ctrl.KiemTraTrungMa(khenThuongPhat.MaKTP))
                {
                    MessageBox.Show("Mã khen thưởng/phạt đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                ctrl.Them(khenThuongPhat);
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhenThuongPhat khenThuongPhat = new KhenThuongPhat();
            khenThuongPhat.MaKTP = txtMaKTP.Text;
            //string maNhanVien = labelMaNV.Text;
            khenThuongPhat.MaNhanVien = labelMaNV.Text;

            if (checkBox1.Checked)
            {
                khenThuongPhat.Loai = "Khen";
            }
            else
            {
                khenThuongPhat.Loai = "Phạt";
            }
            string lyDo = txtLyDo.Text;
            khenThuongPhat.SoTien = double.Parse(txtTien.Text);
            string thangnam;
            if (dtpNgayTao.Value.Month < 10)
            {
                thangnam = dtpNgayTao.Value.Year + "0" + dtpNgayTao.Value.Month;
            }
            else
            {
                thangnam = dtpNgayTao.Value.Year + "" + dtpNgayTao.Value.Month;
            }
            khenThuongPhat.ThangNam = int.Parse(thangnam);
            
            KhenThuongPhatCtrl.Sua(khenThuongPhat);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDGV();
          
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
               
                DialogResult ok = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {

                    KhenThuongPhatCtrl.Xoa(txtMaKTP.Text);
                    MessageBox.Show("Bản ghi đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDGV();            
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
          
            try
            {
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
        FormInDSTP FormInDSTP;
        private void btnInKTP_Click(object sender, EventArgs e)
        {
            if (FormInDSTP == null || FormInDSTP.IsDisposed == true)
            {
                FormInDSTP = new FormInDSTP();

                FormInDSTP.Show();
            }

        }

        private void textBoxNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
            labelMaNV.Text = e.manv;
            textBoxNhanVien.Text = e.tennv;
        }

        private void dtpNgayTao_Leave(object sender, EventArgs e)
        {
            string thangnam;
            if (dtpNgayTao.Value.Month < 10)
            {
                thangnam = dtpNgayTao.Value.Year + "0" + dtpNgayTao.Value.Month;
            }
            else
            {
                thangnam = dtpNgayTao.Value.Year + "" + dtpNgayTao.Value.Month;
            }
            try
            {
                dgvThuongPhat.DataSource = KhenThuongPhatCtrl.HienThiTimKiem(thangnam);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổ dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
