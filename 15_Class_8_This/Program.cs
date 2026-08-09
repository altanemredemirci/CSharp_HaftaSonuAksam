namespace _15_Class_8_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this kelimesi classdaki nesneyi temsil eder.
        }
    }

    class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public string Sinif;

        public Ogrenci(string Ad, string Soyad, string Sinif)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Sinif = Sinif;
            this.Kayit();
        }


        public void Kayit()
        {
            Console.WriteLine("Kayit Çalıştı");
        }
    }
}
