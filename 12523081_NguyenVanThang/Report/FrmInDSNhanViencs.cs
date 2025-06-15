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
using DevExpress.XtraReports;

namespace _12523081_NguyenVanThang.Report
{ public delegate void LayMaPhong(string maphongban);
    public partial class FrmInDSNhanViencs : DevExpress.XtraEditors.XtraForm
    {
        public FrmInDSNhanViencs()
        {
            InitializeComponent();
        }
        string m_maphongban;
        public void layma(string maphongban)
        {
            m_maphongban = maphongban;
        }
        ReportCtrl ReportCtrl =new ReportCtrl();
        RDSNhanVien RDSNhanVien = new RDSNhanVien();
        private void FrmInDSNhanViencs_Load(object sender, EventArgs e)
        {
            DetailReportBand detailReport1 = RDSNhanVien.Bands["DetailReportNhanVien"] as DetailReportBand;
            detailReport1.DataSource = ReportCtrl.LayDSChamCong(m_maphongban);
            RDSNhanVien.DataBind();

            documentViewer1.PrintingSystem = RDSNhanVien.PrintingSystem;
            RDSNhanVien.CreateDocument();
        }
    }
}