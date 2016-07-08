using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class QUIZ_Quiz
    {
        public int QuizID { get; set; }

        public int CourseID { get; set; }

        public string QuizQuestion { get; set; }

        public string Answer { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        public int UserId { get; set; }
    }
}