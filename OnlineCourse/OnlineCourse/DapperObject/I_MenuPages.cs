using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_MenuPages
    {
        List<MenuPages> MenuPages();

        MenuPages Find(int? id);

        int Add(MenuPages menu);

        int Update(MenuPages menu);

        int Delete(int? id);
    }
}
