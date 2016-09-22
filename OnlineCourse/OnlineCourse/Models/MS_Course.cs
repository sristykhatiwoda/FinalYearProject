using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class MS_Course
    {
        public int CourseID{ get; set; }

        [Required]
        public string CourseTitle { get; set; }

        [Required]
        public string CourseImage { get; set; }
    }
}