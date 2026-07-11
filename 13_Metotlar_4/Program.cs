namespace _13_Metotlar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 sayı bir işlem alarak, alınan işlemi sayılara uygulayarak sonucu ekrana yazdıran metodu yazınız.

            //Console.Write("1. Sayıyı Giriniz: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İşlem Giriniz (+,-,*,/): ");
            //char islem = Convert.ToChar(Console.ReadLine());

            //Hesapla(sayi1, sayi2, islem);


            DortIslem();
        }

        //AYŞE
        static void Hesapla(double s1, double s2, char islem)
        {
            if (islem == '+')
                Console.WriteLine("Sonuç: " + (s1 + s2));
            else if (islem == '-')
                Console.WriteLine("Sonuç: " + (s1 - s2));
            else if (islem == '*')
                Console.WriteLine("Sonuç: " + (s1 * s2));
            else if (islem == '/')
            {
                if (s2 != 0)
                    Console.WriteLine("Sonuç: " + (s1 / s2));
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
            }
            else
            {
                Console.WriteLine("Geçersiz işlem girdiniz.");
            }
        }

        static void DortIslem()
        {
            Console.Write("1. Sayıyı Giriniz: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem Giriniz (+,-,*,/): ");
            string islem = Console.ReadLine();

            if (islem == "+")
                Console.WriteLine("Sonuç: " + (s1 + s2));
            else if (islem == "-")
                Console.WriteLine("Sonuç: " + (s1 - s2));
            else if (islem == "*")
                Console.WriteLine("Sonuç: " + (s1 * s2));
            else if (islem == "/")
            {
                if (s2 != 0)
                    Console.WriteLine("Sonuç: " + (s1 / s2));
                else
                    Console.WriteLine("Sıfıra bölme hatası!");
            }
            else
            {
                Console.WriteLine("Geçersiz işlem girdiniz.");
            }
        }
    }
}
