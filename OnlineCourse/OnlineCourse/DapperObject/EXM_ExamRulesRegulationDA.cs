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
  
    public class EXM_ExamRulesRegulationDA : I_EXM_ExamRulesRegulation
    {
        private static string connStr = System.Configuration.ConfigurationManager.
        ConnectionStrings["DefaultConnection"].ToString();


        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(EXM_ExamRulesRegulation examRulesRegulation)
        {
            var sqlQuery = "Insert into EXM_ExamRulesRegulation(ExamRulesRegulationText)" +
                "values(@ExamRulesRegulationText)";
            return db.Execute(sqlQuery, examRulesRegulation);
        }

        public int Delete(int? id)
        {
            var query = "Delete from EXM_ExamRulesRegulation where ExamRulesRegulationID=" + id;
            return db.Execute(query);
        }

        public List<EXM_ExamRulesRegulation> ExamRulesRegulations()
        {
            return db.Query<EXM_ExamRulesRegulation>("Select * from EXM_ExamRulesRegulation").ToList();
        }

        public EXM_ExamRulesRegulation Find(int? id)
        {
            string query = "Select * from EXM_ExamRulesRegulation where ExamRulesRegulationID=" + id;
            return db.Query<EXM_ExamRulesRegulation>(query).SingleOrDefault();
        }

        public int Update(EXM_ExamRulesRegulation examRulesRegulation)
        {
            var sqlQuery = "Update EXM_ExamRulesRegulation set ExamRulesRegulationText=@ExamRulesRegulationText"+
                " where ExamRulesRegulationID=@ExamRulesRegulationID";
            return db.Execute(sqlQuery, examRulesRegulation);

        }
    }
}