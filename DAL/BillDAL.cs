using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {
        public static BillDAL Instance { get; set; } = new BillDAL();

        public DataTable GetBillList()
        {
            OleDbParameter[] pa = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("PhieuXuat", pa, "*");
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public DataTable GetDetailBillList(string id)
        {
            OleDbParameter[] pa = new OleDbParameter[1]
            {
                new OleDbParameter("id", id)
            };
            try
            {
                return DataProvider.Instance.SelectData("ChiTietPhieuXuat", pa,"*", "MaPhieu=@id");
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
            //return null;
        }

        public bool UpdateBill(DataRow dr)
        {
            if (dr == null) return false;
            OleDbParameter[] pa = new OleDbParameter[1]
            {
                new OleDbParameter("id", dr["ID"].ToString()),
            };
            try
            {
                DataTable dt = DataProvider.Instance.SelectData("PhieuXuat", pa, "*", "ID=@id");
                if(dt != null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        DataRow tmp = dt.Rows[0];
                        tmp.ItemArray = dr.ItemArray;
                        DataProvider.Instance.UpdateData("PhieuXuat", dt, "*");
                        return true;
                    }
                    else
                    {
                        dt.Rows.Add(dr.ItemArray);
                        DataProvider.Instance.UpdateData("PhieuXuat", dt, "*");
                        return true;
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }
    }
}
