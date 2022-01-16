using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Timestamp, Userstamp
    /// </summary>
    public class TimeStamps
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class InfoStamps
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
