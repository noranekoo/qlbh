using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DTO
{
    public class Employee
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string IDNumber { get; set; }
        public DateTime JobDate {get;set;}
        public Image Avatar { get; set; }
        public string AvatarLink { get; set; } = "images/boy.png";
        public int DepartID { get; set; }
        public string DepartName { get; set; }

        const string DEFAULT_IMG = "images/boy.png";

        public Employee()
        {
            FullName = "";
            Birthday = DateTime.Now;
            Phone = "";
            Address = "";
            Email = "";
            IDNumber = "";
            JobDate = DateTime.Now;
            Avatar = GetAvatar(AvatarLink);
        }

        public static Employee ConvertToDTO(DataRow dr)
        {
            string avatarLink = dr["AnhDaiDien"].ToString();
            return new Employee()
            {
                ID = int.Parse(dr["MaNV"].ToString()),
                FullName = dr["TenNV"].ToString(),
                Phone = dr["SDT"].ToString(),
                Address = dr["DiaChi"].ToString(),
                Email = dr["Email"].ToString(),
                IDNumber = dr["CCCD_CMND"].ToString(),
                Birthday = DateTime.Parse(dr["NgaySinh"].ToString()),
                JobDate = DateTime.Parse(dr["NgayNhanViec"].ToString()),
                Avatar = GetAvatar(avatarLink),
                AvatarLink = avatarLink,
                DepartID = int.Parse(dr["MaBoPhan"].ToString()),
            };
        }

        public static void ConvertToDataRow(Employee info, ref DataRow dr)
        {
            dr["TenNV"] = info.FullName;
            dr["SDT"] = info.Phone;
            dr["DiaChi"] = info.Address;
            dr["Email"] = info.Email;
            dr["CCCD_CMND"] = info.IDNumber;
            dr["NgaySinh"] = info.Birthday;
            dr["NgayNhanViec"] = info.JobDate;
            dr["AnhDaiDien"] = info.AvatarLink;
            dr["MaBoPhan"] = info.DepartID;
        }

        public static Image GetAvatar(string link)
        {
            Image img = null;
            FileStream fs;
            if (File.Exists(link))
            {
                fs = new FileStream(link, FileMode.Open);
                img = Image.FromStream(fs);
                fs.Close();
            }
            return img;
        }
        
    }
}
