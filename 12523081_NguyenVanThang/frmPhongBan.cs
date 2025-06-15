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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        //DBHelper dB = new DBHelper();
        //SqlCommand cmd;
        //SqlDataReader dr;
        //SqlDataAdapter da;
        //DataTable dt;
        PhongBanCtrl PhongBanCtrl = new PhongBanCtrl();
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        void LoadDGV()
        {
            //dB.KetNoi();
            //string query = "select * from PhongBan";
            //dt = dB.Table(query);
            //dgvPhongBan.DataSource = dt;
            //dB.NgatKetNoi();
            dgvPhongBan.DataSource = PhongBanCtrl.HienThi();
        }
        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                txtMaPB.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
                txtTenPB.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            
        }
        private bool KTMaPB(string maPB)
        {
            try
            {
              
                return  true; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã phòng ban: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool KiemTraThongTinPhongBan()
        {
            if (txtMaPB.Text == "" || txtTenPB.Text == "")
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
                if (!KiemTraThongTinPhongBan())
                    return;

                if (PhongBanCtrl.KiemTraTrungMa(txtMaPB.Text))
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại. Vui lòng nhập mã khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PhongBan phongBan = new PhongBan();
                phongBan.MaPhongBan = txtMaPB.Text;
                phongBan.TenPhongBan = txtTenPB.Text;
                PhongBanCtrl.Them(phongBan);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                PhongBan phongBan = new PhongBan();
                phongBan.MaPhongBan = txtMaPB.Text;
                phongBan.TenPhongBan = txtTenPB.Text;
                PhongBanCtrl.Sua(phongBan);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
               
                PhongBanCtrl.Xoa(txtMaPB.Text);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
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
                dgvPhongBan.DataSource = PhongBanCtrl.HienThiTimKiem(txtTimKiem.Text);
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadDGV();
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtTimKiem.Clear();
        }
    }
}
