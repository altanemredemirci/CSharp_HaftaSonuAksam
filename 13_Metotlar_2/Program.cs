namespace _13_Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******* DEĞER DÖNDÜRMEYEN METOT ********
            //void keyword(anahtar kelime) değer dönmeyeceği tanımlar

            //Toplama();

            //Toplama2(15,25);

            Console.WriteLine("1.Sayı Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Toplama2(sayi1, sayi2);

        }

        static void Toplama() //Parametresiz Değer Döndürmeyen Metot
        {
            Console.WriteLine("1.sayıyı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:"+toplam);
        }

        static void Toplama2(int s1,int s2) //Parametreli Değer Döndürmeyen Metot
        {
            int toplam = s1 + s2;

            Console.WriteLine("Toplam:"+toplam);
        }
    }
}
