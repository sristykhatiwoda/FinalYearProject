using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class DiscussionForum
    {
        public int DiscussionForumID { get; set; }

        public string DiscussionTitle { get; set; }

        public string DiscussionDiscription { get; set; }

        public int UserID { get; set; }

        public string PostDate { get; set; }
    }
}