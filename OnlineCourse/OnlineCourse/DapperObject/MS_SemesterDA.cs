using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCourse.DapperObject
{
    public class MS_SemesterDA: IMS_Semester
    {
        public static string connStr = System.Configuration.ConfigurationManager.
          ConnectionStrings["MovieDBContext"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
    }
}