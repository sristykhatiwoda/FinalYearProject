using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using OnlineCourse.Models;
using System.Data;
using System.Data.SqlClient;

namespace OnlineCourse.DapperObject
{
    public class DIS_DiscussionForumDA:I_DIS_DiscussionForum
    {
        private static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();
        public static IDbConnection db = new SqlConnection(connStr);
        
        public int Add(DIS_DiscussionForum forum)
        {
            var sqlQuery = "Insert into DIS_DiscussionForum(Title,Description,Date,UserID,StudentID) values(@Title,@Description,@Date,@UserID,@StudentID)";
            return db.Execute(sqlQuery,forum);
        }

        public List<DIS_DiscussionForum> discussionForum()
        {
            //throw new NotImplementedException();
            return db.Query<DIS_DiscussionForum>("Select * From DIS_DiscussionForum").ToList();
        }

        public DIS_DiscussionForum Find(int? id)
        {
            //throw new NotImplementedException();
            string query = "Select * From DIS_DiscussonForum where DiscussionForumID=" + id;
            return db.Query<DIS_DiscussionForum>(query).SingleOrDefault();
        }

        public int Update(DIS_DiscussionForum forum)
        {
            //throw new NotImplementedException();
            var sqlQuery = "Update DIS_DiscussionForum set Title=@Title,Description=@Description,Date=@Date,UserID=@UserID,StudentID=@StudentID where DiscussionForumID=@DiscussionForumID";
            return db.Execute(sqlQuery, forum);
        }

        public int Delete(int? id)
        {
            //throw new NotImplementedException();
            string query = "Delete from DIS_DiscussionForum where DiscussionForumID=" + id;
            return db.Execute(query);
        }
    }
}