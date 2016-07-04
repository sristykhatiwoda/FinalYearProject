using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_MS_Semester
    {
        List<MS_SemesterDA> Semesters();

        MS_SemesterDA Find(int? id);

        int Add(MS_SemesterDA semester);

        int Update(MS_SemesterDA semester);

        int Delete(int? id);
    }
}
