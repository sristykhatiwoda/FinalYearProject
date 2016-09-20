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
    public class ASS_AssignmentSubmitDA : I_ASS_AssignmentSubmit
    {
        public static string connStr = System.Configuration.ConfigurationManager.
            ConnectionStrings["Defaultconnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(ASS_AssignmentSubmit assignmentSubmit)
        {
            var sqlQuery = "Insert into ASS_AssignmentSubmit(SubmissionDate,Answer,Point,"+
                "Remarks,AssignmentID,StudentID)Values(@SubmissionDate,@Answer,@Point,"+
               "@Remarks,@AssignmentID,@StudentID )";
            return db.Execute(sqlQuery, assignmentSubmit);

        }

        public List<ASS_AssignmentSubmit> AssignmentSubmits()
        {
            return db.Query<ASS_AssignmentSubmit>("Select * from ASS_AssignmentSubmit").ToList();
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from ASS_AssignmentSubmit where SubmitAssignmentID=" + id;
            return db.Execute(sqlQuery);
        }

        public ASS_AssignmentSubmit Find(int? id)
        {
            string query = "Select * from ASS_AssignmentSubmit where SubmitAssignmentID=" + id;
            return db.Query<ASS_AssignmentSubmit>(query).SingleOrDefault();
        }

        

        public int InsertAssignment(ASS_AssignmentSubmit assignmentSubmit)
        {
            var sqlQuery = "Insert into ASS_AssignmentSubmit(StudentID,AssignmentID,Answer) values(@StudentID,AssignmentID,@Answer)";
            return db.Execute(sqlQuery, assignmentSubmit);
           // throw new NotImplementedException();
        }

        public int Update(ASS_AssignmentSubmit assignmentSubmit)
        {
            var sqlQuery = "Update ASS_AssignmentSubmit set " +
                          "SubmissionDate=@SubmissionDate,Answer=@Answer,Point=@Point,Remarks=@Remarks," +
                         "AssignmentID=@AssignmentID Where SubmitAssignmentID=@SubmitAssignmentID";
            return db.Execute(sqlQuery, assignmentSubmit);

        }
    }
}