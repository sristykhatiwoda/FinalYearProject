using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.Models
{
    public class DiscussionForumComment
    {
        public int CommentID { get; set; }

        public int DiscussionForumID { get; set; }

        public string Comments { get; set; }

        public int UserID { get; set; }

        public int CommentDate { get; set; }
    }
}