using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace QLBH.Resources
{
    public partial class ToolBars : UserControl
    {
        #region Properties
        /// <summary>
        /// Button Text
        /// </summary>
        [Category("Button 1"),Description("Không có mô tả"), DisplayName("Text")]
        public string TextT1
        {
            get => btnAdd.Text;
            set { btnAdd.Text = value; }
        }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT2
        {
            get => btnEdit.Text; 
            set { btnEdit.Text = value; }
        }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT3
        {
            get => btnDelete.Text; 
            set { btnDelete.Text = value; }
        }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT4
        {
            get => btnPrint.Text; 
            set { btnPrint.Text = value; }
        }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT5
        {
           get => btnExcelExport.Text; 
            set { btnExcelExport.Text = value; }
        }
        /// <summary>
        /// Button Background
        /// </summary>
        [Category("Button 1"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT1
        {
            get => btnAdd.BackColor;
            set
            {
                btnAdd.BackColor = value;
            }
        }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT2
        {
            get => btnEdit.BackColor;
            set
            {
                btnEdit.BackColor = value;
            }
        }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT3
        {
            get => btnDelete.BackColor;
            set
            {
                btnDelete.BackColor = value;
            }
        }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT4 
        {
            get => btnPrint.BackColor;
            set
            {
                btnPrint.BackColor = value;
            }
        }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT5
        {
            get => btnExcelExport.BackColor;
            set
            {
                btnExcelExport.BackColor = value;
            }
        }
        /// <summary>
        /// Button Foreground
        /// </summary>
        [Category("Button 1"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT1
        {
            get => btnAdd.ForeColor;
            set
            {
                btnAdd.ForeColor = value;
            }
        }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT2
        {
            get => btnEdit.ForeColor;
            set
            {
                btnEdit.ForeColor = value;
            }
        }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT3
        {
            get => btnDelete.ForeColor;
            set
            {
                btnDelete.ForeColor = value;
            }
        }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT4
        {
            get => btnPrint.ForeColor;
            set
            {
                btnPrint.ForeColor = value;
            }
        }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT5
        {
            get => btnExcelExport.ForeColor;
            set
            {
                btnExcelExport.ForeColor = value;
            }
        }
        /// <summary>
        /// Button Enabled
        /// </summary>
        [Category("Button 1"), Description("Không có mô tả"), DisplayName("Enabled Color")]
        public bool EnableT1 { get; set; } = true;
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Enabled Color")]
        public bool EnableT2 { get; set; } = true;
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Enabled Color")]
        public bool EnableT3 { get; set; } = true;
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Enabled Color")]
        public bool EnableT4 { get; set; } = true;
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Enabled Color")]
        public bool EnableT5 { get; set; } = true;
        /// <summary>
        /// Button Icon
        /// </summary>
        [Category("Button 1"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT1
        {
            get => btnAdd.Image;
            set
            {
                if(value == null)
                {
                    btnAdd.Image = null;
                }
                else
                {
                    btnAdd.Image = value;
                }
            }
        }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT2
        {
            get => btnEdit.Image;
            set
            {
                if (value == null)
                {
                    btnEdit.Image = null;
                }
                else
                {
                    btnEdit.Image = value;
                }
            }
        }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT3
        {
            get => btnDelete.Image;
            set
            {
                if (value == null)
                {
                    btnDelete.Image = null;
                }
                else
                {
                    btnDelete.Image = value;
                }
            }
        }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT4
        {
            get => btnPrint.Image;
            set
            {
                if (value == null)
                {
                    btnPrint.Image = null;
                }
                else
                {
                    btnPrint.Image = value;
                }
            }
        }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT5
        {
            get => btnExcelExport.Image;
            set
            {
                if (value == null)
                {
                    btnExcelExport.Image = null;
                }
                else
                {
                    btnExcelExport.Image = value;
                }
            }
        }
        #endregion

        #region Events
        private CustomEventHandler buttonClick;
        /// <summary>
        /// Xử lý sự kiện
        /// </summary>
        [Description("Không có mô tả"), DisplayName("ItemClick")]
        public event CustomEventHandler FClick
        {
            add
            {
                buttonClick += value;
            }
            remove
            {
                buttonClick -= value;
            }
        }
        #endregion

        public ToolBars()
        {
            InitializeComponent();
        }

        private int GetKey(object sender)
        {
            if (sender is Button btn)
            {
                if (btn == btnAdd) return 1;
                if (btn == btnEdit) return 2;
                if (btn == btnDelete) return 3;
                if (btn == btnPrint) return 4;
                return 5;
            }
            else
            {
                return -1;
            }
        }

        private CustomEvent GetEvent(object sender)
        {
            return new CustomEvent(GetKey(sender));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(buttonClick != null)
            {
                buttonClick(sender, GetEvent(sender));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (buttonClick != null)
            {
                buttonClick(sender, GetEvent(sender));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (buttonClick != null)
            {
                buttonClick(sender, GetEvent(sender));
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (buttonClick != null)
            {
                buttonClick(sender, GetEvent(sender));
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            if (buttonClick != null)
            {
                buttonClick(sender, GetEvent(sender));
            }
        }
    }
}
