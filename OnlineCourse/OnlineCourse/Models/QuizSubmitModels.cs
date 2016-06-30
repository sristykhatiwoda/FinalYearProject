using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class QuizSubmitModels
    {
        public int QuizSubmitID { get; set; }

        public int QuizID { get; set; }

        public int StudentID { get; set; }

        public int QuizPoint { get; set; }

        public string Answer { get; set; }
    }
}