using QLBH.Pages.Cooperation;
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

namespace QLBH.Pages
{
    /// <summary>
    /// 共同経営のフォームクラス
    /// 2022/01/15
    /// テイ
    /// </summary>
    public partial class frmCooperation : Form
    {
        public frmCooperation()
        {
            InitializeComponent();
            frmCustomer frmCus = new frmCustomer();
            frmGeneral frmGeneral = new frmGeneral();
            //タップページにフォームをセット処理
            FormHandler.SetTabContent(tabControl,frmCus);
        }
    }
}
