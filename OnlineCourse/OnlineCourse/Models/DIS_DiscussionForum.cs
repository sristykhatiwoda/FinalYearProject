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

        public string Discription { get; set; }

        public int UserID { get; set; }

        public string Date { get; set; }
    }
}