using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class MS_Faculty
    {
        public int FacultyID{ get; set; }

        [Required]
        public string FacultyTitle { get; set; }

    }
}