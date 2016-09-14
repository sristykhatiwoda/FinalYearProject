using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class EXM_ExamHistoryDetail
    {
        public int ExamHistoryDetailID { get; set; }

        public int ExamHistoryID { get; set; }

        public int QuizID { get; set; }

        public string SubmittedAnswer { get; set; }

        public bool Attempted { get; set; }
    }
}