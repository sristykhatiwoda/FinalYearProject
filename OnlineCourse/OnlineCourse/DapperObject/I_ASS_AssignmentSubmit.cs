using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_ASS_AssignmentSubmit
    {
        List<ASS_AssignmentSubmit> AssignmentSubmits();

        ASS_AssignmentSubmit Find(int? id);

        int Add(ASS_AssignmentSubmit  assignmentSubmit);

        int Update(ASS_AssignmentSubmit assignmentSubmit);

        int Delete(int? id);

        int InsertAssignment (ASS_AssignmentSubmit assignmentSubmit);
    }
}
