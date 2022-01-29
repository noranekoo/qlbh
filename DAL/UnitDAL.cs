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
    public class UnitDAL
    {
        /// <summary>
        /// Khởi tạo một lần
        /// </summary>
        public static UnitDAL Instance { get; set; } = new UnitDAL();
        
        public DataTable GetUnitList()
        {
            OleDbParameter[] parameters = new OleDbParameter[0];
            try
            {
                return DataProvider.Instance.SelectData("DonViTinh", parameters, "*");
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }
        }

        public void UpdateData(DataTable dt)
        {
            try
            {
                DataProvider.Instance.UpdateData("DonViTinh", dt, "*");
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public Unit GetUnit(int id)
        {
            try
            {
                OleDbParameter[] param = new OleDbParameter[1]
                {
                    new OleDbParameter("maDonVi", id)
                };
                DataTable dt = DataProvider.Instance.SelectData("DonViTinh", param, "*", "ID=@maDonVi");
                if (dt != null && dt.Rows.Count > 0)
                {
                    return ConvertToDTO(dt.Rows[0]);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
                throw e.InnerException;
            }
        }

        //public List<Unit> GetUnitList()
        //{
        //    try
        //    {
        //        List<Unit> list = new List<Unit>();
        //        OleDbParameter[] param = new OleDbParameter[0]; 
        //        DataTable dt = DataProvider.GetInstance().SelectData("DonViTinh", param, "*");
        //        if(dt != null && dt.Rows.Count > 0)
        //        {
        //            foreach(DataRow dr in dt.Rows)
        //            {
        //                list.Add(ConvertToDTO(dr));
        //            }
        //        }
        //        return list;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //        throw e.InnerException;
        //    }
        //}

        private Unit ConvertToDTO(DataRow dr)
        {
            return new Unit()
            {
                Id = int.Parse(dr["ID"].ToString()),
                Unit_name = dr["TenDonVi"].ToString(),
                Unit_description = dr["MoTa"].ToString(),
            };
        }
    }
}
