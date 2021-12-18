using DAL;
using QLBH.Pages;
using QLBH.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMain : Form
    {

        private readonly List<TabButtonCustom> tabButtons = null;
        private readonly Dictionary<int, TabPage> tpList = null;

        private TabPage welcomeTab;
        private int tabIndex = 0;

        private bool isReadyMove = false;
        private bool isToggleBar = false;

        private const int LBAR_MAX_WIDTH = 160;
        private const int LBAR_MIN_WIDTH = 35;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        private Point mPt;
        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            tpList = new Dictionary<int, TabPage>();
            tabButtons = new List<TabButtonCustom>();
            lblFullName.Text = FormHandler.UserInfo.FullName;
            welcomeTab = new TabPage("Welcome");
            frmWelcome frm = new frmWelcome();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            welcomeTab.Controls.Add(frm);
            frm.Show();
            tabPage.TabPages.Add(welcomeTab);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
            rc = new Rectangle(0, 0, ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isReadyMove = true;
            mPt = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isReadyMove)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - mPt.X, p.Y - mPt.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isReadyMove = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            FormWindowState state = WindowState;
            if(state == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void lblFullName_Paint(object sender, PaintEventArgs e)
        {
            Point p = new Point(btnLogout.Location.X - lblFullName.Width - 5, lblFullName.Location.Y);
            lblFullName.Location = p;
        }

        private void btnSettings_Paint(object sender, PaintEventArgs e)
        {
            Point p = new Point(lblFullName.Location.X - btnSettings.Width - 5, btnSettings.Location.Y);
            btnSettings.Location = p;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnToggleBar_Click(object sender, EventArgs e)
        {
            isToggleBar = !isToggleBar;
            int width = isToggleBar ? LBAR_MIN_WIDTH : LBAR_MAX_WIDTH;
            pnlLeftBar.Width = width;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog(this);
        }

        private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            tabIndex = 0;
            frmGeneral frm = new frmGeneral();
            AddTabPage(tabIndex, "Tổng quan", frm);
        }

        private void btnCelebration_Click(object sender, EventArgs e)
        {
            tabIndex = 1;
            frmCelebration frm = new frmCelebration();
            AddTabPage(tabIndex, "Tổ chức", frm);
        }

        private void btnCooperation_Click(object sender, EventArgs e)
        {
            tabIndex = 2;
            frmCooperation frm = new frmCooperation();
            AddTabPage(tabIndex, "Đối tác", frm);
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            tabIndex = 3;
            frmGoods frm = new frmGoods();
            AddTabPage(tabIndex, "Hàng hoá", frm);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            tabIndex = 4;
            frmReport frm = new frmReport();
            AddTabPage(tabIndex, "Báo cáo", frm);
        }
        private void btnGoodsIE_Click(object sender, EventArgs e)
        {
            tabIndex = 5;
            frmGoodsIE frm = new frmGoodsIE();
            AddTabPage(tabIndex, "Nhập-xuất hàng", frm);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="title"></param>
        /// <param name="frm"></param>
        private void AddTabPage(int key, string title, Form frm)
        {
            if (IsTabExist(tabIndex))
            {
                MessageBox.Show(Const.GetMessageByCode("M01"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage.SelectedTab = (TabPage)tpList[tabIndex];
                TabSelectedIndexChanged();
                return;
            }
            if (tabPage.TabPages.Contains(welcomeTab))
            {
                tabPage.TabPages.Remove(welcomeTab);
            }
            TabPage tp = new TabPage(title);
            frm.TopLevel = false;
            tp.Controls.Add(frm);
            tabPage.TabPages.Add(tp);
            frm.Dock= DockStyle.Fill;
            frm.Show();
            tpList.Add(key, tp);
            DrawTabPage();
            tabPage.SelectedTab = tp;
        }

        /// <summary>
        /// Hiển thị các tab đang mở
        /// </summary>
        void DrawTabPage()
        {
            flowTool.Controls.Clear();
            TabButtonCustom oldTab = new TabButtonCustom()
            {
                Location = new Point(5, 8),
                Size = new Size(0,0)
            };
            foreach (int s in tpList.Keys)
            {
                TabButtonCustom tab = new TabButtonCustom()
                {
                    TitleText = tpList[s].Text,
                    Index = s,
                    Tag = tpList[s],
                    ActiveBkColor = Color.White,
                    DeactiveBkColor = Color.Black,
                    ActiveFColor = Color.Black,
                    DeactiveFColor = Color.White,
                    IsActived = tabIndex == s
                };
                tab.CloseClick += Tab_CloseClick;
                tab.Clicked += Tab_Clicked;
                flowTool.Controls.Add(tab);
                tabButtons.Add(tab);
                oldTab = tab;
            }            
        }

        private void Tab_Clicked(object sender, EventArgs e)
        {
            TabButtonCustom tbtn = sender as TabButtonCustom;
            tabIndex = tbtn.Index;
            TabPage tp = tbtn.Tag is TabPage page ? page : null;
            if(tp != null)
            {
                tabPage.SelectedTab = tp;
            }
            TabSelectedIndexChanged();
        }
        /// <summary>
        /// Đóng một tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tab_CloseClick(object sender, EventArgs e)
        {
            TabButtonCustom btn = sender as TabButtonCustom;
            RemoveTabPage((TabPage)btn.Tag, btn);
        }
        
        /// <summary>
        /// Xử lý xoá một tab
        /// </summary>
        /// <param name="tp"></param>
        /// <param name="tbc"></param>
        private void RemoveTabPage(TabPage tp, TabButtonCustom tbc)
        {
            tabPage.TabPages.Remove(tp);
            flowTool.Controls.Remove(tbc);
            tabButtons.Remove(tbc);
            tpList.Remove(tbc.Index);
            DrawTabPage();
        }

        /// <summary>
        /// Kiểm tra một tab có đang tồn tại
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool IsTabExist(int index)
        {
            return tpList.ContainsKey(index);
        }

        /// <summary>
        /// Xử lý khi chọn một tab
        /// </summary>
        private void TabSelectedIndexChanged()
        {
            for(int i = 0; i < tabButtons.Count; i++)
            {
                if(tabButtons[i].Index == tabIndex)
                {
                    tabButtons[i].IsActived = true;
                }
                else
                {
                    tabButtons[i].IsActived = false;
                }
            }
        }

        private void btnBackup_Paint(object sender, PaintEventArgs e)
        {
            Point p = new Point(btnSettings.Location.X - this.btnBackup.Width - 5, btnBackup.Location.Y);
            btnBackup.Location = p;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackupData frm = new frmBackupData();
            frm.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Const.GetMessageByCode("M03"), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Dispose();
                int rlt = UserDAL.Instance.SaveSession(FormHandler.UserInfo.Info,true);
                if(rlt != -1)
                {
                    FormHandler.frmLogin.Show();
                    FormHandler.UserInfo = null;
                }
                else
                {
                    MessageBox.Show("Có lỗi khi đăng xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormHandler.frmLogin.Dispose();
                }
            }
            
        }

        private void lklInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Tắt hoàn toàn chương trình
            DialogResult dialog = MessageBox.Show(Const.GetMessageByCode("M02"), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                FormHandler.frmLogin.Dispose();
            }
        }
    }
}
