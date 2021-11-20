using System;
using System.Text;
using DTO;
using DAL;
namespace DataSeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------USER SEEDER---------------------------");
            int result = 0;
            bool isSuccess = false;
            do
            {
                Console.Write("Nhap so luong tai khoan can tao: ");
                string accNum = Console.ReadLine();
                isSuccess = int.TryParse(accNum, out result);
            } while (!isSuccess);
            Console.Write("Nhap mat khau mac dinh: ");
            string pwd = Console.ReadLine();
            for(int i = 0; i < result; i++)
            {
                string usname = GenerateTextString(10);
                User user = new User(usname, pwd);
                UserDAL.AddUser(user)
            }
            Console.WriteLine($"Mat khau mac dinh la: {pwd}");
            Console.ReadKey();
        }

        static string GenerateTextString(int len)
        {
            int[] mm = { 97, 122 };
            Random rd = new Random();
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < len; i++)
            {
                char s = (char)rd.Next(mm[0], mm[1]);
                str.Append(s);
            }
            return str.ToString();
        }

        static string GenerateKey()
        {
            return "xxxxxxxxxxxxxxxxxxxxx";
        }
    }
}
