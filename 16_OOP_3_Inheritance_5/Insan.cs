using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_3_Inheritance_5
{
    internal class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        }
    }
}
