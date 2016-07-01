using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class ASS_AssignmentSubmit
    {
        public int SubmitAssignmentID { get; set; }
        public string SubmissionDate { get; set; }

        public string Answer { get; set; }

        public float Point { get; set; }

        public string Remarks { get; set; }

        public int AssignmentID { get; set; }

        public int StudentID { get; set; }
    }
}