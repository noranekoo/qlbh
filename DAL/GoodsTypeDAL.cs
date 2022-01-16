using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GoodsTypeDAL
    {
        public static List<GoodsType> GetGoodsTypeList()
        {
            try
            {
                List<GoodsType> list = new List<GoodsType>();
                OleDbParameter[] param = new OleDbParameter[0];
                DataTable dt = DataProvider.Instance.SelectData("NhomHang", param, "*");
                if(dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        list.Add(ConvertToDTO(dr));
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }
        }

        public static GoodsType GetGoodsType(int id)
        {
            try
            {
                OleDbParameter[] param = new OleDbParameter[1]
                {
                    new OleDbParameter("nhomHang", id)
                };
                DataTable dt = DataProvider.Instance.SelectData("NhomHang", param, "*", "MaNhom=@nhomHang");
                if (dt != null && dt.Rows.Count > 0)
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
        private static GoodsType ConvertToDTO(DataRow dr)
        {
            return new GoodsType()
            {
                GoodsTypeID = int.Parse(dr["MaNhom"].ToString()),
                GoodsTypeName = dr["TenNhom"].ToString(),
            };
        }
    }
}
