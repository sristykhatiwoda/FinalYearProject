using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_MS_Course
    {
        List<MS_Course> Courses();

        MS_Course Find(int? id);

        int Add(MS_Course course);

        int Update(MS_Course course);

        int Delete(int? id);
        List<MS_Course> CourseAssignment(int? id);
    }
}
