using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StringHandler
    {
        public const string NULL = null;
        //public const string EMPTY = "";

        /// <summary>
        ///　金額が変更処理
        /// </summary>
        /// <param name="price">値段</param>
        /// <param name="crrType">通貨</param>
        /// <returns></returns>
        public static string FormatForCurrency(string price, string crrType)
        {
            price = price.Replace(",", ""); 
            string rst = price.Split('.')[0];
            string pDot = price.Split('.').Length < 2 ? "" : $".{price.Split('.')[1]}";
            int len = rst.Length;
            int start = (len % 3 == 0 && len>3) ? 3 : len%3;
            if (len > 3)
            {
                price = price.Insert(start, ",");
                int len2Cal = len - start;
                int len2 = len2Cal / 3;
                for(int i = 0; i < len2; i++)
                {
                    rst = rst.Insert(start, ",");
                    start += 4;
                }
            }
            
            return rst+pDot + crrType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string FormatForDateTime(string date, bool showTime, bool showMisecond)
        {
            try
            {
                DateTime dt;
                bool isOK = DateTime.TryParse(date, out dt);
                if (isOK)
                {
                    if (showTime)
                    {
                        return dt.ToString("dd/MM/yyyy hh:mm");
                    }
                    else
                    {
                        return dt.ToString("dd/MM/yyyy");
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return "";
        }

        /// <summary>
        ///　文本が切る処理
        /// </summary>
        /// <param name="str">文本</param>
        /// <param name="limitLen">長い制限</param>
        /// <returns></returns>
        public static string Truncate(string str, int limitLen, out string fullStr)
        {
            fullStr = str;
            string result = str;
            if(str.Length > limitLen)
            {
                result = str.Substring(0, limitLen-4)+"...";
            }
            return result;
        }

        public static string ss()
        {
            return "";
        }

        /// <summary>
        /// NULLまたはスペースの場合，str2を返す，以外はstr1返す
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string Or(string str1, string str2)
        {
            return string.IsNullOrEmpty(str1) ? str2 : str1;
        }
        /// <summary>
        /// str1とstr2を結合する
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string Concat(string str1 ,string str2)
        {
            return str1 + str2;
        }
    }
}
