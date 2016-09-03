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
    public class MS_FacultyDA:I_MS_Faculty
    {

        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);


        public List<MS_Faculty> Faculties()
        {
            return db.Query<MS_Faculty>("Select * from MS_Faculty").ToList();
        }

        public int Add(MS_Faculty faculty)
        {
            var sqlQuery = "Insert into MS_Faculty(FacultyTitle) Values (@FacultyTitle)";
            return db.Execute(sqlQuery, faculty);
        }
        

        public MS_Faculty Find(int? id)
        {
            string query = "Select * from MS_Faculty where FacultyID=" + id;
            return db.Query<MS_Faculty>(query).SingleOrDefault();

        }

        public int Update(MS_Faculty faculty)
        {
            var sqlQuery = "Update MS_Faculty set  FacultyTitle= @FacultyTitle Where FacultyID = @FacultyID";
            return db.Execute(sqlQuery, faculty);
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from MS_Faculty where FacultyID=" + id;
            return db.Execute(sqlQuery);
        }
    }
}