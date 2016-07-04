using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_MS_Faculty
    {
        List<MS_Faculty> Faculties();

        MS_Faculty Find(int? id);

        int Add(MS_Faculty faculty);

        int Update(MS_Faculty faculty);

        int Delete(int? id);
    }
}
