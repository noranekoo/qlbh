using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public partial class TabButtonCustom : UserControl
    {
        Dictionary<string, Image> images = new Dictionary<string, Image>()
        {
            {"close_unclick", Properties.Resources.close_unclick },
            {"close_clicked", Properties.Resources.close_clicked },
        };
        public TabButtonCustom()
        {
            InitializeComponent();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            FormHandler.ControlImageChange(btnClose, images["close_clicked"]);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            FormHandler.ControlImageChange(btnClose, images["close_unclick"]);
        }
    }
}
