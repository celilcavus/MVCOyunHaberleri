using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OyunHaberleri.Models.Data
{
    public class OyunlarHaberleri
    {
        public int id { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string icerik { get; set; }
    }
}