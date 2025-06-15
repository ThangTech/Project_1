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

namespace _12523081_NguyenVanThang
{
    delegate void layma(string manv);
    public partial class frmBangNV : Form
    {
        public frmBangNV()
        {
            InitializeComponent();
        }
        NhanVienCtrl NhanVienCtrl = new NhanVienCtrl();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhanVienCtrl.HienThiTimKiem(m_manv);
        }
        string m_manv;
        public void manv (string timkiem)
            {
                m_manv = timkiem;
            }
        public event DelegateMaNV DelegateMaNV;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DelegateMaNV != null)
            {
                DelegateMaNV(this, new DelegateCtrl { manv = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    tennv= dataGridView1.CurrentRow.Cells[1].Value.ToString() });
                this.Close();
            }    
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (DelegateMaNV != null)
                {
                    DelegateMaNV(this, new DelegateCtrl
                    {
                        manv = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        tennv = dataGridView1.CurrentRow.Cells[1].Value.ToString()
                    });
                  
                }
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                this.Close();
            }    
        }
    }
}
