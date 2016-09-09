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
    public class MS_BatchDA : I_MS_Batch
    {
        public static string connStr = System.Configuration.ConfigurationManager.
            ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(MS_Batch batch)
        {
            var sqlQuery = "Insert into MS_Batch(Year) Values (@Year)";
            return db.Execute(sqlQuery, batch);   
        }

        public List<MS_Batch> Batches()
        {
            return db.Query <MS_Batch> ("Select * from MS_Batch").ToList(); 
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from MS_Batch where BatchID=" + id;
            return db.Execute(sqlQuery);
        }

        public MS_Batch Find(int? id)
        {
            var query = "Select * from MS_Batch where BatchID=" + id;
            return db.Query<MS_Batch>(query).SingleOrDefault();
        }
    
        public int Update(MS_Batch batch)
        {
            var sqlQuery = "Update MS_Batch set Year=@Year where BatchID=@BatchID";
            return db.Execute(sqlQuery,batch);
        }
    }
}