using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OyunHaberleri.Models.Data
{
    public class iletisim
    {
        public int id { get; set; }
        [Required]
        public string ad { get; set; }
        [Required]
        public string soyad { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string aciklama { get; set; }
    }
}