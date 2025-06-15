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
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace _12523081_NguyenVanThang.Report
{
    public delegate void LayMaPhongThangNam(string maphongban, string thangnam);
    public partial class FrmInDSBangLuong : DevExpress.XtraEditors.XtraForm
    {

        public FrmInDSBangLuong()
        {
            InitializeComponent();
        }
        string m_thangnam;
        string m_maphongban;

        public void layma(string phongban, string thangnam)
        {
            m_maphongban = phongban;
            m_thangnam = thangnam;
        }
        ReportBangLuong ReportBangLuong = new ReportBangLuong();
        ReportCtrl ReportCtrl = new ReportCtrl();
        private void FrmInDSBangLuong_Load(object sender, EventArgs e)
        {
            DetailReportBand detailReport1 = ReportBangLuong.Bands["DetailReportBangLuong"] as DetailReportBand;
            detailReport1.DataSource = ReportCtrl.DSChamCong(m_maphongban,int.Parse(m_thangnam));
            ReportBangLuong.DataBind();

            documentViewer1.PrintingSystem = ReportBangLuong.PrintingSystem;
            ReportBangLuong.CreateDocument();
        }
    }
}