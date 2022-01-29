using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DAL;
using DTO;
using QLBH.Pages.Cooperation;
using QLBH.Resources;

namespace QLBH.Pages.Goods
{
    public partial class frmGoods : FormCustom
    {
        public Product ProductInfo { get; set; }
        DataTable dtFull, dtShow;
        DataTable dtUnit, dtType, dtBrand, dtSupplier;
        string query = "{name}{brand}{type}";
        public frmGoods()
        {
            InitializeComponent();
            InitLoad();
            InitDataSet();
            dgvData.RowPrePaint += FormHandler.RowPrepaintHandler;
        }

        private void toolBars1_FClick(object sender, CustomEvent e)
        {
            MessageBox.Show(e.Key.ToString());
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGoods_Load(object sender, EventArgs e)
        {

        }

        void InitDataSet()
        {
            try
            {
                //dtShow.Columns.Add(new DataColumn("TenDVT", typeof(string)));
                //dtShow.Columns.Add(new DataColumn("TenNCC", typeof(string)));
                //dtShow.Columns.Add(new DataColumn("TenNhomHang", typeof(string)));
                //dtShow.Columns.Add(new DataColumn("TenHang", typeof(string)));
                
                DataGridViewComboBoxColumn dgvcUnit = new DataGridViewComboBoxColumn();
                dgvcUnit.HeaderText = "Đơn vị tính";
                dgvcUnit.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                dgvcUnit.DataPropertyName = "DonViTinh";
                dgvcUnit.DataSource = dtUnit;
                dgvcUnit.ValueMember = "ID";
                dgvcUnit.DisplayMember = "TenDonVi";

                DataGridViewComboBoxColumn dgvcType = new DataGridViewComboBoxColumn();
                dgvcType.HeaderText = "Nhóm hàng";
                dgvcType.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                dgvcType.DataPropertyName = "NhomHang";
                dgvcType.DataSource = dtType;
                dgvcType.ValueMember = "ID";
                dgvcType.DisplayMember = "TenNhomHang";

                DataGridViewComboBoxColumn dgvcSp = new DataGridViewComboBoxColumn();
                dgvcSp.HeaderText = "Nhà cung cấp";
                dgvcSp.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                dgvcSp.DataPropertyName = "NhaCungCap";
                dgvcSp.DataSource = dtSupplier;
                dgvcSp.ValueMember = "ID";
                dgvcSp.DisplayMember = "TenNCC";

                DataGridViewComboBoxColumn dgvcBrand = new DataGridViewComboBoxColumn();
                dgvcBrand.HeaderText = "Hãng";
                dgvcBrand.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                dgvcBrand.DataPropertyName = "Hang" ;
                dgvcBrand.DataSource = dtBrand;
                dgvcBrand.ValueMember = "MaHang";
                dgvcBrand.DisplayMember = "TenHang";

                dgvData.Columns.Insert(4, dgvcUnit);
                dgvData.Columns.Insert(5, dgvcType);
                dgvData.Columns.Insert(6, dgvcSp);
                dgvData.Columns.Insert(7, dgvcBrand);

                //DataTable dtTypeSrch = dtType.Copy()
                //         , dtSpSrch = dtSupplier.Copy()
                //         , dtBrandSrch = dtBrand.Copy();
                //DataRow drType = dtTypeSrch.NewRow()
                //       , drSp = dtSpSrch.NewRow()
                //       , drBrand = dtBrandSrch.NewRow();

                //drType["ID"] = -1;
                //drType["TenNhomHang"] = "";

                //drSp["ID"] = -1;
                //drSp["TenNCC"] = "";

                //drBrand["MaHang"] = -1;
                //drBrand["TenHang"] = "";

                //dtTypeSrch.Rows.InsertAt(drType, 0);
                //dtBrandSrch.Rows.InsertAt(drBrand, 0);
                //dtSpSrch.Rows.InsertAt(drSp, 0);

                //cbbType.DataSource = dtTypeSrch;
                //cbbType.ValueMember = "ID";
                //cbbType.DisplayMember = "TenNhomHang";
                //cbbType.SelectedIndex = 0;

                //cbbBrand.DataSource = dtBrandSrch;
                //cbbBrand.ValueMember = "MaHang";
                //cbbBrand.DisplayMember = "TenHang";
                //cbbBrand.SelectedIndex = 0;
                //cbbType.SelectedIndexChanged += cbbType_SelectedIndexChanged;
                //cbbBrand.SelectedIndexChanged += cbbBrand_SelectedIndexChanged;
                //DataSet ds = new DataSet();
                //ds.Tables.AddRange(new DataTable[5] { dtShow, dtUnit, dtType, dtBrand, dtSupplier });

                //DataRelation rl = new DataRelation("Unit_Goods",
                //     dtUnit.Columns["ID"]
                //    , dtShow.Columns["DonViTinh"]
                //    );
                //DataRelation rlSup = new DataRelation("Supplier_Goods"
                //    , dtSupplier.Columns["ID"]
                //    , dtShow.Columns["NhaCungCap"]
                //    );
                //DataRelation rlType = new DataRelation("GT_Goods"
                //    , dtType.Columns["ID"]
                //    , dtShow.Columns["NhomHang"]
                //    );
                //DataRelation rlBrand = new DataRelation("Brand_Goods"
                //    , dtBrand.Columns["MaHang"]
                //    , dtShow.Columns["Hang"]
                //    );

                //DataGridViewComboBoxColumn
                //ds.Relations.AddRange(new DataRelation[] { rl, rlSup, rlType, rlBrand });
                //ds.Tables["Table1"].Columns["TenDVT"].Expression = "Parent(Unit_Goods).[TenDonVi]";
                //ds.Tables["Table1"].Columns["TenNCC"].Expression = "Parent(Supplier_Goods).[TenNCC]";
                //ds.Tables["Table1"].Columns["TenNhomHang"].Expression = "Parent(GT_Goods).[TenNhomHang]";
                //ds.Tables["Table1"].Columns["TenHang"].Expression = "Parent(Brand_Goods).[TenHang]";
            }
            catch ( Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            //DataRelation rl1 = new DataRelation("ID_DVT", dtUnit.Columns["ID"], dt2.Columns["DonViTinh"]);
            //ds.Relations.Add(rl1);
        }

        void InitLoad()
        {
            //MessageBox.Show(StringHandler.FormatForCurrency("3000000",false));
            try
            {
                dtFull = GoodsDAL.Instance.GetProductList();
                dtUnit = UnitDAL.Instance.GetUnitList();
                dtType = GoodsTypeDAL.Instance.GetGoodsTypeList();
                dtSupplier = SupplierDAL.Instance.GetSupplierList();
                dtBrand = BrandDAL.Instance.GetBrandList();
                if (dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand();
            frm.ShowDialog(this);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.ShowDialog(this);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            frmProductType frm = new frmProductType();
            frm.ShowDialog(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK = FormHandler.Save("HangHoa", dtShow, ref dtFull);
            if (isOK) InitLoad();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            object dr = null;
            bool isOK = FormHandler.SelectRow(dgvData, dtShow, out dr);
            if (isOK)
            {
                ProductInfo = Product.ConvertToObj((DataRow)dr);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtShow.Rows.Clear();
            StringBuilder query = new StringBuilder("");
            string str = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(str))
            {
                query.Append($"MaHang LIKE '%{str}%'");
                query.Append($" OR TenHangHoa LIKE '%{str}%'");
                //query.Append($" OR SDT LIKE '%{str}%'");
                //query.Append($" OR Email LIKE '%{str}%'");
                //query.Replace("{name}", q);
                DataRow[] drs = dtFull.Select(query.ToString());
                foreach(DataRow dr in drs)
                {
                    dtShow.Rows.Add(dr.ItemArray);
                }
            }
            else
            {
                dtShow = dtFull.Copy();
            }
            dtShow.AcceptChanges();
            dgvData.DataSource = dtShow;
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        //private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        //{
        //    if (!dgvData.Rows[e.RowIndex].IsNewRow)
        //    {
        //        dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        //    }
        //}

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (HasReturned)
            {
                btnSelect_Click(null, null);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex > -1)
            //{
            //    DataRow dr = dtShow.Rows[e.RowIndex];

            //}
        }

        //private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string q = " AND 1=1";
        //    if(!"-1".Equals(cbbBrand.SelectedValue.ToString()) && cbbBrand.SelectedIndex > -1)
        //    {
        //        dtShow.Rows.Clear();
        //        string id = cbbBrand.SelectedValue.ToString();
        //        //q = $" AND Hang={id}";
        //        //query = query.Replace("{brand}", q);
        //        Search();
        //    }
        //    else
        //    {
        //        //query = query.Replace("{brand}", q);
        //        Search();
        //    }
        //}

        //private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string q = " AND 1=1";
        //    if(!"-1".Equals(cbbType.SelectedValue.ToString()) && cbbType.SelectedIndex > -1)
        //    {
        //        dtShow.Rows.Clear();
        //        string id = cbbType.SelectedValue.ToString();
        //        //q = $" AND NhomHang={id}";
        //        //query = query.Replace("{type}", q);
        //        Search();
        //    }
        //    else
        //    {
        //        //query = query.Replace("{type}", q);
        //        Search();
        //    }
        //}

        void Search()
        {
            //query = cbbBrand.SelectedIndex < 1 ? query.Replace("{brand}", "") : query.Replace("{brand}"," AND Hang="+cbbBrand.SelectedValue.ToString());
            //query = cbbType.SelectedIndex < 1 ? query.Replace("{type}", "") : query.Replace("{type}");
            //query = string.IsNullOrEmpty(txtName.Text) ? query.Replace("{name}", "1=1") : query;

            //bool string.IsNullOrEmpty()


            DataRow[] drs = dtFull.Select(query);
            foreach(DataRow dr in drs)
            {
                dtShow.Rows.Add(dr.ItemArray);
            }
            dtShow.AcceptChanges();
            dgvData.DataSource = dtShow;
            query = "{name}{brand}{type}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitLoad();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmUnit frm = new frmUnit();
            //frm.HasResult = false;
            frm.ShowDialog(this);
        }
    }
}
