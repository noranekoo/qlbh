using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static QLBH.Resources.FormHandler;

namespace QLBH.Resources
{
    public partial class MessageCustom : Form
    {
        public MessageCustom()
        {
            InitializeComponent();
        }
        

        public string MessageTitle { set; get; }
        public string Message { set; get; }
        public FormHandler.MessageIcon MessageIcon { set; get; }
        
    }
}
