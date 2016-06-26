using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class QuizPost
    {
        public int QuizPostID { get; set; }

        public int QuizID { get; set; }

        public int StudentID { get; set; }

        public int QuizPoint { get; set; }
    }
}