using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class staff
    {
        [Key]
        public int Staffid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public int? Stafftypeid { get; set; }
        [ForeignKey("Stafftypeid")]
        public virtual stafftype Stafftype { get; set; }

    }
}
