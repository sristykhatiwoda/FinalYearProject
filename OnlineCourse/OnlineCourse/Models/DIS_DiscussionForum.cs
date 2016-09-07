using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OnlineCourse.Models
{
    public class DIS_DiscussionForum
    {
        public int DiscussionForumID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int UserID { get; set; }

        public string Date { get; set; }

        public int StudentID { get; set; }
    }
}