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
    public class SC_UserDA : I_SC_User
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);



        public List<SC_User> Users()
        {
            return db.Query<SC_User>("Select * from SC_User").ToList();
        }

        public int Add(SC_User user)
        {
            var sqlQuery = "Insert into SC_User(UserID, FirstName, MiddleName, LastName, Email, Phone, Address, Password, UserTypeID)" +
                "Values(@UserID, @FirstName, @MiddleName, @LastName, @Email, @Phone, @Address, @Password, @UserTypeID)";
            return db.Execute(sqlQuery, user);
        }

        public SC_User Find(int? id)
        {
            string query = "Select from SC_User where UserID" + id;
            return db.Query<SC_User>(query).SingleOrDefault();

        }

        public int Update(SC_User user)
        {
            var sqlQuery = "Update SC_User set UserID = @UserID, FirstName = @FirstName, MiddleName = @MiddleName," +
                "LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address, Password = @Password, UserTypeID = @UserTypeID" +
                "Where UserID = @UserID";
            return db.Execute(sqlQuery, user);
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from SC_User where UserID=" + id;
            return db.Execute(sqlQuery);
        }

    }
}
