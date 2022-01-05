using DAL;
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

        /// <summary>
        /// フィルター制御の配列
        /// </summary>
        readonly CheckBox[] ctrlCheckFilter;
        DataTable dtFull, dtShow;
        Bitmap defaultAvt = Properties.Resources.boy;
        int currentRow = 0;

        public frmEmployee()
        {
            InitializeComponent();
            //チェックボックスにセットする
            ctrlCheckFilter = new CheckBox[4]
            {
                ckbFEmployeeName,
                ckbFPhone,
                ckbFAddress,
                ckbFEmail
            };
            //チェックボックスのエベント処理
            foreach (CheckBox ckb in ctrlCheckFilter)
            {
                ckb.CheckStateChanged += Ckb_CheckStateChanged;
            }
            InitLoad();
        }
        /// <summary>
        /// 初期化に処理する
        /// 2021/12/19
        /// テイ
        /// </summary>
        void InitLoad()
        {
            try
            {
                dtFull = EmployeeDAL.Instance.GetEmployeeList();
                if(dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                    DataGridViewTextBoxColumn dgvtb = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "STT",
                        Name = "Number",
                        Width = 30,
                        ReadOnly = true
                    };
                    dgvData.Columns.Insert(0, dgvtb);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            FilterCheckBoxControl();
            dgvData.RowValidating += DgvData_RowValidating;
            dgvData.CellValidating += DgvData_CellValidating;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()) && e.ColumnIndex == 2)
                {
                    MessageBox.Show("Không được để trống Tên Nhân viên");
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                if (!CheckDataValidate(e.RowIndex, out string message))
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
        }

        private void Ckb_CheckStateChanged(object sender, EventArgs e)
        {
            FilterCheckBoxControl();
        }

        /// <summary>
        /// フィルターのチェックボックスの状態にチェック処理する
        /// 2021/12/19
        /// テイ
        /// </summary>
        void FilterCheckBoxControl()
        {
            foreach(CheckBox ckb in ctrlCheckFilter)
            {
                bool isChecked = ckb.Checked;
                if (ckb.Equals(ckbFEmployeeName))
                {
                    txtName.Enabled = isChecked;
                }
                else if (ckb.Equals(ckbFPhone))
                {
                    txtPhone.Enabled = isChecked;
                }
                else if (ckb.Equals(ckbFAddress))
                {
                    txtAddress.Enabled = isChecked;
                }
                else if (ckb.Equals(ckbFEmail))
                {
                    txtEmail.Enabled = isChecked;
                }
                else
                {

                }
            }
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
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("RESET sẽ huỷ bỏ tất cả thay đổi đối với dữ liệu. Bạn có chắc chắn chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes.Equals(result))
            {
                dtShow.RejectChanges();
            }
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
            DateTime birth = DateTime.Now;
            DateTime job = DateTime.Now;
            if (e.RowIndex > -1 && e.RowIndex < dtShow.Rows.Count)
            {
                string fullName = dtShow.Rows[e.RowIndex]["TenNV"].ToString();
                string avt = dtShow.Rows[e.RowIndex]["AnhDaiDien"].ToString();
                string birthDate = dtShow.Rows[e.RowIndex]["NgaySinh"].ToString();
                string jobDate = dtShow.Rows[e.RowIndex]["NgayNhanViec"].ToString();
                bool birhCast = DateTime.TryParse(birthDate, out birth);
                bool jobCast  = DateTime.TryParse(jobDate, out job);

                if (!string.IsNullOrEmpty(avt))
                {
                    if (File.Exists(avt))
                    {
                        FileStream fs = new FileStream(avt, FileMode.Open);
                        picAvatar.Image = Image.FromStream(fs);
                    }
                    else
                    {
                        picAvatar.Image = defaultAvt;
                    }
                }
                else
                {
                    picAvatar.Image = defaultAvt;
                }
                lblFullName.Text = string.IsNullOrEmpty(fullName) ? "" : fullName;
                dtpBirthdate.Value = birhCast ? birth : DateTime.Now;
                dtpJobdate.Value = jobCast ? job : DateTime.Now;
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if(currentRow < dtShow.Rows.Count)
            {
                dtShow.Rows[currentRow]["NgaySinh"] = dtpBirthdate.Value;
            }

        }

        private void DtpJobdate_ValueChanged(object sender, EventArgs e)
        {
            if(currentRow < dtShow.Rows.Count)
            {
                dtShow.Rows[currentRow]["NgayNhanViec"] = dtpJobdate.Value;
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
            if (string.IsNullOrEmpty(dgvData.Rows[rowIndex].Cells[2].FormattedValue.ToString()))
            {
                message = "TÊN NHÂN VIÊN không được để trống";
                return false;
            }
            //SDTにチェック処理
            if (string.IsNullOrEmpty(dgvData.Rows[rowIndex].Cells[3].FormattedValue.ToString()))
            {
                message = "SỐ ĐIỆN THOẠI không được để trống";
                return false;
            }
            //
            Regex reg = new Regex(@"\d");
            //SDT数字なわけじゃない場合にチェック処理
            if (!reg.IsMatch(dgvData.Rows[rowIndex].Cells[3].FormattedValue.ToString()))
            {
                message = "SỐ ĐIỆN THOẠI không hợp lệ";
                return false;
            }
            message = "";
            return true;
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
            foreach(CheckBox ckb in ctrlCheckFilter)
            {
                bool isChecked = ckb.Checked;
                if (ckb.Equals(ckbFEmployeeName))
                {
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        filterStr.Append(isChecked ? $" AND TenNV LIKE '%{txtName.Text}%'" : "");
                    }
                }
                else if (ckb.Equals(ckbFPhone))
                {
                    if (!string.IsNullOrEmpty(txtPhone.Text))
                    {
                        filterStr.Append(isChecked ? $" AND SDT LIKE '%{txtPhone.Text}%'" : "");
                    }
                }
                else if (ckb.Equals(ckbFAddress))
                {
                    if (!string.IsNullOrEmpty(txtAddress.Text))
                    {
                        filterStr.Append(isChecked ? $" AND DiaChi LIKE '%{txtAddress.Text}%'" : "");
                    }
                }
                else if (ckb.Equals(ckbFEmail))
                {
                    if (!string.IsNullOrEmpty(txtEmail.Text))
                    {
                        filterStr.Append(isChecked ? $" AND Email LIKE '%{txtEmail.Text}%'" : "");
                    }
                }
                else
                {
                    // 処理無し
                }
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
            dgvData.DataSource = dtShow;
        }
    }
}
