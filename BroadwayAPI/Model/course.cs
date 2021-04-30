using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class course
    {
        [Key]
        public int Courseid { get; set; }
        public string CourseName { get; set; }

        public int Duration { get; set; }
        public int Fee { get; set; }
    }
}
