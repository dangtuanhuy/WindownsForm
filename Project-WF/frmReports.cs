using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Project_WF
{
    public partial class frmReports : Form
    {
        public DataTable DataOrder { get; set; }
        ReportViewer rpv = new ReportViewer();
        public frmReports()
        {
            InitializeComponent();
            rpv.Dock = DockStyle.Fill;
            rpv.LocalReport.ReportEmbeddedResource = "Project_WF.Reports.ReportOrderrdlc.rdlc";
            this.Controls.Add(rpv);
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSetOrder", DataOrder);
            this.rpv.LocalReport.DataSources.Clear();
            this.rpv.LocalReport.DataSources.Add(rds);
            this.rpv.LocalReport.Refresh();
            this.rpv.RefreshReport();
        }
    }
}
