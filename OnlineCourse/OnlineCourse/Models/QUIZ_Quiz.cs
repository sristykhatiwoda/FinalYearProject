using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineCourse.Models
{
    public class QUIZ_Quiz
    {
        public int QuizID { get; set; }

        [Required]
        public int CourseID { get; set; }

        [Required]
        public string QuizQuestion { get; set; }

        [Required]
        public string Answer { get; set; }

        [Required]
        public string Option1 { get; set; }

        [Required]
        public string Option2 { get; set; }

        [Required]
        public string Option3 { get; set; }

        public string Option4 { get; set; }

        [ForeignKey("SC_User")]
        [Required]
        public int UserID { get; set; }

        public virtual SC_User User { get; set; } 
    }
}