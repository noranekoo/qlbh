using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Pages
{
    public partial class frmBackupData : Form
    {
        public frmBackupData()
        {
            InitializeComponent();
        }
        //Nơi chứa file dữ liệu
        string file = "db.accdb";
        /// <summary>
        /// Xử lý chức năng backup dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackup_Click(object sender, EventArgs e)
        {
            string path = txtFolderLocation.Text;
            string fileName = path + "\\db.accdb.backup";
            if (File.Exists(file))
            {
                File.Copy(file, fileName);
                MessageBox.Show("Đã backup dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Oops, dữ liệu đâu mất rồi?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Chọn thư mục cho chức năng backup dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialg = folderBrowserDialog.ShowDialog();
            if(dialg == DialogResult.OK)
            {
                txtFolderLocation.Text = folderBrowserDialog.SelectedPath;
                btnBackup.Enabled = true;
            }
        }
        /// <summary>
        /// Chọn file dữ liệu cho chức năng khôi phục dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup|*.backup";
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }

        }
        /// <summary>
        /// Xử lý chức năng khôi phục dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            if (File.Exists(fileName))
            {
                if (File.Exists(file))
                {
                    DialogResult s = MessageBox.Show("Có file dữ liệu đang tồn tại. Bạn có muốn chép đè lên dữ liệu cũ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (s == DialogResult.Yes)
                    {
                        File.Copy(fileName, file);
                        MessageBox.Show("Đã khôi phục dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Không thực hiện lệnh
                    }
                }
                else
                {
                    File.Copy(fileName, file);
                    MessageBox.Show("Đã khôi phục dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Oops, dữ liệu đâu mất rồi?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
