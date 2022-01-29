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
        public static BrandDAL Instance { get; set; } = new BrandDAL();
        
        public DataTable 
            GetBrandList()
        {
            OleDbParameter[] parameters = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("Hang", parameters, "*");
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }
        }

        public static Brand GetBrand(int id)
        {
            try
            {
                OleDbParameter[] param = new OleDbParameter[1]
                {
                    new OleDbParameter("maHang", id),
                };
                DataTable dt = DataProvider.Instance.SelectData("Hang", param, "*", "MaHang=@maHang");
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

        public static void UpdateData(string tbName, DataTable dt)
        {
            try
            {
                DataProvider.Instance.UpdateData(tbName, dt, "*");
            }
            catch(Exception e)
            {
                throw e;
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
