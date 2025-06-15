using DevExpress.XtraEditors;
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
using DevExpress.XtraReports.UI;

namespace _12523081_NguyenVanThang.Report
{
    public partial class FormInDSBaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public FormInDSBaoHiem()
        {
            InitializeComponent();
        }
        ReportCtrl ReportCtrl = new ReportCtrl();
        RpBaoHiem RpBaoHiem = new RpBaoHiem();
        private void FormInDSBaoHiem_Load(object sender, EventArgs e)
        {
            DetailReportBand detailReportBand = RpBaoHiem.Bands["DetailReportBaoHiem"] as DetailReportBand;
            detailReportBand.DataSource = ReportCtrl.LayDSBaoHiem();
            RpBaoHiem.DataBind();
            documentViewer1.PrintingSystem = RpBaoHiem.PrintingSystem;
            RpBaoHiem.CreateDocument();
        }
    }
}