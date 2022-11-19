using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using OyunHaberleri.Models.Data;
using OyunHaberleri.Models.DataContext;

namespace OyunHaberleri.Models.dbGamaPage
{
    public static class DbGamePage
    {
        public static List<Oyunlar> getGamePageList()
        {
            return DContext.sqliteconn.Query<Oyunlar>("select * from Oyunlar").ToList();
            
        }
        public static List<Oyunlar> getQuery(string query)
        {
            return DContext.sqliteconn.Query<Oyunlar>(query).ToList();
        }
    }
}