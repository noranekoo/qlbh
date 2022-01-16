using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        public static CustomerDAL Instance { get; set; } = new CustomerDAL();


        public DataTable GetCustomerList()
        {
            OleDbParameter[] pa = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("KhachHang", pa, "*");
            }
            catch(Exception e)
            {
                return null;
                throw e;
            }
        }
    }
}
