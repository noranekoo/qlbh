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
        public static DataProvider Instance { get; set; } = new DataProvider();
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

        public int Insert(string tbName, OleDbParameter [] pa, string cols, string values)
        {
            string sql = JoinSQL(Const.INSERT, tbName, cols, values);
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, odbConnect);
                cmd.Parameters.AddRange(pa);
                return cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return -1;
                throw e.InnerException;
            }
        }

        public int Delete(string tbName, OleDbParameter[] pa, string whereStr)
        {
            string sql = JoinSQL(Const.DELETE, tbName, whereStr);
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, odbConnect);
                cmd.Parameters.AddRange(pa);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
                throw e.InnerException;
            }
            
        }

        public void Update(string tbName, OleDbParameter[] pa, string cols)
        {

        }

        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="sqlType"></param>
        /// <returns></returns>
        public void UpdateData(string tbName, DataTable dt , string cols = "", string whereStr = "1=1")
        {
            string sql = JoinSQL(Const.SELECT, tbName, cols, whereStr);
            OleDbCommand cmd = new OleDbCommand(sql, odbConnect);
            OleDbTransaction trans;
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(da);
            da.InsertCommand = ocb.GetInsertCommand(true);
            da.UpdateCommand = ocb.GetUpdateCommand(true);
            da.DeleteCommand = ocb.GetDeleteCommand(true);
            //Tạo transaction cho việc thay đổi dữ liệu
            trans = odbConnect.BeginTransaction();
            da.InsertCommand.Transaction = trans;
            da.UpdateCommand.Transaction = trans;
            da.DeleteCommand.Transaction = trans;
            try
            {
                da.Update(dt);
                //Thực hiện commit dữ liệu khi tác vụ thành công
                trans.Commit();
            }
            catch (Exception e)
            {
                //Không thực hiện update dữ liệu
                trans.Rollback();
                throw e.InnerException;
            }
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
