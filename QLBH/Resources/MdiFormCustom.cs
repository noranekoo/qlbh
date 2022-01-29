using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public class MdiFormCustom : Form
    {
        public MdiFormCustom()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        protected bool IsFormExists(string formName)
        {
            return MdiChildren.Count((Form f) => f.Name.Equals(formName)) == 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formName"></param>
        protected void FocusToForm(string formName)
        {
            MdiChildren.FirstOrDefault((Form f) => f.Name.Equals(formName))?.Focus();
        }
        
        /// <summary>
        /// 
        /// </summary>
        protected void ClearAllMdiClient()
        {
            List<Form> forms = MdiChildren.ToList();
            foreach (Form f in forms)
            {
                f.Dispose();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formName"></param>
        /// <param name="obj"></param>
        /// <param name="isDialog"></param>
        protected void ShowForm(string formName, object obj, bool isDialog)
        {
            if (!IsFormExists(formName))
            {
                Form f = obj as Form;
                if (isDialog)
                {
                    f.ShowDialog(this);
                }
                else
                {
                    f.TopLevel = true;
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                FocusToForm(formName);
            }
        }
    }
}
