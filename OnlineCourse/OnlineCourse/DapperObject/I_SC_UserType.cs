using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_SC_UserType
    {
        List<SC_UserType> UserTypes();

        SC_UserType Find(int? id);

        int Add(SC_UserType userType);

        int Update(SC_UserType userType);

        int Delete(int? id);
    }
}
