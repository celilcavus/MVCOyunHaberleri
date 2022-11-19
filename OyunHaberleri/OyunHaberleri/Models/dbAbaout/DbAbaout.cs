using OyunHaberleri.Models.Data;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using OyunHaberleri.Models.DataContext;

namespace OyunHaberleri.Models.dbAbaout
{
    public static class DbAbaout
    {
        public static List<hakkimizda> getAbaoutList()
        {
            return DContext.sqliteconn.Query<hakkimizda>("select * from hakkimizda").ToList();
        }
        public static List<hakkimizda> getAbaoutList(string query)
        {
            return DContext.sqliteconn.Query<hakkimizda>(query).ToList();
        }
    }
}