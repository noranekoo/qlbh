using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public class TabControlCustom : TabControl
    {
        public TabControlCustom()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (this.SelectedTab == this.TabPages[e.Index])
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.White), e.Bounds);
            }
            else
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.LightGray), e.Bounds);
            }

            this.TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            this.TabPages[e.Index].ForeColor = Color.Black;

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-1, -1);

            e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, SystemBrushes.WindowText, paddedBounds);
        }

        
        
    }
}
