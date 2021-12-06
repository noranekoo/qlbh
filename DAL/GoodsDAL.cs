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
    public class GoodsDAL
    {
        public GoodsDAL()
        {

        }

        public static List<Goods> GetData()
        {
            try
            {
                List<Goods> list = new List<Goods>();
                OleDbParameter[] param = new OleDbParameter[0];
                DataTable dt = DataProvider.GetInstance().SelectData("HangHoa", param, "*");
                foreach(DataRow dr in dt.Rows)
                {
                    list.Add(ConvertToDTO(dr));
                }
                return list;
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }   
        }

        //public static GoodsType GetGoodsType(int id)
        //{
        //    try
        //    {
        //        OleDbParameter[] param = new OleDbParameter[1]
        //        {
        //            new OleDbParameter("nhomHang", id)
        //        };
        //        DataTable dt = DataProvider.GetInstance().SelectData("NhomHang", param, "*", "MaNhom=@nhomHang");
        //        if(dt != null && dt.Rows.Count > 0)
        //        {
        //            return null;
        //        }
        //        return null;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //        throw e.InnerException;
        //    }
        //}

        private static Goods ConvertToDTO(DataRow dr)
        {
            Brand brand = BrandDAL.GetBrand(int.Parse(dr["Hang"].ToString()));
            Supplier supplier = SupplierDAL.GetSupplier(int.Parse(dr["NhaCungCap"].ToString()));
            return new Goods()
            {
                Goods_id = dr["MaHang"].ToString(),
                Goods_name = dr["TenHang"].ToString(),
                Brand_id = brand.BrandId,
                Brand_name = brand.BrandName,
                Supplier_id = supplier.SupplierID,
                Supplier_name = supplier.SupplierName,
                Goods_price_buy = dr["DonGiaMua"].ToString(),
                Goods_price_sell = dr["DonGiaBan"].ToString(),
                Goods_type = dr["Nhom"].ToString()
            };
        }

        //private static GoodsType ConvertToDTO(DataRow dr)
        //{
        //    return new GoodsType()
        //    {
        //        GoodsTypeID = int.Parse(dr["MaNhom"].ToString()),
        //        GoodsTypeName = dr["TenNhom"].ToString(),
        //    };
        //}
    }
}
