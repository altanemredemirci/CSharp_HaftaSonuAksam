namespace _16_OOP_3_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Roman     :kitap adı,yazar adı,konu
            //Ders kitap:kitap adı,yazar adı,sayfaSayisi

            //Yukarıdaki iki classı inheritance ile türeterek constructor metot ile özelliklerini dolduralım

            Roman roman = new Roman("Çalıkuşu", "Reşat Nuri Güntekin", "Aşk");

            Console.WriteLine(roman.Konu);
        }
    }

    class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }

        public Kitap(string kitapAdi,string yazarAdi)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
        }
    }

    class Roman : Kitap
    {
        public string Konu { get; set; }

        public Roman(string kitapAdi, string yazarAdi,string konu):base(kitapAdi,yazarAdi)
        {
            Konu = konu;
        }
    }

    class DersKitap : Kitap
    {
        public int SayfaSayisi { get; set; }

        public DersKitap(string kitapIsmi, string yazarIsmi,int sayfaSayisi):base(kitapIsmi,yazarIsmi)
        {
            SayfaSayisi = sayfaSayisi;
        }
    }
}
