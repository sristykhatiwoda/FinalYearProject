using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class QuizQuestions
    {
        public int QuizID { get; set; }

        public int CourseID { get; set; }

        public string Questions { get; set; }

        public string Answers { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }
    }
}