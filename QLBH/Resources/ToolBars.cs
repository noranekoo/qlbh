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
            get => TextT1 ?? string.Empty;
            set { TextT1 = value; btnAdd.Text = value; }
        }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT2
        {
            get => TextT2 ?? string.Empty; 
            set { TextT2 = value; btnEdit.Text = value; }
        }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT3
        {
            get => TextT3 ?? string.Empty; 
            set { TextT3 = value; btnDelete.Text = value; }
        }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT4
        {
            get => TextT4 ?? string.Empty; 
            set { TextT4 = value; btnPrint.Text = value; }
        }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Text")]
        public string TextT5
        {
            get => TextT5 ?? string.Empty; 
            set { TextT5 = value; btnExcelExport.Text = value; }
        }
        /// <summary>
        /// Button Background
        /// </summary>
        [Category("Button 1"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT1 { get; set; }
        [Category("Button 2"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT2 { get; set; }
        [Category("Button 3"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT3 { get; set; }
        [Category("Button 4"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT4 { get; set; }
        [Category("Button 5"), Description("Không có mô tả"), DisplayName("Background Color")]
        public Color BColorT5 { get; set; }
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

        public ToolBars()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            SetButtonStyles();
            SetButtonText();
        }

        void SetButtonText()
        {

        }

        void SetButtonStyles()
        {

        }
    }
}
