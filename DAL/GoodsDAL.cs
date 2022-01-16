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
                DataTable dt = DataProvider.Instance.SelectData("HangHoa", param, "*");
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
       

        private static Goods ConvertToDTO(DataRow dr)
        {
            Brand brand = BrandDAL.GetBrand(int.Parse(dr["Hang"].ToString()));
            Supplier supplier = SupplierDAL.Instance.GetSupplier(int.Parse(dr["NhaCungCap"].ToString()));
            GoodsType type = GoodsTypeDAL.GetGoodsType(int.Parse(dr["Nhom"].ToString()));
            Unit unit = UnitDAL.Instance.GetUnit(int.Parse(dr["DonViTinh"].ToString()));
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
                Goods_type_Id = type.GoodsTypeID,
                Goods_type_nm = type.GoodsTypeName,
                Unit_id = unit.Id,
                Unit_name = unit.Unit_name 
            };
        }

        
    }
}
