using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public class FormCustom : Form
    {
        public bool HasReturned { get; set; } = false;
        public bool IsAllowReset { get; set; } = true;
        public bool HasDataChanged { get; set; }
        //public DataTable TempData { get; set; } = null;
        //public DataTable FullData { get; set; } = null;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //if (HasDataChanged)
            //{
            //    DialogResult result = FormHandler.ShowWarningMessage("Dữ liệu chưa được lưu, bạn có muốn lưu trước khi đóng?", true);
            //    if(result== DialogResult.OK)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
            DialogResult result = FormHandler.ShowWarningMessage("Bạn có chắc chắn muốn tắt màn hình này?", true);
            if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            Button btnSelect = GetButtonByName("btnSelect");
            //Button btnSave = GetButtonByName("btnSave");
            Button btnReset = GetButtonByName("btnReset");
            if(!btnSelect.Equals(null))
            {
                btnSelect.Visible = HasReturned;
                //btnSelect.Location = btnSave.Location;
            }
            //if (!btnSave.Equals(null))
            //{
            //    btnSave.Visible = !HasReturned;
            //}
            if (!btnReset.Equals(null))
            {
                btnReset.Enabled = IsAllowReset;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="containerControl">If null is FormContainer</param>
        /// <returns></returns>
        public Button GetButtonByName(string name, Control containerControl = null)
        {
            if(containerControl is null)
            {
                foreach(Control c in Controls)
                {
                    if((c is Button || c is ButtonCustom) && c.Name.Equals(name))
                    {
                        return c as Button;
                    }
                }
            }
            else
            {
                foreach (Control c in containerControl.Controls)
                {
                    if ((c is Button || c is ButtonCustom) && c.Name.Equals(name))
                    {
                        return c as Button;
                    }
                }
            }
            return null;
        }
    }
}
