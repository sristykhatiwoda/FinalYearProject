using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class SC_UserType
    {
        public int UserTypeID { get; set; }

        [Required]
        public string Type { get; set; }
    }
}