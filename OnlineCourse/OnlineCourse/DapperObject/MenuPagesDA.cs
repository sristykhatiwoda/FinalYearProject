using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    public class MenuPagesDA:I_MenuPages
    {
        private static string connStr = System.Configuration.ConfigurationManager.
            ConnectionStrings["DefaultConnection"].ToString();

        public static IDbConnection db = new SqlConnection(connStr);
        public int Add(MenuPages menuPage)
        {
            var sqlQuery = "Insert into MenuPages(MenuTitle,PageContent,DisplayOrder,IsActive)" +
                 "values" +
                   "(@MenuTitle,@PageContent,@DisplayOrder,@IsActive)";
            return db.Execute(sqlQuery, menuPage);
        }

        public int Delete(int? id)
        {
            var sqlQuery = "Delete from MenuPages where MenuPageID=" + id;
            return db.Execute(sqlQuery);
        }

        public MenuPages Find(int? id)
        {
            string query = "Select * from MenuPages Where MenuPageID=" + id;
            return db.Query<MenuPages>(query).SingleOrDefault();
        }

        public List<MenuPages> MenuPages()
        {
            return db.Query<MenuPages>("Select * from MenuPages").ToList();
        }

        public int Update(MenuPages menuPage)
        {
            var sqlQuery = "Update MenuPages set MenuTitle=@MenuTitle,PageContent=@PageContent,DisplayOrder=@DisplayOrder,IsActive=@IsActive" +
                " Where MenuPageID=@MenuPageID";
            return db.Execute(sqlQuery, menuPage);
        }
    }
}