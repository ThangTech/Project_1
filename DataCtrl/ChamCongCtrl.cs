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
    public class ChamCongCtrl
    {
        public ChamCongCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi(int thangnam)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from ChamCong Where ThangNam=@ThangNam";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam",  thangnam);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public DataTable HienThiTimKiem(string timkiem,int thangnam)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from ChamCong where MaNhanVIen like @TimKiem and ThangNam=@ThangNam ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam",thangnam);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;

        }
        public DataTable HienThiTimKiemNV(string timkiem)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from ChamCong where MaNhanVIen like @TimKiem ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
          
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(ChamCong chamCong)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into ChamCong values(@MaNhanVien,@NgayChamCong,@TongNgayCong,@TinhTrang,@ThangNam)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", chamCong.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@NgayChamCong", chamCong.NgayCham);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@TongNgayCong", chamCong.TongNgayCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@TinhTrang", chamCong.TinhTrang);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@ThangNam", chamCong.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(ChamCong chamCong)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update ChamCong set NgayChamCong=@NgayChamCong," +
                "TongNgayCong=@TongNgayCong,TinhTrang=@TinhTrang where MaNhanVien=@MaNhanVien and ThangNam=@ThangNam";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", chamCong.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@NgayChamCong", chamCong.NgayCham);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@TongNgayCong", chamCong.TongNgayCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@TinhTrang", chamCong.TinhTrang);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@ThangNam", chamCong.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string manhanvien,int thangnam)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from ChamCong where MaNhanVien=@MaNhanVien and ThangNam=@ThangNam";
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
