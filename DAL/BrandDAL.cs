using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BrandDAL
    {
        public static Brand GetBrand(int id)
        {
            try
            {
                OleDbParameter[] param = new OleDbParameter[1]
                {
                    new OleDbParameter("maHang", id),
                };
                DataTable dt = DataProvider.GetInstance().SelectData("Hang", param, "*", "MaHang=@maHang");
                if(dt != null && dt.Rows.Count > 0)
                {
                    return ConvertToDTO(dt.Rows[0]);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }
            
        }

        private static Brand ConvertToDTO(DataRow dr)
        {
            return new Brand()
            {
                BrandId = int.Parse(dr["MaHang"].ToString()),
                BrandName = dr["TenHang"].ToString()  
            };
        }
    }
}
