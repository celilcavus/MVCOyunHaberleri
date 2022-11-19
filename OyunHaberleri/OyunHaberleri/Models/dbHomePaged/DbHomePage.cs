using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OyunHaberleri.Models.Data;
using Dapper;
namespace OyunHaberleri.Models.HomePage
{
    public static class DbHomePage
    {
        
        
        public static List<OyunlarHaberleri> getQuery(string query)
        {
          var data =   DataContext.DContext.sqliteconn.Query<OyunlarHaberleri>(query).ToList();

            return data;
        }
    }
}