using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DapperObject
{
    interface I_DIS_DiscussionForumComment
    {
        List<DIS_DiscussionForumComment> DiscussionComments();

        DIS_DiscussionForumComment Find(int? id);

        int Add(DIS_DiscussionForumComment comments);

        int Update(DIS_DiscussionForumComment comments);

        int Delete(int? id);
    }
}
