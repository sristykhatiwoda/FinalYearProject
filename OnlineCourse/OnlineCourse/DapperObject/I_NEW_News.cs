using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_NEW_News
    {
        List<NEW_News> News();

        NEW_News Find(int? id);

        int Add(NEW_News news);

        int Update(NEW_News news);

        int Delete(int? id);
    }
}
