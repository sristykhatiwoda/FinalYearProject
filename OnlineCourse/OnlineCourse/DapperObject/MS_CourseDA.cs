using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineCourse.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace OnlineCourse.DapperObject
{
    public class MS_CourseDA : I_MS_Course
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(MS_Course course)
        {
            var sqlQuery = "Insert into MS_Course(CourseID,CourseTitle)Values(@CourseID,@CourseTitle)";
            return db.Execute(sqlQuery, course);
        }

        public List<MS_Course> Courses()
        {
            return db.Query<MS_Course>("Select * from MS_Course").ToList();
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from MS_Course where CourseID=" + id;
            return db.Execute(sqlQuery);
        }

        public MS_Course Find(int? id)
        {
            string query = "Select from MS_Course where id=" + id;
            return db.Query<MS_Course>(query).SingleOrDefault();

        }

        public int Update(MS_Course course)
        {
            var sqlQuery = "Update into MS_Course set CourseTitle=@CourseTitle Where CourseID=@CourseID";
            return db.Execute(sqlQuery, course);
        }
    }
}