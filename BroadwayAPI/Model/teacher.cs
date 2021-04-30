using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class teacher
    {
        [Key]
        public int Teacherid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MobileNumber  { get; set; }
        public string Email { get; set; }
        public int? Courseid { get; set; }
        public int? Timeid { get; set; }
        [ForeignKey("Courseid")]
        public virtual user Course { get; set; }
        [ForeignKey("Timeid")]
        public virtual time Time { get; set; }

    }
}
