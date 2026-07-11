namespace _13_Metotlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****** METOT İMZASI ******
            //Aynı isimde tanımlanan metotları birbirinden ayıran yapıya metot imzası denir.
            //Metot imzası parametre sayısı ve parametrenin veri tipi ile tanımlanır.

            Toplama();
            Toplama(11,22);
            Toplama(11.5, 22);
            Toplama(11, 22.5);
            Toplama(11, 22, 33);

            //Metodun aynı isimle tanımlanması ve metot imzasıyla farklı olmasına metodun aşırı yüklenmesi(overloading) denir.

        }

        static void Toplama()
        {
            Console.WriteLine("1.sayıyı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }

        static void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }

        static void Toplama(double sayi1, int sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }

        static void Toplama(int sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }

        static void Toplama(int sayi1, int sayi2, int sayi3)
        {
            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Toplam:" + toplam);
        }
    }
}
