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
    public class QUIZ_QuizDA : I_QUIZ_Quiz
    {
        private static string connStr = System.Configuration.ConfigurationManager.
             ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);

        public int Add(QUIZ_Quiz quiz)
        {
            // throw new NotImplementedException();
            var sqlQuery = "insert into QUIZ_Quiz (QuizQuestion, Answer, Option1, Option2,"+
                "Option3, Option4, CourseID, UserID) values"+
                "( @QuizQuestion, @Answer, @Option1, @Option2, @Option3, @Option4, @CourseID, @UserID)";
            return db.Execute(sqlQuery, quiz);
        }

        public int Delete(int? id)
        {
            // throw new NotImplementedException();
            var sqlQuery = "delete from QUIZ_Quiz where QuizID=" + id;
            return db.Execute(sqlQuery);
        }

        public QUIZ_Quiz Find(int? id)
        {
            // throw new NotImplementedException();
            string query = "select * from QUIZ_Quiz where QuizID=" + id;
            return db.Query<QUIZ_Quiz>(query).SingleOrDefault();
        }

        public List<QUIZ_Quiz> Quizs()
        {
            //throw new NotImplementedException();
            return db.Query < QUIZ_Quiz > ("select * from QUIZ_Quiz").ToList();
        }

        public int Update(QUIZ_Quiz quiz)
        {
            //throw new NotImplementedException();
            var sqlQuery = "update QUIZ_Quiz set QuizQuestion=@QuizQuestion, Answer=@Answer,"+
                " Option1=@Option1, Option2=@Option2, Option3=@Option3, Option4=@Option4,"+
                " CourseID=@CourseID, UserID=@UserID where QuizID=@QuizID";
            return db.Execute(sqlQuery, quiz);
        }

       
    }
}