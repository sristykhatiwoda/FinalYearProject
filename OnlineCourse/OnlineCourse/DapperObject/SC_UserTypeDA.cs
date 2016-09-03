using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineCourse.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace OnlineCourse.DapperObject
{
    public class SC_UserTypeDA : I_SC_UserType
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);


        public List<SC_UserType> UserTypes()
        {
            return db.Query<SC_UserType>("Select * from SC_UserType").ToList();
        }

        public int Add(SC_UserType userType)
        {
            var sqlQuery = "Insert into SC_UserType(Type) Values (@Type)";
            return db.Execute(sqlQuery, userType);
        }


        public SC_UserType Find(int? id)
        {
            string query = "Select * from SC_UserType where UserTypeID=" + id;
            return db.Query<SC_UserType>(query).SingleOrDefault();

        }

        public int Update(SC_UserType userType)
        {
            var sqlQuery = "Update SC_UserType set  Type = @Type Where UserTypeID = @UserTypeID";
            return db.Execute(sqlQuery, userType);
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from SC_UserType where UserTypeID=" + id;
            return db.Execute(sqlQuery);
        }

    }
}
