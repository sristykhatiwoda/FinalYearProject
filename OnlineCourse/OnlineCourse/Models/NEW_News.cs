using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class NEW_News
    {
        public int NewsID { get; set; }

        [Required]
        public string NewsDate { get; set; }
        [Required]
        public string NewsTitle { get; set; }
        [Required]
        public string NewsDescription { get; set; }
        [Required]
        public int UserID { get; set; }

        
    }
}