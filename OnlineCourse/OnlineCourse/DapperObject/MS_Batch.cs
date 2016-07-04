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
    public class MS_Batch:I_MS_Batch
    {
        public static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);


        public List<MS_Batch> Batches()
        {
            return db.Query<MS_Batch>("Select * from MS_Batch").ToList();
        }

        public int Add(MS_Batch batch)
        {
            var sqlQuery = "Insert into MS_Batch(BatchID, Batch) Values (@BatchID, @Batch)";
            return db.Execute(sqlQuery, batch);
        }


        public MS_Batch Find(int? id)
        {
            string query = "Select from MS_Batch where BatchID=" + id;
            return db.Query<MS_Batch>(query).SingleOrDefault();

        }

        public int Update(MS_Batch batch)
        {
            var sqlQuery = "Update MS_Batch set  Batch= @Batch Where BatchID = @BatchID";
            return db.Execute(sqlQuery, batch);
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from MS_Batch where BatchID=" + id;
            return db.Execute(sqlQuery);
        }
    }
}