using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataCtrl;

namespace _12523081_NguyenVanThang.ThongKe
{
    public partial class FrmThongKeBangLuong : Form
    {
        public FrmThongKeBangLuong()
        {
            InitializeComponent();
        }
        BangLuongCtrl BangLuongCtrl = new BangLuongCtrl();
        //FrmThongKeBieuDo FrmThongKeBieuDo = new FrmThongKeBieuDo();
        private void lblBLNV_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
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
                dgvBangLuong.DataSource = BangLuongCtrl.HienThiTimKiemNghiNhieuNhat(txtSoNgay.Text, int.Parse(thangnam));
                //if (dgvBangLuong.Rows.Count==0)
                //{
                //    MessageBox.Show("Không có danh sách","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //}  
                //else
                //{

                //    MessageBox.Show(" Có danh sách "+dgvBangLuong.Rows.Count+" người nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}    
            }
            else if(checkBox1.Checked==true) 
            {
                dgvBangLuong.DataSource = BangLuongCtrl.HienThiTimKiemNhanVien(txtSoNgay.Text);
            }

        }

        private void FrmThongKeBangLuong_Load(object sender, EventArgs e)
        {
            Combo();

        }
        NhanVienCtrl NhanVienCtrl = new NhanVienCtrl();
        public void Combo()
        {
            MaNhanVien.DataSource = NhanVienCtrl.HienThi();
            MaNhanVien.ValueMember = "MaNhanVien";
            MaNhanVien.DisplayMember = "TenNhanVien";
           
        }

        private void txtSoNgay_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked==true)
            {
              
                frmBangNV frmBangNV = new frmBangNV();
                layma layma = new layma(frmBangNV.manv);
                layma(txtSoNgay.Text);
                frmBangNV.DelegateMaNV += FrmBangNV_DelegateMaNV; ;
                frmBangNV.ShowDialog();
                return;
            }
        }

        private void FrmBangNV_DelegateMaNV(object sender, DelegateCtrl e)
        {
            txtSoNgay.Text = e.manv;
            //throw new NotImplementedException();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongkeBD_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvBangLuong.DataSource as DataTable;

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để vẽ biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

             this.Close(); // Bạn có thể không muốn đóng form này lại

           
            FrmThongKeBieuDo frmChart = new FrmThongKeBieuDo();
            frmChart.Show(); 
        }
    }
}
