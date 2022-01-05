using CrystalDecisions.CrystalReports.Engine;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Pages
{
    public partial class frmReportViewer : Form
    {
        const string DEFAULT_PATH = "Reports/";
        //public string FileName { get; set; }
        public frmReportViewer(string fileName)
        {
            InitializeComponent();
            string fName = DEFAULT_PATH + fileName;
            try
            {
                if (File.Exists(fName))
                {
                    ReportDocument report = new ReportDocument();
                    report.Load(fName);
                    DataTable dt = BrandDAL.GetBrandList();
                    report.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.RefreshReport();
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file report. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }

        }
    }
}
