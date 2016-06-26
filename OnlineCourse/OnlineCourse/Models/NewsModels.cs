using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class NewsModels
    {
        public int NewsID { get; set; }

        public string NewsDiscription { get; set; }

        public int UserID { get; set; }

        public string NewsTitle { get; set; }
    }
}