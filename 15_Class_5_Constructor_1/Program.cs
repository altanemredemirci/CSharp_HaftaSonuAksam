namespace _15_Class_5_Constructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTOR METHOD - YAPICI(KURUCU) METOT
            /*
            Bir sınıftan nesne oluşturulduğu an otomatik çalışan bir metotdur. 
            Bulunduğu class ile aynı ismi taşır.
            Herhangi bir şekilde void veya return gibi değer döndürme özelliğine sahip değildirler.
             */

            Insan insan = new Insan();

            Insan insan2 = new Insan("Uras", "Demirci");
        }
    }

    class Insan
    {
        internal string Ad;
        internal string Soyad;

        //Default olarak arkaplanda aşağıdaki gibi tanımlıdır.
        //public Insan()
        //{

        //}

        //public Insan()
        //{
        //    Console.WriteLine("Constructor metot çalıştı.");
        //}

        public Insan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }


        public Insan()
        {
            //Console.WriteLine("Ad:");
            //Ad = Console.ReadLine();
            //Console.WriteLine("Soyad:");
            //Soyad = Console.ReadLine();

            Kayit();
        }

        public void Kayit()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
        } 
    }
}
