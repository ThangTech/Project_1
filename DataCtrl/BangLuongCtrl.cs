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
    public class BangLuongCtrl
    {
        public BangLuongCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi(int thangnam)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from BangLuong Where ThangNam=@ThangNam";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangnam);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public DataTable HienThiTimKiem(string timkiem, int thangnam)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from BangLuong where MaNhanVIen like @TimKiem and ThangNam=@ThangNam ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangnam);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public DataTable HienThiTimKiemNghiNhieuNhat(string ngaycon, int thangnam)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from BangLuong where SoNgayLam<=@SoNgayLam and ThangNam=@ThangNam ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@SoNgayLam", ngaycon);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangnam);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public DataTable HienThiTimKiemNhanVien(string manv)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from BangLuong where MaNhanVien like @MaNhanVien  ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaNhanVien", "%"+manv+"%");
            
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(BangLuong bangLuong)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into BangLuong values(@ThangNam,@MaNhanVien,@LuongCoBan,@SoNgayLam,@KhongCong," +
                "@PhuCap,@TongLuong)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", bangLuong.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@LuongCoBan", bangLuong.LuongCoBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@SoNgayLam", bangLuong.SoNgayLam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@KhongCong", bangLuong.KhongCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@PhuCap", bangLuong.PhuCap);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@TongLuong", bangLuong.TongLuong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            SqlParameter sqlParameter7 = new SqlParameter("@ThangNam", bangLuong.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter7);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(BangLuong bangLuong)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update BangLuong set LuongCoBan=@LuongCoBan," +
                "SoNgayLam=@SoNgayLam,KhongCong=@KhongCong" +
                ",PhuCap=@PhuCap,TongLuong=@TongLuong" +
                " where MaNhanVien=@MaNhanVien and ThangNam=@ThangNam";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", bangLuong.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@LuongCoBan", bangLuong.LuongCoBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@SoNgayLam", bangLuong.SoNgayLam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@KhongCong", bangLuong.KhongCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@PhuCap", bangLuong.PhuCap);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@TongLuong", bangLuong.TongLuong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            SqlParameter sqlParameter7 = new SqlParameter("@ThangNam", bangLuong.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter7);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string manhanvien, int thangnam)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from BangLuong where MaNhanVien=@MaNhanVien and ThangNam=@ThangNam";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", manhanvien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter5 = new SqlParameter("@ThangNam", thangnam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
    }
}
