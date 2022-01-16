using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class SupplierDAL
    {
        public static SupplierDAL Instance { get; set; } = new SupplierDAL();

        public DataTable GetSupplierList()
        {
            OleDbParameter[] pa = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("NhaCungCap", pa, "*");
            }
            catch(Exception e)
            {
                return null;
                throw e;
            }
        }

        public Supplier GetSupplier(int id)
        {
            try
            {
                OleDbParameter[] param = new OleDbParameter[1]
                {
                    new OleDbParameter("mancc", id)
                };
                string whereStr = "MaNCC=@mancc";
                DataTable dt = DataProvider.Instance.SelectData("NhaCungCap", param, "*", whereStr);
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
        private Supplier ConvertToDTO(DataRow dr)
        {
            return new Supplier()
            {
                SupplierID = int.Parse(dr["MaNCC"].ToString()),
                SupplierName = dr["TenNCC"].ToString(),
                Address = dr["DiaChi"].ToString(),
                Phone = dr["SDT"].ToString(),
                Email = dr["Email"].ToString()
            };
        }
    }
}
