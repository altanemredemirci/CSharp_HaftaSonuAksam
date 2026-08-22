using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_3_Inheritance_5
{
    internal class Ogrenci : Insan
    {
        //No,Ad,Soyad,Sınıf

        public int No { get; set; }
        public string Sinif { get; set; }


        //NameHiding:İsim gizleme. Miras alınan sınıfta aynı isimle tanımlanan metodu gizleyerek bu sınıftaki tanımı kullandırdık.
        public new void Kaydet()
        {
            base.Kaydet();

            Console.WriteLine("No:");
            No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sınıf:");
            Sinif = Console.ReadLine();
        }
    }
}
