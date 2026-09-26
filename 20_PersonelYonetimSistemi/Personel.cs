using System;
using System.Collections.Generic;
using System.Text;

namespace _20_PersonelYonetimSistemi
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Isim + " " + Soyisim +" "+ EmailAdres + " "+Telefon;
        }
    }
}
