using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class MS_Batch
    {
         public int BatchID{ get; set; }

        [Required]
         public string Year{ get; set; } 
    }
}