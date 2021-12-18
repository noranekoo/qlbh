using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class GoodsBUS
    {
        public GoodsBUS()
        {

        }
        public static List<Goods> GetData()
        {
            try
            {
                return GoodsDAL.GetData();
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }
            
        }
    }
}
