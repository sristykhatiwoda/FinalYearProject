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
    public class EXM_ExamHistoryDetailDA:I_EXM_ExamHistoryDetail
    {
        public static string connStr = System.Configuration.ConfigurationManager.
           ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);

        public int Add(EXM_ExamHistoryDetailDA examHistoryDetail)
        { 
            var sqlQuery = "Insert into EXM_ExamHistoryDetail(ExamHistoryID,QuizID,SubmittedAnswer,Attempted)  values(@ExamHistoryID,@QuizID,@SubmittedAnswer,@Attempted)";
            return db.Execute(sqlQuery, examHistoryDetail);
        
            //throw new NotImplementedException();
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from EXM_ExamHistoryDetail where ExamHistoryDetailID=" + id;
            return db.Execute(sqlQuery);
            //throw new NotImplementedException();
        }

        public List<EXM_ExamHistoryDetailDA> ExamHistoryDetails()
        {
            return db.Query<EXM_ExamHistoryDetailDA>("Select * from EXM_ExamHistoryDetail").ToList();
            //throw new NotImplementedException();
        }

        public EXM_ExamHistoryDetailDA Find(int? id)
        {
            var sqlQuery = "Select * from EXM_ExamHistoryDetail where ExamHistoryDetailID=" + id;
            return db.Query<EXM_ExamHistoryDetailDA>(sqlQuery).SingleOrDefault();
            //throw new NotImplementedException();
        }

        public int Update(EXM_ExamHistoryDetailDA examHistoryDetail)
        {
            var sqlQuery = "Update EXM_ExamHistoryDetail set ExamHistoryID=@ExamHistoryID,QuizID=@QuizID,SubmittedAnswer=@SubmittedAnswer,Attempted=@Attempted where ExamHistoryDetailID=@ExamHistoryDetailID";
            return db.Execute(sqlQuery, examHistoryDetail);
            //throw new NotImplementedException();
        }
    }
}