using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class Encrypto
    {
        /// <summary>
        /// Thực hiện hash văn bản bằng thuật toán SHA256 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SHAHash(string text) 
        {
            SHA256 sha = new SHA256Managed();
            byte [] result = sha.ComputeHash(Encoding.ASCII.GetBytes(text));
            StringBuilder str = new StringBuilder();
            foreach(byte b in result)
            {
                str.Append(b.ToString("x2"));
            }
            return str.ToString();
        }
        /// <summary>
        /// Kiểm tra đoạn text có phù hợp với đoạn mã đã được hash
        /// </summary>
        /// <param name="str"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static bool SHACheck(string str, string hash)
        {
            return SHAHash(str).Equals(hash);
        }
    }
}
