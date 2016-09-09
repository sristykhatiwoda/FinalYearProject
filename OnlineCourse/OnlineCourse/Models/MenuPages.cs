using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class MenuPages
    {
        public int MenuPageID { get; set; }
        public string MenuTitle { get; set; }
        public string PageContent { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
