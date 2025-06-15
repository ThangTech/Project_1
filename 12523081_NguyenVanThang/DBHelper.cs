using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class DBHelper
    {
        string chuoikn = @"Data Source=DESKTOP-7Q7IC0M\THANG2004;Initial Catalog=QLNS_WINFORM1;User ID=sa;Password=123456;";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        SqlDataReader dr;
        public void KetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = chuoikn;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void NgatKetNoi()
        {
            conn = new SqlConnection(chuoikn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable Table(string query)
        {
            da = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int TruyVanExcuteNonQuery(string query)
        {
            try
            {
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    KetNoi(); 
                }
                cmd = new SqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public int TruyVanExcuteScalar(string query)
        {
            try
            {
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    KetNoi();
                }
                cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    return 0; 
                }
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public SqlDataReader TruyVanExcuteReader(string query)
        {
            try
            {
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    KetNoi();
                }
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                return dr; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }
    }
}
