using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class GoodsBUS
    {
        public GoodsBUS()
        {

        }
        public static DataTable GetData()
        {
            try
            {
                return null;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
            
        }
    }
}
