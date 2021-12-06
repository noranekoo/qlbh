using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Goods
    {
        string goods_id;
        string goods_name;
        int brand_id;
        string brand_name;
        int supplier_id;
        string supplier_name;
        string goods_type;
        string goods_price_buy;
        string goods_price_sell;

        public string Goods_id { get => goods_id; set => goods_id = value; }
        public string Goods_name { get => goods_name; set => goods_name = value; }
        public int Brand_id { get => brand_id; set => brand_id = value; }
        public string Brand_name { get => brand_name; set => brand_name = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
        public string Supplier_name { get => supplier_name; set => supplier_name = value; }
        public string Goods_type { get => goods_type; set => goods_type = value; }
        public string Goods_price_buy { get => goods_price_buy; set => goods_price_buy = value; }
        public string Goods_price_sell { get => goods_price_sell; set => goods_price_sell = value; }
    }
}
