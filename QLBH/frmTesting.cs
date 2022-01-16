using DAL;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }
        DataTable dt1;
        DataTable dt2;

        private void frmTesting_Load(object sender, EventArgs e)
        {
            OleDbParameter[] p1 = new OleDbParameter[0];
            OleDbParameter[] p2 = new OleDbParameter[0];
            dt1 = DataProvider.Instance.SelectData("TestA", p1, "*");
            dt1.TableName = "TestA";
            dt2 = DataProvider.Instance.SelectData("TestB", p1, "*");
            dt2.TableName = "TestB";
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { dt1, dt2 });
            DataRelation drl = new DataRelation("TestA_TestB", dt1.Columns["MaTb2"], dt2.Columns["MaTb2"], false);
            //ds.Relations.Add(drl);
            //DataColumn dc = new DataColumn("TenTb", typeof(string));
            //dc.AllowDBNull = false;
            //dt1.Columns.Add(dc);
            //MessageBox.Show(dt1.Rows[0]["TenTb"].ToString());
            DataColumn dc = new DataColumn("TenTb2", typeof(string));
            dt1.Columns.Add(dc);
            //MessageBox.Show(s);
            dt2.ParentRelations.Add(drl);
            //BindingSource bs = new BindingSource();
            //bs.DataSource = ds.Tables["TestB"];
            dgvData.DataSource = dt1.DefaultView;
            DataView dv = new DataView();
            dgvData.RowValidating += DgvData_RowValidating;
            dgvData.RowPrePaint += DgvData_RowPrePaint;
            dgvData.DataError += DgvData_DataError;
            //DataColumn parent = dt1.Columns["MaTb2"];
            //DataColumn child = dt2.Columns["MaTb2"];
            //ForeignKeyConstraint constraint = new ForeignKeyConstraint("FK_Constraint", parent, child);

            //dt1.Select()
        }

        private void DgvData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (e.RowIndex > dt1.Rows.Count - 1) return;
            //int id = int.Parse(dt1.Rows[e.RowIndex]["MaTb2"].ToString());
            //string str = dt2.Select($"MaTb2={id}")[0]["TenTb"].ToString();
            //dt1.Rows[e.RowIndex]["TenTb2"] = str;
            //dgvData.Rows[e.RowIndex].Cells[].Value = str;
        }

        private void DgvData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataTable dc = dt1;
        }
    }
}
