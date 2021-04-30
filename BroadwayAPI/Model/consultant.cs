using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class consultant
    {
        [Key]
        public int Consultantid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }

    }
}
