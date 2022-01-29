using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = "";
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //public TimeStamps TimeStamps { get; set; }
        //public InfoStamps InfoStamps { get; set; }
        public Customer()
        {

        }

        public static Customer ConvertToObj(DataRow dr)
        {
            return new Customer()
            {
                CustomerID = int.Parse(dr["ID"].ToString()),
                CustomerName = dr["TenKH"].ToString(),
                Address = dr["DiaChi"].ToString(),
                Phone = dr["SDT"].ToString(),
                Email = dr["Email"].ToString(),
            };
        }

        
    }
}
