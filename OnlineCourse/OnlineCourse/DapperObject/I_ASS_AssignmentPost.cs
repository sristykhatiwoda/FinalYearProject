using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_ASS_AssignmentPost
    {
        List<ASS_AssignmentPost> AssignmentPost();

        ASS_AssignmentPost Find(int? id);

        int Add(ASS_AssignmentPost assignmentPost);

        int Update(ASS_AssignmentPost assignmentPost);

        int Delete(int? id);
    }
}
