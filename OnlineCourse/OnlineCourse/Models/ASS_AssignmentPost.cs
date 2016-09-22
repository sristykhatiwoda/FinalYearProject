using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class ASS_AssignmentPost
    {
        public int AssignmentID { get; set; }

        [Required]
        public string Questions { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Deadline { get; set;}

        [Required]
        public int CourseID { get; set; }

        [Required]
        public int UserID { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string PostedDate { get; set; }
        

        public virtual MS_Course MS_Course { get; set; }

        public virtual SC_User SC_User { get; set; }
    }

}