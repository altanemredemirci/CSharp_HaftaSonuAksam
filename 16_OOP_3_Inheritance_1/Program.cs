namespace _16_OOP_3_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             **** INHERITANCE - KALITIM ****
             *Ortak özelliklere sahip birden fazla classın bir ortak classtan bu özellikleri miras almasına kalıtım denir. Amaç birden fazla classı tek bir classtan türeterek geliştirme ve kontrol kolaylığı sağlamaktır.Büyük çaplı projelerde kullanılır.
             *

             */

            InsanKaynaklari ik = new InsanKaynaklari();
            ik.Yaz();
        }
    }

    //Şirket Otomasyonu
    //InsanKaynaklari:Ad,Soyad,TC,DogumYılı,PersonelSayisi
    //BilgiIslem: Ad,Soyad,TC,DogumYılı,ProgramSayisi
    //Muhasebe:Ad,Soyad,TC,DogumYılı,HesapSayisi
    //Pazarlama:Ad,Soyad,TC,DogumYılı,TeklifSayisi

    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public int DogumYili { get; set; }
        public int Yas { get; set; }

        public void Yaz()
        {
            Console.WriteLine("Ben bir insanım.");
        }
    }


    class InsanKaynaklari: Insan //private özellikler haricinde herşey miras alınabilir.
    {
        public int PersonelSayisi { get; set; }
    }

    class BilgiIslem:Insan
    {
        public int ProgramSayisi { get; set; }
    }

    class Muhasebe:Insan
    {       
        public int HesapSayisi { get; set; }
    }

    class Pazarlama:Insan
    {
        public int TeklifSayisi { get; set; }
    }
}
