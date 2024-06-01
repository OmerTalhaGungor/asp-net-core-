using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webodev3.Models
{
    public class Kayit
    {
        public int Id { get; set; }
        public string ?Tip { get; set; }
        public string ?MarkaAdi { get; set; }
        public int Fiyat { get; set; }
        public string ?Aciklama { get; set; }

    }
}