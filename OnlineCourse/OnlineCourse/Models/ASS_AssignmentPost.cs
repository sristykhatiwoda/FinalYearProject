using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class ASS_AssignmentPost
    {
        public int AssignmentID { get; set; }

        public string Questions { get; set; }

        public string Deadline { get; set;}
        public int CourseID { get; set; }
        public int UserID { get; set; }

        public string Title { get; set; }
        public string PostedDate { get; set; }
        

        public virtual MS_Course MS_Course { get; set; }

        public virtual SC_User SC_User { get; set; }
    }

}