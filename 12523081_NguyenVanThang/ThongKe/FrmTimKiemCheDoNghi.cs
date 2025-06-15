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
    public partial class FrmTimKiemCheDoNghi : Form
    {
        public FrmTimKiemCheDoNghi()
        {
            InitializeComponent();
        }

        private void txtMaNV_MouseClick(object sender, MouseEventArgs e)
        {

        }
        CheDoNghiCtrl CheDoNghiCtrl =new CheDoNghiCtrl();
        private void FrmBangNV_DelegateMaNV(object sender, DelegateCtrl e)
        {
            txtMaNV.Text = e.manv;
           // throw new NotImplementedException();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvCheDoNghi.DataSource = CheDoNghiCtrl.HienThiTimKiem(txtMaNV.Text);

        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                frmBangNV frmBangNV = new frmBangNV();
                layma layma = new layma(frmBangNV.manv);
                layma(txtMaNV.Text);
                frmBangNV.DelegateMaNV += FrmBangNV_DelegateMaNV; ;
                frmBangNV.ShowDialog();
                return;
            }
        }
        
    }
}
