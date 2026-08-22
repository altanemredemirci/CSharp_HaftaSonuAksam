using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_4_Polymorphism_1
{
    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public virtual void Kaydet() //virtual kelimesi ile türeyen sınıflarda ezilerek(override) yeniden yazılabilir özelliği kazandırdım.
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }
}
