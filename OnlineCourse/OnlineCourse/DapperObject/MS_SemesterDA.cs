using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    public class MS_SemesterDA: I_MS_Semester
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);


        public List<MS_Semester> Semesters()
        {
            return db.Query<MS_Semester>("Select * from MS_Semester").ToList();
        }

        public int Add(MS_Semester semester)
        {
            var sqlQuery = "Insert into MS_Semester(SemesterTitle) Values (@SemesterTitle)";
            return db.Execute(sqlQuery, semester);
        }


        public MS_Semester Find(int? id)
        {
            string query = "Select from MS_Semester where SemesterID=" + id;
            return db.Query<MS_Semester>(query).SingleOrDefault();

        }

        public int Update(MS_Semester semester)
        {
            var sqlQuery = "Update MS_Semester set  SemesterTitle= @SemesterTitle Where SemesterID = @SemesterID";
            return db.Execute(sqlQuery, semester);
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from MS_Semester where SemesterID=" + id;
            return db.Execute(sqlQuery);
        }
    }
}