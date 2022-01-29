using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        public static EmployeeDAL Instance { get; set; } = new EmployeeDAL();

        public DataTable GetEmployeeList()
        {
            OleDbParameter[] pa = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("NhanVien", pa, "*");
            }
            catch(Exception e)
            {
                return null;
                throw e;
            }
        }

        public int Update(Employee info) 
        {
            try
            {
                //DataProvider.Instance.Update()
                return 1;

            }
            catch(Exception e)
            {
                return -1;
                throw e;
            }
        }

        public int Delete(Employee info)
        {
            OleDbParameter[] pa = new OleDbParameter[1]
            {
                new OleDbParameter("id", info.ID)
            };
            try
            {
                DataTable dt = DataProvider.Instance.SelectData("NhanVien", pa, "*", "MaNV=@id");
                DataRow dr = dt.Rows[0];
                dr.Delete();
                DataProvider.Instance.UpdateData("NhanVien", dt, "*");
                return 1;
            }
            catch (Exception e)
            {
                return -1;
                throw e;
            }
        }
    }
}
