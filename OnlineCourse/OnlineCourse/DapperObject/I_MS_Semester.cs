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
        List<MS_Semester> Semesters();

        MS_Semester Find(int? id);

        int Add(MS_Semester semester);

        int Update(MS_Semester semester);

        int Delete(int? id);
    }
}
