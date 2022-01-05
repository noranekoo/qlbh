using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Celebration
{
    public class DepartDAL
    {
        /// <summary>
        /// 
        /// </summary>
        public static DepartDAL Instance { get; set; } = new DepartDAL();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbName"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public DataTable GetDepartList()
        {
            OleDbParameter[] pa = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("BoPhan", pa, "*");
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public bool Update(DataTable dt)
        {
            try
            {
                DataProvider.Instance.UpdateData("BoPhan", dt);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
    }
}
