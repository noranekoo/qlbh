using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAL
{
    public class DataProvider
    {
        const string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Jet OLEDB:Database Password=1234;";
        static OleDbConnection odbConnect = null;
        public DataProvider()
        {
            try
            {
                odbConnect = new OleDbConnection(conStr);
                odbConnect.Open();
            }
            catch(Exception e)
            {
                throw new DbConnectErrorException("Lỗi kết nối CSDL: ",e);
            }
        }
        private static readonly DataProvider dtp = new DataProvider();
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
        public DataTable SelectData(string tbName, OleDbParameter[] param, string cols, string whereStr = "1=1")
        {
            DataTable dt;
            try
            {
                string sql = JoinSQL(Const.SELECT, tbName, cols, whereStr);
                dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(sql, odbConnect);
                cmd.Parameters.AddRange(param);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception e)
            {
                throw new Exception("Lỗi khi truy vấn: ", e);
            }
            return dt;
        }
        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="sqlType"></param>
        /// <returns></returns>
        public int UpdateData(string tbName, OleDbParameter[] param, string sqlType, string cols = "", string whereStr = "1=1")
        {
            string sql = "";
            string values = "";
            foreach(OleDbParameter p in param)
            {
                values += $"@{p.ParameterName} ";
            }
            values = values.Trim();
            values = values.Replace(" ", ",");
            if ("C".Equals(sqlType))
            {
                // Thực hiện lệnh insert dữ liệu
                sql = JoinSQL(Const.INSERT, tbName, cols, values);
            }
            else if ("U".Equals(sqlType))
            {
                // Thực hiện lệnh update dữ liệu
                sql = JoinSQL(Const.UPDATE, tbName, cols, values, whereStr);
            }
            else
            {
                // Thực hiện lệnh delete dữ liệu
            }
            OleDbCommand cmd = new OleDbCommand(sql, odbConnect);
            cmd.Parameters.AddRange(param);
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Đóng kết nối
        /// </summary>
        public static void Close()
        {
            if (odbConnect.State.Equals(ConnectionState.Open))
            {
                odbConnect.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tbName"></param>
        /// <param name="str1"></param>
        /// <returns></returns>
        private static string JoinSQL(string sql, string tbName, string str1)
        {
            return sql.Replace("tbl", tbName).Replace("s1",str1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tbName"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        private static string JoinSQL(string sql, string tbName, string str1, string str2)
        {
            return JoinSQL(sql, tbName, str1).Replace("s2", str2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tbName"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <returns></returns>
        private static string JoinSQL(string sql, string tbName, string str1, string str2, string str3)
        {
            return JoinSQL(sql, tbName, str1, str2).Replace("s3", str3);
        }

        
    }
}
