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
    public class STU_StudentDA : I_STU_Student
    {
        public static string connStr = System.Configuration.ConfigurationManager.
          ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(STU_Student student)
        {
            var sqlQuery = "Insert into STU_Student" +
                "(FirstName,MiddleName,LastName,Email,Password,FacultyID,BatchID,SemesterID)" +
                "VALUES" +
                "(@FirstName,@MiddleName,@LastName,@Email,@Password,@FacultyID,@BatchID,@SemesterID)";
            return db.Execute(sqlQuery, student);
        }

        public int Update(STU_Student student)
        {
            var sqlQuery = "Update STU_Student SET FirstName=@FirstName,MiddleName=@MiddleName " +
               "LastName=@LastName,Email=@Email,Password=@Password,FacultyID=@FacultyID" +
               "BatchID=@BatchID,SemesterID=@SemesterID";
            return db.Execute(sqlQuery, student);
        }


        public int Delete(int? id)
        {
            var sqlQuery = "Delete from STU_Student where StudentID=" + id;
            return db.Execute(sqlQuery);
        }



        public List<STU_Student> Students()
        {

            return db.Query<STU_Student>("SELECT * FROM STU_Student").ToList();
        }

        public STU_Student Find(int? id)
        {
            string query = "SELECT * FROM STU_Student WHERE StudentID = " + id;
            return db.Query<STU_Student>(query).SingleOrDefault();

        }


    }   
}