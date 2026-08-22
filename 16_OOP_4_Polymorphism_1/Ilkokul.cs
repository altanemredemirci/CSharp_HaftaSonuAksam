using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_4_Polymorphism_1
{
    internal class Ilkokul:Ogrenci
    {
        public string Sinif { get; set; }

        //Miras alınan virtual tanımlı bir metodu override ederek yeniden tanımlama işlemine Dinamik Polymorphism denir.
        public override void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();

            Console.WriteLine("Sınıf:");
            Sinif = Console.ReadLine();
        }
    }
}
