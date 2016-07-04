using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_SC_User
    {
        List<SC_User> Users();

        SC_User Find(int? id);

        int Add(SC_User user);

        int Update(SC_User user);

        int Delete(int? id);
    }
}
