using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Payment
    {
        public int ID { get; set; }
        public string PaymentName { get; set; }

        public Payment(int _id, string _pName)
        {
            ID = _id;
            PaymentName = _pName;
        }
    }
}
