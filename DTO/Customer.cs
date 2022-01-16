using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //public TimeStamps TimeStamps { get; set; }
        //public InfoStamps InfoStamps { get; set; }
        public Customer()
        {

        }
    }
}
