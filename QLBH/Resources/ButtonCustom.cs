using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public class ButtonCustom : Button
    {
        private int _cnt = 0;
        private bool _isActive = false;

        public bool EnableChangeImageClick { get; set; } = false;
        public Image FirstClickImage { get; set; }
        public Image SecondClickImage { get; set; }

        public bool IsActive 
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                OnStateChanged();
                //this.Invalidate();
            }
        }
        public Color ActiveColor { get; set; }
        public Color DeactiveColor { get; set; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            this.Cursor = Cursors.Hand;
            //Invalidate();
        }

        void OnStateChanged()
        {
            this.BackColor = _isActive ? ActiveColor : DeactiveColor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (EnableChangeImageClick)
            {
                _cnt = _cnt == 0 ? 1 : 0;
                this.Image = _cnt == 1 ? FirstClickImage : SecondClickImage;
            }
            
        }
    }
}
