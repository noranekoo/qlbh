using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public Brand()
        {

        }
        public Brand(int b_id, string b_name)
        {
            BrandId = b_id;
            BrandName = b_name;
        }
    }
}
