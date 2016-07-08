using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;


namespace OnlineCourse.DapperObject
{
    interface I_COU_CourseContent
    {
        List<COU_CourseContent> CourseContent();

        COU_CourseContent Find(int? id);

        int Add(COU_CourseContent CourseContent);

        int Update(COU_CourseContent CourseContent);

        int Delete(int? id);

    }
}
