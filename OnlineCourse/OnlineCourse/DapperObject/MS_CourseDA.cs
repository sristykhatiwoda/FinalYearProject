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
            var sqlQuery = "Insert into MS_Course(CourseTitle,CourseImage)Values(@CourseTitle,@CourseImage)";
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

            string query = "Select * from MS_Course where CourseID=" + id;
            return db.Query<MS_Course>(query).SingleOrDefault();

        }

        public int Update(MS_Course course)
        {
            var sqlQuery = "Update MS_Course set CourseTitle=@CourseTitle,CourseImage=@CourseImage Where CourseID=@CourseID";
            return db.Execute(sqlQuery, course);
        }

        

        public dynamic CourseAssignment(int? id)
        {
            var sqlQuery = "Select * from MS_Course join ASS_AssignmentPost on MS_Course.CourseID = ASS_AssignmentPost.CourseID where MS_Course.CourseID=" + id;
            return db.Query<dynamic>(sqlQuery).SingleOrDefault(); 
            //throw new NotImplementedException();
        }
    }
}