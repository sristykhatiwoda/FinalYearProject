using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class MS_Semester
    {
        public int SemesterID { get; set; }

        [Required]
        public string SemesterTitle { get; set; }

        
    }
}