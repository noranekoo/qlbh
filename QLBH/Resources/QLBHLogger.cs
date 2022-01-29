using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Resources
{
    public class QLBHLogger
    {
        /// <summary>
        /// 
        /// </summary>
        const string ERROR_LOG_FILE_PATH = "error.log";
        /// <summary>
        /// 
        /// </summary>
        const string UPDATE_LOG_FILE_PATH = "update.log";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void LogError(string message)
        {
            DateTime now = DateTime.Now;
            string lst_message = Encoding.UTF8.GetString(File.ReadAllBytes(ERROR_LOG_FILE_PATH));
            lst_message += $"ERROR: {message} at {now.ToString("yyyy-MM-dd hh:mm:ss tt")}\n";
            byte[] strByte = Encoding.UTF8.GetBytes(lst_message);
            File.WriteAllBytes(ERROR_LOG_FILE_PATH, strByte);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="except"></param>
        public static void LogError(Exception except)
        {
            DateTime now = DateTime.Now;
            string lst_message = Encoding.UTF8.GetString(File.ReadAllBytes(ERROR_LOG_FILE_PATH));
            lst_message += $"ERROR: {except.Message} at {now.ToString("yyyy-MM-dd hh:mm:ss tt")}\n";
            byte[] strByte = Encoding.UTF8.GetBytes(lst_message);
            File.WriteAllBytes(ERROR_LOG_FILE_PATH, strByte);
        }

        public static void LogUpdate(string message)
        {
            
        }
    }
}
