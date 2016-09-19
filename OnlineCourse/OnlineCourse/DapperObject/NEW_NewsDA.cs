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
    public class NEW_NewsDA : I_NEW_News
    {
        private static string connStr = System.Configuration.ConfigurationManager.
            ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);

        public int Add(NEW_News news)
        {
            //throw new NotImplementedException();
            var sqlQuery = "Insert into NEW_News (NewsTitle,NewsDate,NewsDescription, UserID)"+
                " values (@NewsTitle,@NewsDate,@NewsDescription,@UserID)";
            return db.Execute(sqlQuery, news); 
        }

        public int Delete(int? id)
        {
            // throw new NotImplementedException();
            var sqlQuery = "Delete from NEW_News where NewsID=" + id;
            return db.Execute(sqlQuery);
        }

        public NEW_News Find(int? id)
        {
            // throw new NotImplementedException();
            string query = "Select * from NEW_News where NewsID=" + id;
            return db.Query<NEW_News>(query).SingleOrDefault();
        }

        public List<NEW_News> News()
        {
            //throw new NotImplementedException();
            return db.Query<NEW_News>("Select * from NEW_News").ToList();
        }

        public int Update(NEW_News news)
        {
            //throw new NotImplementedException();
            var sqlQuery = "Update NEW_News set NewsTitle = @NewsTitle,"+
                "NewsDate=@NewsDate,NewsDescription=@NewsDescription, UserID=@UserID where NewsID=@NewsID";
            return db.Execute(sqlQuery, news);
        }
    }
}