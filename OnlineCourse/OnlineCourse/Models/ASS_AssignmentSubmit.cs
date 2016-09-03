using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace OnlineCourse.Models
{
    public class ASS_AssignmentSubmit
    {
        public int SubmitAssignmentID { get; set; }
        public string SubmissionDate { get; set; }

        public string Answer { get; set; }

        public float Point { get; set; }

        public string Remarks { get; set; }

        [ForeignKey("ASS_AssignmentPost")]
        public int AssignmentID { get; set; }

        public virtual ASS_AssignmentPost AssignmentPost { get; set; }

        [ForeignKey("STU_Student")]
        public int StudentID { get; set; }

        public virtual STU_Student Student { get; set; }
    }
}