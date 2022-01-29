using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        public string BillID { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
        public string CusPhone { get; set; }
        public string EmpPhone { get; set; }
        public int PaymentID { get; set; }
        public string Payment { get; set; }
        public Bill()
        {

        }

        public static Bill ConvertToObj(DataRow dr, object obj1, object obj2)
        {
            Employee emp = obj1 as Employee;
            Customer cus = obj2 as Customer;
            return new Bill()
            {
                BillID = dr["ID"].ToString(),
                Customer = cus,
                Employee = emp,
                DeliveryDate = DateTime.Parse(dr["NgayGiao"].ToString()),
                Address = dr["DiaChi"].ToString(),
                CusPhone = dr["SDTKH"].ToString(),
                EmpPhone = dr["SDTNV"].ToString(),
                PaymentID = int.Parse(dr["HinhThucThanhToan"].ToString()),
                Payment = int.Parse(dr["HinhThucThanhToan"].ToString()).Equals(0) ? "Chuyển khoản": "Tiền mặt",
            };
        }
    }
}
