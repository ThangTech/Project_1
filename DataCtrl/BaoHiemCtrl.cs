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
    public class BaoHiemCtrl
    {
        public BaoHiemCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from BaoHiem";
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
            string query = "select * from BaoHiem where MaNhanVien like @TimKiem ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(BaoHiem baoHiem)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into BaoHiem values(@MaBaoHiem,@MaNhanVien,@LoaiBaoHiem,@NgayCap,@NgayHetHan,@NoiCap)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaBaoHiem", baoHiem.MaBaoHiem);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@MaNhanVien", baoHiem.MaNhanVien);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@LoaiBaoHiem", baoHiem.LoaiBaoHiem);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@NgayCap", baoHiem.NgayCap);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@NgayHetHan", baoHiem.NgayHetHan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@NoiCap", baoHiem.NoiCap);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(BaoHiem baoHiem)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update BaoHiem set MaNhanVien=@MaNhanVien," +
                "LoaiBaoHiem=@LoaiBaoHiem,NgayCap=@NgayCap,NgayHetHan=@NgayHetHan,NoiCap=@NoiCap" +
                " where MaBaoHiem=@MaBaoHiem";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaBaoHiem", baoHiem.MaBaoHiem);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@MaNhanVien", baoHiem.MaNhanVien);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@LoaiBaoHiem", baoHiem.LoaiBaoHiem);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@NgayCap", baoHiem.NgayCap);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@NgayHetHan", baoHiem.NgayHetHan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@NoiCap", baoHiem.NoiCap);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string mabaohiem)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from BaoHiem where MaBaoHiem=@MaBaoHiem";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaBaoHiem", mabaohiem);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public bool KiemTraTrungMa(string maBaoHiem)
        {
            bool tonTai = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            string query = "SELECT COUNT(*) FROM BaoHiem WHERE MaBaoHiem = @MaBaoHiem";
            SqlCommand cmd = new SqlCommand(query, Connecstring.Connection);
            cmd.Parameters.AddWithValue("@MaBaoHiem", maBaoHiem);
            Connecstring.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            tonTai = count > 0;
            Connecstring.Connection.Close();
            return tonTai;
        }
    }
}
