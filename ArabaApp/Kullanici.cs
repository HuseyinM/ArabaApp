using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaApp
{
    class Kullanici
    {
        public string Kullaniciid { get; set; }
        string Kullaniciadi;       
        public string Sifre { get; set; }
        public string Kullaniciad { get => Kullaniciadi; set => Kullaniciadi = value.ToUpper(); }
     

    }
}
