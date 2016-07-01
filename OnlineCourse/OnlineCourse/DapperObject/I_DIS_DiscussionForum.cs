using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_DIS_DiscussionForum
    {
        List<DIS_DiscussionForum> discussionForum();

        DIS_DiscussionForum Find(int? id);

        int Add(DIS_DiscussionForum forum);

        int Update(DIS_DiscussionForum forum);

        int Delete(int? id);
    }
}
