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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        //DBHelper DB = new DBHelper();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        ChucVuCtrl chucVuCtrl =new ChucVuCtrl();
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        void LoadDGV()
        {
            //DB.KetNoi();
            //string sql = "select * from ChucVu";
            //dt = DB.Table(sql);
            //dgvChucVu.DataSource = dt; 
            //DB.NgatKetNoi();
            dgvChucVu.DataSource = chucVuCtrl.HienThi();
        }
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txtMaCV.Text = dgvChucVu.CurrentRow.Cells[0].Value.ToString();
                txtTenCV.Text = dgvChucVu.CurrentRow.Cells[1].Value.ToString();
            
        }

        private bool KiemTraThongTinChucVu(bool kiemTraTonTai)
        {
            if (txtMaCV.Text == "" || txtTenCV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sqlCheck = "Select Count(*) From ChucVu Where MaChucVu = '" + txtMaCV.Text.Trim() + "'";
            //int count = DB.TruyVanExcuteScalar(sqlCheck);

            //if (kiemTraTonTai && count > 0)
            //{
            //    MessageBox.Show("Mã chức vụ đã tồn tại. Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            //else if (!kiemTraTonTai && count == 0)
            //{
            //    MessageBox.Show("Không tìm thấy mã chức vụ cần thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            return true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DB.KetNoi();
            //    if (!KiemTraThongTinChucVu(true)) 
            //    {
            //        return;
            //    }

            //    string sqlAdd = "Insert into ChucVu Values('" + txtMaCV.Text + "',  N'" + txtTenCV.Text + "')";
            //    int i = DB.TruyVanExcuteNonQuery(sqlAdd);
            //    if(i > 0)
            //    {
            //    }
            //    DB.NgatKetNoi();
            //}
            try
            {
                if (txtMaCV.Text == "" || txtTenCV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chucVuCtrl.KiemTraTrungMa(txtMaCV.Text))
                {
                    MessageBox.Show("Mã chức vụ đã tồn tại. Vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChucVu chucVu = new ChucVu
                {
                    MaChucVu = txtMaCV.Text,
                    TenChucVu = txtTenCV.Text
                };

                chucVuCtrl.Them(chucVu);
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
            //try
            //{
            //    DB.KetNoi();
            //    if (!KiemTraThongTinChucVu(false)) 
            //    {
            //        return;
            //    }

            //    string sqlupdate = "Update ChucVu Set TenChucVu = N'"+txtTenCV.Text+"' Where MaChucVu = '"+txtMaCV.Text+"' ";
            //    int i = DB.TruyVanExcuteNonQuery(sqlupdate);
            //    if (i > 0)
            //    {
            try
            {
                ChucVu chucVu = new ChucVu();
                chucVu.MaChucVu = txtMaCV.Text;
                chucVu.TenChucVu = txtTenCV.Text;
                chucVuCtrl.Sua(chucVu);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            //    }
            //    DB.NgatKetNoi();
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DB.KetNoi();
            //    if (!KiemTraThongTinChucVu(false)) 
            //    {
            //        return;
            //    }

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacNhan == DialogResult.Yes)
            {
                //string sqlDelete = "Delete From ChucVu Where MaChucVu = '" + txtMaCV.Text.Trim() + "'";
                //DB.TruyVanExcuteNonQuery(sqlDelete);
                chucVuCtrl.Xoa(txtMaCV.Text);
                MessageBox.Show("Xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGV();
            }
            //    DB.NgatKetNoi();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DB.KetNoi();
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //    string timkiem = txtTimKiem.Text;            
            //    string sqlSearch = "Select * From ChucVu Where MaChucVu Like N'%" + timkiem + "%' or TenChucVu Like N'%" + timkiem + "%'";
            //    dt = DB.Table(sqlSearch);
            //    dgvChucVu.DataSource = dt;
            dgvChucVu.DataSource = chucVuCtrl.HienThiTimKiem(txtTimKiem.Text);
            if (chucVuCtrl.HienThiTimKiem(txtTimKiem.Text).Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //    DB.NgatKetNoi();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadDGV();
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtTimKiem.Clear();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
