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
    public class DIS_DiscussionForumCommentDA : I_DIS_DiscussionForumComment
    {
        private static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();
        public static IDbConnection db = new SqlConnection(connStr);

        public int Add(DIS_DiscussionForumComment comments)
        {
            var sqlQuery = "Insert into DIS_DiscussionForumComment (Date,DiscussionForumID,UserID) values (@Date,@DiscussionForumID,@UserID)";
            return db.Execute(sqlQuery, comments);
            //throw new NotImplementedException();
        }

        public int Delete(int? id)
        {
            //throw new NotImplementedException();
            string query = "Delete from DIS_DiscussionForumComment where CommentID=" + id;
            return db.Execute(query);
        }

        public List<DIS_DiscussionForumComment> DiscussionComments()
        {
            //throw new NotImplementedException();
            return db.Query<DIS_DiscussionForumComment>("Select * from DIS_DiscussionForumComment").ToList();
        }

        public DIS_DiscussionForumComment Find(int? id)
        {
            //throw new NotImplementedException();
            string query = "Select * from DIS_DiscussionForumComment where CommentID=" + id;
            return db.Query<DIS_DiscussionForumComment>(query).SingleOrDefault();
        }

        public int Update(DIS_DiscussionForumComment comments)
        {
            //throw new NotImplementedException();
            var sqlQuery = "Update DIS_DiscussionForumComment set Date=@Date,DiscussionForumID=@DiscussionForumID,UserID=@UserID";
            return db.Execute(sqlQuery, comments);
        }
    }
}