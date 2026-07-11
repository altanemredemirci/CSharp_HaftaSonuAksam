namespace _13_Metotlar_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 2 sayı bir işleme karşılık gelen metodu yazınız. işlemleri ayrı ayrı metotlar olarak tanımlayınız.

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

    class DortIslem
    {
        public static void Toplama(int s1,int s2)
        {
            Console.WriteLine("Sonuç:"+(s1+s2));
        }
        public static void Cikarma(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 - s2));
        }
        public static void Carpma(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 * s2));
        }
        public static void Bolme(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 / s2));
        }
    }
}
