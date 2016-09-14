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
    public class EXM_ExamHistoryDA : I_EXM_ExamHistory
    {
        public static string connStr = System.Configuration.ConfigurationManager.
           ConnectionStrings["DefaultConnection"].ToString();
        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(EXM_ExamHistory examHistory)
        {
            var sqlQuery = "Insert into EXM_ExamHistory(StudentID,ExamTakenDate,ExamStartTime,ExamCompletedTime,Score) values(@StudentID,@ExamTakenDate,@ExamStartTime,@ExamCompletedTime,@Score)";
            return db.Execute(sqlQuery, examHistory);
            //throw new NotImplementedException();
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from EXM_ExamHistory where ExamHistoryID=" + id;
            return db.Execute(sqlQuery);
            //throw new NotImplementedException();
        }

        public List<EXM_ExamHistory> ExamHistories()
        {
            return db.Query<EXM_ExamHistory>("Select * from EXM_ExamHistory").ToList();
            //throw new NotImplementedException();
        }

        public EXM_ExamHistory Find(int? id)
        {
            var query = "Select * from EXM_ExamHistory where ExamHistoryID=" + id;
            return db.Query<EXM_ExamHistory>(query).SingleOrDefault();
            //throw new NotImplementedException();
        }

        public int Update(EXM_ExamHistory examHistory)
        {
            var sqlQuery = "Update EXM_ExamHistory set StudentID=@StudentID,ExamTakenDate=@ExamTakenDate,ExamStartTime=@ExamStartTime,ExamCompletedTime=@ExamCompletedTime,Score=@Score where ExamHistoryID=@ExamHistoryID";
            return db.Execute(sqlQuery);
            //throw new NotImplementedException();
        }
    }
}