using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public string Goods_type_nm;

        public string GoodsID { get; set; }
        public string GoodsName { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get  ; set ; }
        public int GoodsTypeID { get ; set; }
        public decimal PriceBuy { get; set; }
        public decimal PriceSell { get ; set; }
        public string TypeName { get ; set ; }
        public int UnitID { get ; set; }
        public string UnitName { get ; set ; }

        public static Product ConvertToObj(DataRow dr)
        {
            return new Product()
            {
                GoodsID = dr["MaHang"].ToString(),
                GoodsName = dr["TenHangHoa"].ToString(),
                BrandID = int.Parse(dr["Hang"].ToString()),
                SupplierID = int.Parse(dr["NhaCungCap"].ToString()),
                GoodsTypeID = int.Parse(dr["NhomHang"].ToString()),
                PriceBuy = decimal.Parse(dr["DonGiaMua"].ToString()),
                PriceSell = decimal.Parse(dr["DonGiaBan"].ToString()),
                UnitID = int.Parse(dr["DonViTinh"].ToString())
            };
        }
    }
}
