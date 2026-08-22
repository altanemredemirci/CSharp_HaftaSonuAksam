using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_3_Inheritance_5
{
    internal class Ogretmen : Insan
    {
        //Ad,Soyad,Brans
        public string Brans { get; set; }

        public new void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Branş:");
            Brans = Console.ReadLine();
        }
    }
}
