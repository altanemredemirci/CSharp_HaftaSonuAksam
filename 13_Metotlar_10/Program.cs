namespace _13_Metotlar_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEĞER DÖNDÜREN METOTLAR
            //Bir metot gerçekleştirdiği işlem sonucunu çağrıldığı yere geri taşır.
            //Değer döndüren metotlarda void yerine metodun geriye taşıyacağı veri tipi yazılır ve metotdun en altında mutlaka return kelimesi ile bu değer döndürülür.



            //int sonuc = Toplam();
            //Console.WriteLine(sonuc);

            //Kullanıcıdan alınan 2 ürün fiyatından ucuz olana %30 indirim uygulayın ve 3. ürün ister misiniz diye soralım ve evet cevabımı alırsak 3.rün fiyatı alan ve %50 indirim uygulayan ve sonucu geri döndüren metodu yazınız.

            Indirim2();

        }

        static int Toplam()
        {
            Console.WriteLine("1.sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;

            return toplam; //return geri döndürmek anlamına gelir ve metodun çağrıldığı yere değeri taşır.
        }

        static void Indirim2()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat1 > fiyat2)
            {
                fiyat2 = fiyat2 * 0.7;
            }
            else
            {
                fiyat1 = fiyat1 * 0.7;
            }

            Console.WriteLine("3.Ürün İster Misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                double fiyat3 = Indirim3();
                Console.WriteLine("Ödemeniz:"+(fiyat1+fiyat2+fiyat3));
            }
            else
            {
                Console.WriteLine("Ödemeniz:"+(fiyat1+fiyat2));
            }


        }

        static double Indirim3()
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double fiyat3 = Convert.ToDouble(Console.ReadLine());

            return fiyat3 / 2;
        }
    }
}
