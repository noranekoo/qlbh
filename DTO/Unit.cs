using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Unit
    {
        int id;
        string unit_name;
        string unit_description;

        public int Id { get => id; set => id = value; }
        public string Unit_name { get => unit_name; set => unit_name = value; }
        public string Unit_description { get => unit_description; set => unit_description = value; }
    }
}
