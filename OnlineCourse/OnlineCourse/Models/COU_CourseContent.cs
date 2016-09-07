using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class COU_CourseContent
    {
        public int CourseContentID { get; set; }

        public string Video { get; set; }

        public string Tutorials { get; set; }

        public int CourseID { get; set; }

        public int UserID { get; set; }
    }
}