using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using OnlineCourse.Models;
using Dapper;

namespace OnlineCourse.DapperObject
{
    public class Quiz_QuizSubmitDA : I_QUIZ_QuizSubmit
    {
        private static string connStr = System.Configuration.ConfigurationManager.
             ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(QUIZ_QuizSubmit quizSubmit)
        {
            //throw new NotImplementedException();
            var sqlQuery = "insert into QUIZ_QuizSubmit (QuizSubmitID, Answer, QuizPoint, StudentID, QuizID)"+
                "values (@QuizSubmitID, @Answer, @QuizPoint, @StudentID, @QuizID)";
            return db.Execute(sqlQuery, quizSubmit);
        }

        public int Delete(int? id)
        {
            //throw new NotImplementedException();
            var sqlQuery = "delete from QUIZ_QuizSubmit where QuizSubmitID=" + id;
            return db.Execute(sqlQuery);
        }

        public QUIZ_QuizSubmit Find(int? id)
        {
            // throw new NotImplementedException();
            string query = "select * from QUIZ_QuizSubmit where QuizSubmitId = " + id;
            return db.Query<QUIZ_QuizSubmit>(query).SingleOrDefault();
        }

        public List<QUIZ_QuizSubmit> QuizSubmits()
        {
            //throw new NotImplementedException();
            return db.Query<QUIZ_QuizSubmit>("select * from QUIZ_QuizSubmit").ToList();
        }

        public int Update(QUIZ_QuizSubmit quizSubmit)
        {
            //throw new NotImplementedException();
            var sqlQuery = "update QUIZ_QuizSubmit set Answer=@Answer, QuizPoint=@QuizPoint,"+
                " StudentID=@StudentID, QuizID=@QuizID where QuizSubmitId=@QuizSubmitId";
            return db.Execute(sqlQuery, quizSubmit);
        }
    }
}