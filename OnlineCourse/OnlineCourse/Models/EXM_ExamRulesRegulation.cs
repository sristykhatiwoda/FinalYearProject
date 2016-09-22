using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class EXM_ExamRulesRegulation
    {
        public int ExamRulesRegulationID { get; set; }

        [Required]
        public string ExamRulesRegulationText { get; set; }
    }


}