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
    public class ChamCongHangNgayCtrl
    {
        public ChamCongHangNgayCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi(DateTime NgayChamCong, string phong)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select ChamCongHangNgay.MaNhanVien,ChamCong,NgayChamCong,ThangNam from ChamCongHangNgay " +
                " inner join NhanVien on ChamCongHangNgay.MaNhanVien= NhanVien.MaNhanVien " +
                " inner join PhongBan on NhanVien.MaPhongBan = PhongBan.MaPhongBan " +
                "Where NgayChamCong=@NgayChamCong and PhongBan.MaPhongBan=@MaPhongBan";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@NgayChamCong", NgayChamCong.Year+"-"+NgayChamCong.Month+"-"+NgayChamCong.Day);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaPhongBan",phong);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
       
        public DataTable HienThiTimKiemTongCong(string timkiem, int thangnam)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select MaNhanVien,sum(ChamCong) as TongCong,ThangNam  from ChamCongHangNgay" +
                " where MaNhanVIen like @TimKiem and ThangNam=@ThangNam " +
                " group by MaNhanVien,ThangNam";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangnam);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;

        }
        public DataTable HienThiTimKiemNV(string timkiem,DateTime ngaychamcong)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from ChamCongHangNgay where MaNhanVIen like @TimKiem and NgayChamCong=@NgayChamCong ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@NgayChamCong", ngaychamcong.Year+"-"+ngaychamcong.Month+"-"+ngaychamcong.Day);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(ChamCongHangNgay chamCong)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into ChamCongHangNgay values(@MaNhanVien,@ChamCong,@NgayChamCong,@ThangNam)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", chamCong.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@ChamCong", chamCong.ChamCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@NgayChamCong", chamCong.NgayChamCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
           
            SqlParameter sqlParameter5 = new SqlParameter("@ThangNam", chamCong.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(ChamCongHangNgay chamCong)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update ChamCongHangNgay set ChamCong=@ChamCong " +
                " where MaNhanVien=@MaNhanVien and NgayChamCong=@NgayChamCong";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", chamCong.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@ChamCong", chamCong.ChamCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@NgayChamCong", chamCong.NgayChamCong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);



            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string manhanvien, int thangnam)
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
