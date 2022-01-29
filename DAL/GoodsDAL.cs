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

        public static GoodsDAL Instance { get; set; } = new GoodsDAL();

        public DataTable GetProductList()
        {
            OleDbParameter[] pa = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("HangHoa", pa, "*");
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        //public static List<Goods> GetData()
        //{
        //    try
        //    {
        //        List<Goods> list = new List<Goods>();
        //        OleDbParameter[] param = new OleDbParameter[0];
        //        DataTable dt = DataProvider.Instance.SelectData("HangHoa", param, "*");
        //        foreach(DataRow dr in dt.Rows)
        //        {
        //            list.Add(ConvertToDTO(dr));
        //        }
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //        throw e.InnerException;
        //    }   
        //}
       

        private static Product ConvertToDTO(DataRow dr)
        {
            Brand brand = BrandDAL.GetBrand(int.Parse(dr["Hang"].ToString()));
            Supplier supplier = SupplierDAL.Instance.GetSupplier(int.Parse(dr["NhaCungCap"].ToString()));
            GoodsType type = GoodsTypeDAL.GetGoodsType(int.Parse(dr["Nhom"].ToString()));
            Unit unit = UnitDAL.Instance.GetUnit(int.Parse(dr["DonViTinh"].ToString()));
            return new Product()
            {
                GoodsID = dr["MaHang"].ToString(),
                GoodsName = dr["TenHang"].ToString(),
                BrandID = brand.BrandId,
                BrandName = brand.BrandName,
                SupplierID = supplier.SupplierID,
                SupplierName = supplier.SupplierName,
                PriceBuy = decimal.Parse(dr["DonGiaMua"].ToString()),
                PriceSell = decimal.Parse(dr["DonGiaBan"].ToString()),
                GoodsTypeID = type.GoodsTypeID,
                TypeName = type.GoodsTypeName,
                UnitID = unit.Id,
                UnitName = unit.Unit_name 
            };
        }

        
    }
}
