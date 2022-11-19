using OyunHaberleri.Models.Data;
using System.Collections.Generic;
using Dapper;
using OyunHaberleri.Models.DataContext;
using System;

namespace OyunHaberleri.Models.dbContact
{
    public static class DbContact
    {
        public static int InsertContact(iletisim iletisim)
        {
            var insertItem = new
            {
                iletisim.ad,
                iletisim.soyad,
                iletisim.email,
                iletisim.aciklama
            };
            return DContext.sqliteconn.Execute($"insert into iletisim (ad,soyad,email,aciklama) values ('{iletisim.ad.ToString()}','{iletisim.soyad.ToString()}','{iletisim.email.ToString()}','{iletisim.aciklama.ToString()}')");
        }
    }
}