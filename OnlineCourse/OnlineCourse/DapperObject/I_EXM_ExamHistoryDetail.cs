using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_EXM_ExamHistoryDetail
    {
        List<EXM_ExamHistoryDetail> ExamHistoryDetails();

        EXM_ExamHistoryDetail Find(int? id);

        int Add(EXM_ExamHistoryDetail examHistoryDetail);

        int Update(EXM_ExamHistoryDetail examHistoryDetail);

        int Delete(int? id);

        List<EXM_ExamHistoryDetail> examHistoryDetail(int? id);
    }
}
