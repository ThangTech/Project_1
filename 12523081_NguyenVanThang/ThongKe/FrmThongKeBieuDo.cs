using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DataCtrl;
using DataLayer;

namespace _12523081_NguyenVanThang.ThongKe
{
    public partial class FrmThongKeBieuDo : Form
    {
        private ChamCongCtrl ChamCongCtrl = new ChamCongCtrl();
        private NhanVienCtrl NhanVienCtrl = new NhanVienCtrl();
        public FrmThongKeBieuDo()
        {
            InitializeComponent();
        }

        private void FrmThongKeBieuDo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNS_WINFORM1DataSet.ChamCong' table. You can move, or remove it, as needed.
            //this.chamCongTableAdapter.Fill(this.qLNS_WINFORM1DataSet.ChamCong);
            dtpThangNam.Value = DateTime.Now;
            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.CustomFormat = "MM/yyyy";

            LoadChartDataForSelectedMonth();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadChartDataForSelectedMonth();
        }
        private void LoadChartDataForSelectedMonth()
        {
            try
            {
                int thangNam;
                if (dtpThangNam.Value.Month < 10)
                {
                    thangNam = dtpThangNam.Value.Year * 100 + dtpThangNam.Value.Month;
                }
                else
                {
                    thangNam = dtpThangNam.Value.Year * 100 + dtpThangNam.Value.Month;
                }
                DataTable dtBangLuong = TinhToanVaTaoBangLuong(thangNam);

                
                chartControl1.DataSource = null;
                chartControl1.Series.Clear();
                chartControl1.Titles.Clear();

                if (dtBangLuong == null || dtBangLuong.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để vẽ biểu đồ cho tháng đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                chartControl1.DataSource = dtBangLuong;

                Series series = new Series("Tổng lương", ViewType.Bar);
                series.ArgumentDataMember = "TenNhanVien";
                series.ValueDataMembers.AddRange(new string[] { "TongLuong" });
                chartControl1.Series.Add(series);

                ChartTitle chartTitle = new ChartTitle();
                chartTitle.Text = $"Thống kê tổng lương nhân viên tháng {dtpThangNam.Value:MM/yyyy}";
                chartControl1.Titles.Add(chartTitle);

                series.Label.TextPattern = "{V:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi tạo biểu đồ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable TinhToanVaTaoBangLuong(int thangNam)
        {
            DataTable dtBangLuong = new DataTable();
            dtBangLuong.Columns.Add("TenNhanVien", typeof(string));
            dtBangLuong.Columns.Add("TongLuong", typeof(decimal));

            DataTable dtChamCong = ChamCongCtrl.HienThi(thangNam);
            if (dtChamCong == null) return null;
            foreach (DataRow ccRow in dtChamCong.Rows)
            {
                string maNV = ccRow["MaNhanVien"].ToString();
                int soNgayCong = Convert.ToInt32(ccRow["TongNgayCong"]);
                NhanVien nv = NhanVienCtrl.LayNhanVienTheoMa(maNV);

                if (nv != null)
                {
                    decimal mucLuong = Convert.ToDecimal(nv.MucLuong);
                    int heSoLuong = nv.HeSoLuong;
                    decimal luongCoBan = mucLuong * heSoLuong;
                    decimal phuCap = Convert.ToDecimal(nv.PhuCap);
                    int soNgayCongChuan = 26;

                    decimal tienKhongCong = (soNgayCongChuan - soNgayCong) * (luongCoBan / soNgayCongChuan);
                    if (tienKhongCong < 0) tienKhongCong = 0;
                    decimal tongLuong = luongCoBan + phuCap - tienKhongCong;

                    DataRow newRow = dtBangLuong.NewRow();
                    newRow["TenNhanVien"] = nv.TenNhanVien;
                    newRow["TongLuong"] = Math.Round(tongLuong);
                    dtBangLuong.Rows.Add(newRow);
                }
            }
            if (dtBangLuong.Rows.Count <= 5)
            {
                return dtBangLuong;
            }
            DataTable dtTop5 = dtBangLuong.AsEnumerable()
                               .OrderByDescending(row => row.Field<decimal>("TongLuong"))
                               .Take(5)
                               .CopyToDataTable();

            return dtTop5; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
