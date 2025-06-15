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
using DataLayer;

namespace _12523081_NguyenVanThang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
       Connecstring Connecstring= new Connecstring();
        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0'; 
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; 
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        void DangNhap()
        {
            DataTable dataTable = new DataTable();
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);

            Connecstring.Connection.Open();

            string query = "SELECT * FROM Account WHERE Username = '" + txtTaiKhoan.Text + "' AND Password = '" + txtMatKhau.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connecstring.Connection);
            adapter.Fill(dataTable);
            Connecstring.Connection.Close();
        

            if (dataTable.Rows.Count == 1)
            {
                string username = dataTable.Rows[0]["Username"].ToString(); 

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                frmMenuQuanLy menuForm = new frmMenuQuanLy(username);
                this.Hide();
                menuForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
                e.SuppressKeyPress = true;
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
