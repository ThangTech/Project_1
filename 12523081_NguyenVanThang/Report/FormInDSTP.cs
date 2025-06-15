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
    public partial class FormInDSTP : DevExpress.XtraEditors.XtraForm
    {
        public FormInDSTP()
        {
            InitializeComponent();
        }
        ReportCtrl ReportCtrl = new ReportCtrl();
        RpTP RpTp = new RpTP();
        private void FormInDSTP_Load(object sender, EventArgs e)
        {
            DetailReportBand detailReportBand = RpTp.Bands["DetailReportTP"] as DetailReportBand;
            detailReportBand.DataSource = ReportCtrl.LayDSKTP();
            RpTp.DataBind();
            documentViewer1.PrintingSystem = RpTp.PrintingSystem;
            RpTp.CreateDocument();
        }
    }
}