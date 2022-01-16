using DAL;
using DTO;
using QLBH.Pages.Celebration.Employees;
using QLBH.Resources;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLBH.Pages.Celebration
{
    /// <summary>
    /// 会社員フォームのクラス
    /// 2021/12/19
    /// テイ
    /// </summary>
    public partial class frmEmployee : Form
    {
        #region 変数と定数宣言
        #endregion
        #region エベント処理
        #endregion
        #region メソッド処理
        #endregion

        DataTable dtFull, dtShow;
        Bitmap defaultAvt = Properties.Resources.boy;
        int currentRow = 0;

        public frmEmployee()
        {
            InitializeComponent();
            InitLoad();
        }
        

        /// <summary>
        /// 初期化に処理する
        /// 2021/12/19
        /// テイ
        /// </summary>
        void InitLoad(bool isInit = true)
        {
            try
            {
                dtFull = EmployeeDAL.Instance.GetEmployeeList();
                if(dtFull != null)
                {
                    if (isInit)
                    {
                        dtShow = dtFull.Copy();
                        createColDataGrid();
                    }
                    DrawList();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //FilterCheckBoxControl();
            
            //dgvData.RowValidating += DgvData_RowValidating;
            //dgvData.CellValidating += DgvData_CellValidating;
        }

        /// <summary>
        ///
        /// </summary>
        void DrawList()
        {
            pnlListEmpInfo.Controls.Clear();
            //323, 306 size of emp
            //16,14 pos of emp
            EmployeeDetail oldEmp = new EmployeeDetail()
            {
                Size = new Size(0, 0),
                Location = new Point(10, 14)
            };
            foreach (DataRow dr in dtShow.Rows)
            {
                EmployeeDetail emp = new EmployeeDetail()
                {
                    Size = new Size(323, 306),
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(oldEmp.Width + oldEmp.Location.X + 6, oldEmp.Location.Y),
                    EmployeeInfo = Employee.ConvertToDTO(dr)
                };
                emp.DetailClick += Emp_DetailClick;
                emp.UpdateClick += Emp_UpdateClick;
                pnlListEmpInfo.Controls.Add(emp);
                oldEmp = emp;
                if ((oldEmp.Location.X+oldEmp.Width+6) >= pnlListEmpInfo.Width)
                {
                    oldEmp.Size = new Size(0, oldEmp.Height);
                    oldEmp.Location = new Point(10, oldEmp.Location.Y + oldEmp.Height + 8);
                }
            }
        }

        private void Emp_UpdateClick(object sender, EventArgs e)
        {
            EmployeeDetail emp = sender as EmployeeDetail;
            frmEmpUpdate frm = new frmEmpUpdate(emp.EmployeeInfo, dtShow);
            DialogResult result = frm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                dtFull = EmployeeDAL.Instance.GetEmployeeList();
                DrawList();
                //InitLoad
            }
            else
            {
                DrawList();
            }
        }

        private void Emp_DetailClick(object sender, EventArgs e)
        {
            EmployeeDetail emp = sender as EmployeeDetail;
            frmEmpDetail frm = new frmEmpDetail(emp.EmployeeInfo);
            frm.ShowDialog(this);
        }

        void createColDataGrid()
        {
            DataGridViewTextBoxColumn dgvtb = new DataGridViewTextBoxColumn
            {
                HeaderText = "STT",
                Name = "Number",
                Width = 30,
                ReadOnly = true
            };
            //dgvData.Columns.Insert(0, dgvtb);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (!dgvData.Rows[e.RowIndex].IsNewRow)
            //{
            //    if (string.IsNullOrEmpty(e.FormattedValue.ToString()) && e.ColumnIndex == 2)
            //    {
            //        MessageBox.Show("Không được để trống Tên Nhân viên");
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        e.Cancel = false;
            //    }
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (!dgvData.Rows[e.RowIndex].IsNewRow)
            //{
            //    if (!CheckDataValidate(e.RowIndex, out string message))
            //    {
            //        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Cancel = true;
            //    }
            //}
        }
        /// <summary>
        /// dgvDataグリッドのRowPrePaintエベント処理
        /// 2022/01/08
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (!dgvData.Rows[e.RowIndex].IsNewRow)
            //{
            //    dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            //}
        }

        private void Ckb_CheckStateChanged(object sender, EventArgs e)
        {
            //FilterCheckBoxControl();
        }

 

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.UpdateData("NhanVien", dtShow,"*");
                dtFull = EmployeeDAL.Instance.GetEmployeeList();
                MessageBox.Show("Cập nhật dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitLoad(false);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("RESET sẽ huỷ bỏ tất cả thay đổi đối với dữ liệu. Bạn có chắc chắn chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes.Equals(result))
            {
                dtShow.RejectChanges();
            }
            InitLoad(false);
        }

        /// <summary>
        /// セールにクリックの処理
        /// 2021/12/22
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
           
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if(currentRow < dtShow.Rows.Count)
            {
                //dtShow.Rows[currentRow]["NgaySinh"] = dtpBirthdate.Value;
            }

        }

        private void DtpJobdate_ValueChanged(object sender, EventArgs e)
        {
            if(currentRow < dtShow.Rows.Count)
            {
                //dtShow.Rows[currentRow]["NgayNhanViec"] = dtpJobdate.Value;
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        bool CheckDataValidate(int rowIndex, out string message)
        {
            //TenNVにチェック処理
            //if (string.IsNullOrEmpty(dgvData.Rows[rowIndex].Cells[2].FormattedValue.ToString()))
            //{
            //    message = "TÊN NHÂN VIÊN không được để trống";
            //    return false;
            //}
            ////SDTにチェック処理
            //if (string.IsNullOrEmpty(dgvData.Rows[rowIndex].Cells[3].FormattedValue.ToString()))
            //{
            //    message = "SỐ ĐIỆN THOẠI không được để trống";
            //    return false;
            //}
            ////
            //Regex reg = new Regex(@"\d");
            ////SDT数字なわけじゃない場合にチェック処理
            //if (!reg.IsMatch(dgvData.Rows[rowIndex].Cells[3].FormattedValue.ToString()))
            //{
            //    message = "SỐ ĐIỆN THOẠI không hợp lệ";
            //    return false;
            //}
            message = "";
            return true;
        }
        /// <summary>
        /// 検索グループのEnterエベント処理
        /// 2022/01/08
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData.Equals(Keys.Enter))
            {
                BtnSearch_Click(null, null);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPickAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedlg = new OpenFileDialog();
            filedlg.Filter = "Image|*.jpg;*.png";
            DialogResult result = filedlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetAvatar(filedlg.FileName);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        void GetAvatar(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                Image img = Image.FromStream(fs);
                //picAvatar.Image = img;
                fs.Close();
            }catch(Exception e)
            {
                MessageBox.Show($"Dữ liệu ảnh không hợp lệ.\n{e.Message}.");
            }
        }

        private void toolBar_FClick(object sender, CustomEvent e)
        {
            switch (e.Key)
            {
                case 1:
                    addButton_Click(sender, e);
                    break;
            }
        }
        /// <summary>
        /// addButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            frmEmpUpdate frm = new frmEmpUpdate(null, dtShow);
            DialogResult result = frm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                InitLoad(true); 
            }
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            frmDepart frm = new frmDepart();
            frm.ShowDialog(this);
        }

        /// <summary>
        /// 検索ボタンにクリック処理
        /// 2021/12/22
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dtShow.Rows.Clear();
            StringBuilder filterStr = new StringBuilder("1=1");
            if(!string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrWhiteSpace(txtName.Text))
            {
                filterStr.Append($" AND TenNV LIKE '%{txtName.Text}%'");
            }
            //検索情報が無い場合、dtFullのデータを取る
            if (filterStr.ToString().Equals("1=1")) { dtShow = dtFull.Copy();}

            else　//検索情報によると、検索処理
            {
                DataRow[] drs = dtFull.Select(filterStr.ToString());
                foreach (DataRow dr in drs)
                {
                    dtShow.Rows.Add(dr.ItemArray);
                }

                dtShow.AcceptChanges();
            }
            InitLoad(false);
            //dgvData.DataSource = dtShow;
        }
    }
}
