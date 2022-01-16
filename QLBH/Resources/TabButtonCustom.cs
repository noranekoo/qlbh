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

        private EventHandler closeClick;
        private EventHandler onClick;

        public event EventHandler CloseClick
        {
            add
            {
                closeClick += value;
            }
            remove
            {
                closeClick -= value;
            }
        }
        public event EventHandler Clicked
        {
            add
            {
                onClick += value;
            }
            remove
            {
                onClick -= value;
            }
        }
        public int Index { get; set; }
        public string TitleText { get; set; }
        public Color ActiveBkColor { get; set; }
        public Color DeactiveBkColor { get; set; }
        public Color ActiveFColor { get; set; }
        public Color DeactiveFColor { get; set; }
        public bool IsActived
        {
            get
            {
                return IsActived;
            }
            set
            {
                this.BackColor = value ? ActiveBkColor : DeactiveBkColor;
                this.lblText.ForeColor = value ? ActiveFColor : DeactiveFColor;
            }
        }
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

        private void TabButtonCustom_Paint(object sender, PaintEventArgs e)
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            lblText.Text = TitleText;
            Width = lblText.Width + btnClose.Width + 10;
            base.OnPaint(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeClick(this, e);
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            TabButtonCustom_Click(this, e);
        }

        private void TabButtonCustom_Click(object sender, EventArgs e)
        {
            onClick(this,e);
        }
    }
}
