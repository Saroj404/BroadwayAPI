using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class batch
    {
        [Key]
        public int Batchid { get; set; }
        public string Batch { get; set; }
        public string Year { get; set; }
    }
}
