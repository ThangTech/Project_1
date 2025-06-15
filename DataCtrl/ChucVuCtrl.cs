using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DataSetQLNSTableAdapters;
namespace DataCtrl
{
    public class ChucVuCtrl
    {
       

        public ChucVuCtrl()
        {

        }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from ChucVu";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);

            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
          
            return dt;
        }
        public DataTable HienThiTimKiem(string timkiem)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from ChucVu where MaChucVu like @TimKiem or TenChucVu like @TimKiem";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%"+timkiem+"%");
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(ChucVu chucVu)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into ChucVu values(@MaChucVu,@TenChucVu)";
            Connecstring.SqlCommand =new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaChucVu",chucVu.MaChucVu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@TenChucVu", chucVu.TenChucVu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close() ;
        }
        public void Sua(ChucVu chucVu)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update ChucVu set TenChucVu=@TenChucVu where MaChucVu=@MaChucVu";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaChucVu", chucVu.MaChucVu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@TenChucVu", chucVu.TenChucVu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string machucvu)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from ChucVu where MaChucVu=@MaChucVu";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaChucVu", machucvu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public bool KiemTraTrungMa(string maChucVu)
        {
            bool tonTai = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();

            string query = "SELECT COUNT(*) FROM ChucVu WHERE MaChucVu = '" + maChucVu + "'";
            Connecstring.SqlCommand = new SqlCommand(query, Connecstring.Connection);
            int count = (int)Connecstring.SqlCommand.ExecuteScalar();

            if (count > 0)
                tonTai = true;

            Connecstring.Connection.Close();
            return tonTai;
        }
    }
}
