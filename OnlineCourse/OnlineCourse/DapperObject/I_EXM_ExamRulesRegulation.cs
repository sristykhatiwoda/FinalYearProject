using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_EXM_ExamRulesRegulation
    {
        List<EXM_ExamRulesRegulation> ExamRulesRegulations();

        EXM_ExamRulesRegulation Find(int? id);

        int Add(EXM_ExamRulesRegulation examRulesRegulation);

        int Update(EXM_ExamRulesRegulation examRulesRegulation);

        int Delete(int? id);
    }
}
