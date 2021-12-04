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
        public Color FColorT1 { get; set; }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT2 { get; set; }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT3 { get; set; }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT4 { get; set; }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Foreground Color")]
        public Color FColorT5 { get; set; }
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
        public Image ImageT1 { get; set; }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT2 { get; set; }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT3 { get; set; }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT4 { get; set; }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Icon")]
        public Image ImageT5 { get; set; }
        #endregion

        #region Events
        private EventHandler buttonClick;
        /// <summary>
        /// Xử lý sự kiện
        /// </summary>
        [Description("Không có mô tả"), DisplayName("ItemClick")]
        public event EventHandler FClick
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }
    }
}
