namespace _13_Metotlar_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEFAULT - REF - OUT - PARAMS

            // ***** DEFAULT *****
            //Metot tanımlanırken verilen parametrenin metot çağrılırken gönderilmesi gereklidir. Biz metodun parametresine default bir değer atayarak, çağrıldığı yerde gönderilmezse bu default değeri kullanmasını sağlayabiliriz.


            // ***** OUT ***** 
            // Metot tanımlanırken verilen parametre ismi ile çağrılırken gönderilen parametre aynı olmak zorunda değildir ama ben metoda gönderilen değerin değiştirilmesi halinde dışarıdaki değerinde değişmesini istiyorsam out kelimesi kullanılır. out ile tanımlanan değişkene ilk değer verilmesi zournlu değildir ama metot içinde mutlaka manipüle(değişme) olması gereklidir. 


            // ***** REF ***** 
            // Metot tanımlanırken verilen parametre ismi ile çağrılırken gönderilen parametre aynı olmak zorunda değildir ama ben metoda gönderilen değerin değiştirilmesi halinde dışarıdaki değerinde değişmesini istiyorsam ref kelimesi kullanılır. ref ile tanımlanan değişkene ilk değer verilmesi zorunludur. out dun aksine ref olan değer metot içerisinde değiştirilmek zorunda değildir. 


            // ***** PARAMS *****
            // Metoda değişken sayıda parametre vermemizi sağlar.


            //Manav Otomasyonu - Otomat Makinesi Metot haline getirin


            //Yaz("Altan Emre");
            //Yaz();


            //int s = 5;
            //SayiDegistir(out s);
            //Console.WriteLine(s);


            //int s =5;
            //SayiDegistir(ref s);
            //Console.WriteLine(s);

            //Array.Resize(ref sayilar, 10);


            SayiTopla(1, 2, 3);
            SayiTopla(1, 2, 3,4,5);
            SayiTopla(1, 2, 3,4,5,6,7,8,9);


        }

        //static void Yaz(string metin="Uras Demirci")
        //{
        //    Console.WriteLine(metin);
        //}

        //static void SayiDegistir(out int sayi)
        //{
        //    sayi = 10;
        //}


        static void SayiDegistir(ref int sayi)
        {
            sayi = 10;
        }

        static void SayiTopla(params int[] dizi)
        {
            int toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam);
        }
    }
}
