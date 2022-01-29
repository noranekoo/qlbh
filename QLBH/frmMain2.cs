using QLBH.Pages;
using QLBH.Pages.Celebration;
using QLBH.Pages.Cooperation;
using QLBH.Pages.Goods;
using QLBH.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMain2 : MdiFormCustom
    {

        public frmMain2()
        {
            InitializeComponent();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmImportGoods frm = new frmImportGoods();
            //frm.MdiParent = this;
            //frm.Show();
            frmGoods frm = new frmGoods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExportGoods frm = new frmExportGoods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void backupDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupData frm = new frmBackupData();
            //frm.MdiParent = this;
            frm.ShowDialog(this);
        }

        private void frmMain2_Shown(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            DialogResult result = frm.ShowDialog(this);
            if (result == DialogResult.OK)
            {

            }
            else if(result == DialogResult.No)
            {

            }
            else
            {
                Dispose();
            }
        }
        
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm("frmCustomer", new frmCustomer(), false);
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm("frmSupplier", new frmSupplier(), false);
        }

        private void quảnLýCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm("frmDebit", new frmDebit(), false);
        }

        private void thiếtLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm("frmSettings", new frmSettings(), true);
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearAllMdiClient();
            FormHandler.UserInfo = null;
            frmMain2_Shown(null, null);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kiểmTraTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHandler.ShowInfoMessage("Chức năng đang hoàn thiện");
        }
    }
}
