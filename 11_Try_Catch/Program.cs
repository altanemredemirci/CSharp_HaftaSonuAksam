namespace _11_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Sayı rakamlardan oluşur.");
            //}



            ////Kullanıcı doğru değer girene kadar tekrarlayan try-catch
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Bir sayı giriniz:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Sayı rakamlardan oluşur.");
            //    }
            //}


            //Alınan Exception a göre hata mesajı yayınlama
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / 0;

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sayı rakamlardan oluşur.");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölme hatası");
            //}

            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi / 0;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            #region Kullanıcıdan 2 sayı alınız. Girilen her değeri kontrol ederek doğru olması halinde toplayınız.
            //2.sayı hatalı ise 1.sayı tekrar sorulmasın

            //int sayi1 = 0, sayi2 = 0;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("1. sayı giriniz:");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        break;                    
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatalı Giriş");
            //    }
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("2. sayı giriniz:");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine(sayi1+sayi2);
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Hatalı Giriş");
            //    }
            //}



            #endregion


        }
    }
}
