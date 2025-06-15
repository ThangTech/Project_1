using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataCtrl
{
    public class PhongBanCtrl
    {
        public PhongBanCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from PhongBan";
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
            string query = "select * from PhongBan where MaPhongBan like @TimKiem or TenPhongBan like @TimKiem";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(PhongBan phongBan)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into PhongBan values(@MaPhongBan,@TenPhongBan)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaPhongBan", phongBan.MaPhongBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@TenPhongBan", phongBan.TenPhongBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(PhongBan phongBan)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update PhongBan set TenPhongBan=@TenPhongBan where MaPhongBan=@MaPhongBan";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaPhongBan", phongBan.MaPhongBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@TenPhongBan", phongBan.TenPhongBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string maphongban)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from PhongBan where MaPhongBan=@MaPhongBan";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaPhongBan", maphongban);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public bool KiemTraTrungMa(string maPB)
        {
            bool tonTai = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan = @MaPhongBan";
            Connecstring.SqlCommand = new SqlCommand(query, Connecstring.Connection);
            Connecstring.SqlCommand.Parameters.AddWithValue("@MaPhongBan", maPB);
            int count = (int)Connecstring.SqlCommand.ExecuteScalar();
            if (count > 0)
                tonTai = true;
            Connecstring.Connection.Close();
            return tonTai;
        }
    }
}
