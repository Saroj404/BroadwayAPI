using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class stafftype
    {
        [Key]
        public int Stafftypeid { get; set; }
        public string StaffType { get; set; }
    }
}
