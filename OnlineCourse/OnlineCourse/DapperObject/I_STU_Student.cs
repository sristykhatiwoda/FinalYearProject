using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_STU_Student
    {
        List<STU_Student> Students();

        STU_Student Find(int? id);

        int Add(STU_Student student);

        int Update(STU_Student student);

        int Delete(int? id);
    }
}
