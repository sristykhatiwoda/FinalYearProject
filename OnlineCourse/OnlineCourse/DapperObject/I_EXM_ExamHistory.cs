using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_EXM_ExamHistory
    {
        List<EXM_ExamHistory> ExamHistories();

        EXM_ExamHistory Find(int? id);

        int Add(EXM_ExamHistory examHistory);

        int Update(EXM_ExamHistory examHistory);

        int Delete(int? id);
    }
}
