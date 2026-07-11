using _13_Metotlar_8;

namespace _13_Metotlar_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem(+,-,*,/):");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                DortIslem.Toplama(sayi1, sayi2);
            }
            else if (islem == "-")
            {
                DortIslem.Cikarma(sayi1, sayi2);
            }
            else if (islem == "*")
            {
                DortIslem.Carpma(sayi1, sayi2);
            }
            else if (islem == "/")
            {
                DortIslem.Bolme(sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı İşlem!");
            }

        }
    }
}
