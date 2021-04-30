using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class time
    {
        [Key]
        public int Timeid { get; set; }
        public string Time { get; set; }

    }
}
