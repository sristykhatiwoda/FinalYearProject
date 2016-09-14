using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class EXM_ExamHistory
    {
        public int ExamHistoryID { get; set; }
        public int StudentID { get; set; }
        
        public System.DateTime ExamTakenDate { get; set; }

        public Nullable<System.TimeSpan> ExamStartTime { get; set; }

        public Nullable<System.TimeSpan> ExamCompletedTime { get; set; }

        public int Score { get; set; }
    }
}