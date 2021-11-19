using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class DataProvider
    {
        const string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=False;";
        OleDbConnection odbConnect = null;
        public DataProvider()
        {
            try
            {
                odbConnect = new OleDbConnection(conStr);
                odbConnect.Open();
            }
            catch
            {
                throw new Exception("Có lỗi khi kết nối đến dữ liệu");
            }
            
            
        }
        private static DataProvider dtp = new DataProvider();
        public static DataProvider GetInstance()
        {
            return dtp;
        }
        /// <summary>
        /// Lấy dữ liệu
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tbName"></param>
        /// <returns>Trả về một bảng dữ liệu</returns>
        public DataTable GetData(string sql,OleDbParameter[] param, string tbName = null)
        {
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(sql, odbConnect);
            cmd.Parameters.AddRange(param);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt, tbName);
            
            return dt;
        }

        public static string JoinSQL(string sql, string str1)
        {
            return sql.Replace("s1",str1);
        }

        public static string JoinSQL(string sql, string str1, string str2)
        {
            return sql.Replace("s1", str1).Replace("s2", str2);
        }

        public static string JoinSQL(string sql, string str1, string str2, string str3)
        {
            return sql.Replace("s1", str1).Replace("s2", str2).Replace("s3", str3);
        }
    }
}
