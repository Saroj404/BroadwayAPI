using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Model
{
    public class Student
    {
        [Key]
        public int Studentid { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string College { get; set; }
        public int MobileNumber { get; set; }
        public int? Courseid { get; set; }
        public int? Batchid { get; set; }
        public int? Teacherid { get; set; }
        public int? Timeid { get; set; }
        public int? Consultantid { get; set; }
        [ForeignKey("Courseid")]
        public virtual user Course { get; set; }
        [ForeignKey("Batchid")]
        public virtual batch Batch { get; set; }
        [ForeignKey("Teacherid")]
        public virtual teacher Teacher { get; set; }
        [ForeignKey("Timeid")]
        public virtual time Time { get; set; }
        [ForeignKey("Consultantid")]
        public virtual consultant Consultant { get; set; }
        


    }
}
