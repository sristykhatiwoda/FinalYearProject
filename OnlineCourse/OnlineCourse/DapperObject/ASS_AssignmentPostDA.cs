﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    public class ASS_AssignmentPostDA:I_ASS_AssignmentPost
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);

        public int Add(ASS_AssignmentPost assignmentPost)
        {
            var sqlQuery = "Insert into ASS_AssignmentPost(AssignmentID,Questions,"+
               " Deadline,CourseID,UserID)Values(@AssignmentID,@Questions,@Deadline,@CourseID,@UserID)";
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
            var sqlQuery = "Update ASS_AssignmentPost set AssignmentID=@AssignmentID,"+
                          "Questions=@Questions,Deadline=@Deadline,CourseID=@CourseID,"+
                         "UserID=@UserID Where AssignmentID=@AssignmentID";
            return db.Execute(sqlQuery,assignmentPost);
        }
    }
}