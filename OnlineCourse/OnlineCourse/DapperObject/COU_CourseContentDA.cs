using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineCourse.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace OnlineCourse.DapperObject
{
    public class COU_CourseContentDA : I_COU_CourseContent
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(COU_CourseContent CourseContent)
        {
            var sqlQuery = "Insert into COU_CourseContent(Video,[File],CourseID,UserID)" +
                "values(@Video,@File,@CourseID,@UserID)";
            return db.Execute(sqlQuery, CourseContent);
        }

        public List<COU_CourseContent> CourseContent()
        {
            return db.Query<COU_CourseContent> ("Select * from COU_CourseContent").ToList();
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from COU_CourseContent where CourseContentID=" + id;
            return db.Execute(sqlQuery);
        }

        public COU_CourseContent Find(int? id)
        {
            string query = "Select * from COU_CourseContent where CourseContentID=" + id;
            return db.Query<COU_CourseContent>(query).SingleOrDefault();
        }

        public int Update(COU_CourseContent CourseContent)
        {
            var sqlQuery = "Update COU_CourseContent set Video=@Video,"
                + "File=@File,CourseID=@CourseID,UserID=@UserID Where CourseContentID=@CourseContentID";
            return db.Execute(sqlQuery, CourseContent);
        }
    }
}