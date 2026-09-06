using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_7_Proje
{
    internal abstract class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil{ get; set; }
        public string Plaka{ get; set; }
        public double GunlukKiralamaBedeli{ get; set; }

        public Arac(string marka,string model,int yil,string plaka,double gunlukKiralamaBedeli)
        {
            Marka=marka;
            Model=model;
            Yil=yil;
            Plaka=plaka;
            GunlukKiralamaBedeli=gunlukKiralamaBedeli;
        }

        public abstract double KiraUcretHesapla(int gun);
        public abstract void AracBilgileriGoster();
        public abstract string AracTipiGetir();


        public virtual void GenelBilgi()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Model);
            Console.WriteLine(Yil);
            Console.WriteLine(Plaka);
            Console.WriteLine(GunlukKiralamaBedeli);
        }
    }
}
