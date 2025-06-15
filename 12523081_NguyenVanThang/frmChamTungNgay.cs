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
using DataLayer;

namespace _12523081_NguyenVanThang
{
    public partial class frmChamTungNgay : Form
    {
        public frmChamTungNgay()
        {
            InitializeComponent();
            ComBoPhongBan();
        }
        NhanVienCtrl NhanVienCtrl =new NhanVienCtrl();
        ChamCongHangNgayCtrl ChamCongHangNgayCtrl =new ChamCongHangNgayCtrl();
        PhongBanCtrl PhongBanCtrl =new PhongBanCtrl();
         void ComBoPhongBan()
        {
            comboBoxPhongBan.DataSource = PhongBanCtrl.HienThi();
            comboBoxPhongBan.ValueMember = "MaPhongBan";
            comboBoxPhongBan.DisplayMember = "TenPhongBan";
            MaNV.DataSource = NhanVienCtrl.HienThi();
            MaNV.ValueMember = "MaNhanVien";
            MaNV.DisplayMember = "TenNhanVien";
        }

        private void comboBoxPhongBan_Leave(object sender, EventArgs e)
        {
            string thangnam;
            if(dtp.Value.Month<10)
            {
                thangnam=dtp.Value.Year+"0"+dtp.Value.Month;
            }    
            else
            {
                thangnam = dtp.Value.Year + "" + dtp.Value.Month;
            }    
            foreach (DataRow item in NhanVienCtrl.LayDSChamCongPhongBan(comboBoxPhongBan.SelectedValue.ToString()).Rows)
            {
                if (ChamCongHangNgayCtrl.HienThiTimKiemNV(item["MaNhanVien"].ToString(),dtp.Value).Rows.Count==0)
                {
                    ChamCongHangNgay chamCongHangNgay =new ChamCongHangNgay();
                    chamCongHangNgay.MaNhanVien = item["MaNhanVien"].ToString();
                    chamCongHangNgay.ChamCong = 0;
                    chamCongHangNgay.NgayChamCong=dtp.Value;
                    chamCongHangNgay.ThangNam=int.Parse(thangnam);
                    ChamCongHangNgayCtrl.Them(chamCongHangNgay);

                }   
                else
                {

                }   
                
            }
            dgvChamCong.DataSource = ChamCongHangNgayCtrl.HienThi(dtp.Value, comboBoxPhongBan.SelectedValue.ToString());
            
            

        }

        private void frmChamTungNgay_Load(object sender, EventArgs e)
        {

        }

        private void dtp_Leave(object sender, EventArgs e)
        {
            string thangnam;
            if (dtp.Value.Month < 10)
            {
                thangnam = dtp.Value.Year + "0" + dtp.Value.Month;
            }
            else
            {
                thangnam = dtp.Value.Year + "" + dtp.Value.Month;
            }
            foreach (DataRow item in NhanVienCtrl.LayDSChamCongPhongBan(comboBoxPhongBan.SelectedValue.ToString()).Rows)
            {
                if (ChamCongHangNgayCtrl.HienThiTimKiemNV(item["MaNhanVien"].ToString(), dtp.Value).Rows.Count == 0)
                {
                    ChamCongHangNgay chamCongHangNgay = new ChamCongHangNgay();
                    chamCongHangNgay.MaNhanVien = item["MaNhanVien"].ToString();
                    chamCongHangNgay.ChamCong = 0;
                    chamCongHangNgay.NgayChamCong = dtp.Value;
                    chamCongHangNgay.ThangNam = int.Parse(thangnam);
                    ChamCongHangNgayCtrl.Them(chamCongHangNgay);

                }
                else
                {

                }

            }
            dgvChamCong.DataSource = ChamCongHangNgayCtrl.HienThi(dtp.Value, comboBoxPhongBan.SelectedValue.ToString());



        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgvChamCong.Rows[i].Cells[0].Value != null)
            {
                labelMaNV.Text = dgvChamCong[0, i].Value.ToString();
              
                textBoxNgayCong.Text = dgvChamCong[1, i].Value.ToString();
                dtp.Value =DateTime.Parse( dgvChamCong[2, i].Value.ToString());
                dtp.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ChamCongHangNgay chamCongHangNgay =new ChamCongHangNgay();
    
            chamCongHangNgay.MaNhanVien = labelMaNV.Text;
            chamCongHangNgay.ChamCong =float.Parse( textBoxNgayCong.Text);
            chamCongHangNgay.NgayChamCong=dtp.Value;


            ChamCongHangNgayCtrl.Sua(chamCongHangNgay);
            dgvChamCong.DataSource = ChamCongHangNgayCtrl.HienThi(dtp.Value, comboBoxPhongBan.SelectedValue.ToString());

            MessageBox.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            labelMaNV.Text = "";
            dtp.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
