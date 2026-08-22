namespace _16_OOP_3_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("AD:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("SOYAD:");
            //string soyisim = Console.ReadLine();

            //Insan insan = new Insan(isim,soyisim);

            //Console.WriteLine(insan.Ad);
            //Console.WriteLine(insan.Soyad);

            Ogrenci ogrenci = new Ogrenci("Altan Emre","Demirci",12);

           

        }
    }

    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Insan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
    }

    class Ogrenci : Insan
    {
        public int Numara { get; set; }

        public Ogrenci(string isim,string soyisim,int no):base(isim, soyisim) //base:miras alınan sınıfı işaret eder.
        {
            Numara = no;
        }
    }
}
