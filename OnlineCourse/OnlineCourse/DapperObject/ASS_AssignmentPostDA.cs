using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    public class ASS_AssignmentPostDA : I_ASS_AssignmentPost
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);

        public int Add(ASS_AssignmentPost assignmentPost)
        {
            var sqlQuery = "Insert into ASS_AssignmentPost(Questions," +
               " Deadline,CourseID,UserID,PostedDate,Title)Values(@Questions,@Deadline,@CourseID,@UserID,@PostedDate,@Title)";
            return db.Execute(sqlQuery, assignmentPost);
        }

        public List<ASS_AssignmentPost> AssignmentPost()
        {
            return db.Query<ASS_AssignmentPost>("Select * from ASS_AssignmentPost").ToList();
        }

        public int Delete(int? id)
        {

            var sqlQuery = "Delete from ASS_AssignmentPost where AssignmentID=" + id;
            return db.Execute(sqlQuery);
        }

        public ASS_AssignmentPost Find(int? id)
        {
            string query = "Select * from ASS_AssignmentPost where AssignmentID=" + id;
            return db.Query<ASS_AssignmentPost>(query).SingleOrDefault();
        }

        public int Update(ASS_AssignmentPost assignmentPost)
        {
            var sqlQuery = "Update ASS_AssignmentPost set Questions=@Questions," +
                          "Deadline=@Deadline,CourseID=@CourseID," +
                         "UserID=@UserID ,PostedDate=@PostedDate,Title=@Title Where AssignmentID=@AssignmentID";
            return db.Execute(sqlQuery, assignmentPost);
        }

        public dynamic AssignmentDetail(int id = 0)
        {

            //var sqlQuery = db.Query<ASS_AssignmentPost, MS_Course, SC_User>
            //                       (@"Select MS_Course.*,ASS_Assignment.*,SC_User.* from ASS_AssignmentPost
            //                           join MS_Course 
            //                             on ASS_AssignmentPost.CourseID = MS_Course.CourseID
            //                           join SC_User
            //                             on ASS_AssignmentPost.UserID=SC_User.UserID",

            //                           (a, c, u) =>
            //                           {
            //                               a.MS_Course = c;
            //                               a.SC_User = u;
            //                               return a;
            //                           }, splitOn: "CourseID,UserID"
            //                      ).AsQueryable();

            var sqlQuery = "Select * from ASS_AssignmentPost join MS_Course on ASS_AssignmentPost.CourseID = MS_Course.CourseID" +
                " join SC_User on ASS_AssignmentPost.UserID = SC_User.UserID where AssignmentID="+id;
            return db.Query<dynamic>(sqlQuery).SingleOrDefault();
        }
    }
}
