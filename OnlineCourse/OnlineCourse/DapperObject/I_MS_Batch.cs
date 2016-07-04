using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_MS_Batch
    {
        List<MS_Batch> Batches();

        MS_Batch Find(int? id);

        int Add(MS_Batch batch);

        int Update(MS_Batch batch);

        int Delete(int? id);
    }
}
