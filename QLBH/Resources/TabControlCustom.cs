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
            DrawControl(e.Graphics);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (this.SelectedTab == this.TabPages[e.Index])
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);
            }

            //this.TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            this.TabPages[e.Index].ForeColor = Color.Black;

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);

            e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlDark, paddedBounds);
            Rectangle closeBound = e.Bounds;
            closeBound.Inflate(-10, -10);
            e.Graphics.DrawImage(Properties.Resources.power, closeBound);
        }

        internal void DrawControl(Graphics g)
        {
            if (!Visible)
                return;

            Rectangle TabControlArea = this.ClientRectangle;
            Rectangle TabArea = this.DisplayRectangle;

            //----------------------------
            // fill client area
            Brush br = new SolidBrush(SystemColors.Control);
            g.FillRectangle(br, TabControlArea);
            br.Dispose();
            //----------------------------

            //----------------------------
            // draw border
            int nDelta = SystemInformation.Border3DSize.Width;

            Pen border = new Pen(SystemColors.ControlDark);
            TabArea.Inflate(nDelta, nDelta);
            g.DrawRectangle(border, TabArea);
            border.Dispose();
            //----------------------------
           
        }
        
    }
}
