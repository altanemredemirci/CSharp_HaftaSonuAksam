namespace _16_OOP_3_Inheritance_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Altan Emre","Demirci","Erkek");
            ogrenci.Yazdir();
        }
    }

    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected string Cinsiyet { get; set; }
        //protected sadece tanımlandığı ve miras alındığı sınıf içerisinde kullanılabilir.

        public void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();

            Console.WriteLine("Cinsiyet:");
            Cinsiyet = Console.ReadLine();
        }
    }

    class Ogrenci : Insan
    {
        public Ogrenci(string ad, string soyad, string cinsiyet)
        {
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }

        public void Yazdir()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(Cinsiyet);
        }
    }
}
