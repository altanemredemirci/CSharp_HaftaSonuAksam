namespace _13_Metotlar_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir şirkette çalışan maaş hesaplama programı yazmamız isteniyor.

             Görev1:Aşağıdaki metotları yazınız.

             a) double MaasHesapla(double saatUcreti, int calisilanSaat)
             Parametrelerle gelen saatlik ücret ve çalışılan saati çarparak toplam maaşı hesaplayıp döndüren metot yazın.

             b) double VergiHesapla(double maas)
             Maaşın %20'ini vergi olarak hesaplayıp döndüren metot yazın

             c) double NetMaasHesapla(double brutMaas, double vergi)
             Brüt maaştan vergi çıkararak net maaşı hesaplayıp döndüren metot yazın.

             d) string MaasDurumu(double netMaas)
             Net maaş 150000'den fazla ise "Yüksek Gelir"
             Net maaş 80000-150000 arası ise "Orta Gelir"
             Net maaş 80000'den az ise "Düşük Gelir"
             string olarak döndüren metot yazın.

             Görev2: Main metotunda aşağıdaki işlemleri yapınız.
             Kullanıcıdan saatlik ücret ve çalışılan saat bilgilerini alın
             MaasHesapla metodunu çağırarak brüt maaş hesaplayın
             VergiHesapla metodunu çağırarak vergi hesaplayın
             NetMaasHesapla metodunu çağırarak net maaşı hesaplayın
             MaasDurumu metodunu çağırarak gelir durumunu öğrenin

             */
            Console.WriteLine("Saatlik ücreti giriniz:");
            double saatUcreti = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Çalışılan saati giriniz:");
            int calisilanSaat = Convert.ToInt32(Console.ReadLine());

            double brutMaas = MaasHesapla(saatUcreti, calisilanSaat);
            double vergi = VergiHesapla(brutMaas);
            double netMaas = NetMaasHesapla(brutMaas, vergi);
            string maasDurumu = MaasDurumu(netMaas);

            Console.WriteLine("Brüt maaş: " + brutMaas);
            Console.WriteLine("Vergi: " + vergi);
            Console.WriteLine("Net maaş: " + netMaas);
            Console.WriteLine("Maaş durumu: " + maasDurumu);


        }
        static double MaasHesapla(double saatUcreti, int calisilanSaat)
        {
            double maas = saatUcreti * calisilanSaat;
            return maas;
        }

        static double VergiHesapla(double maas)
        {
            double vergi = maas * 0.20;
            return vergi;
        }

        static double NetMaasHesapla(double brutMaas, double vergi)
        {
            double netMaas = brutMaas - vergi;
            return netMaas;
        }

        static string MaasDurumu(double netMaas)
        {
            if (netMaas > 150000)
            {
                return "Yüksek Gelir";
            }
            else if (netMaas >= 80000 && netMaas <= 150000)
            {
                return "Orta Gelir";
            }
            else
            {
                return "Düşük Gelir";
            }
        }
    }
}

/*
 using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saatlik ücreti giriniz:");
            double saatUcreti = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Çalışılan saati giriniz:");
            int calisilanSaat = Convert.ToInt32(Console.ReadLine());

            double brutMaas = MaasHesapla(saatUcreti, calisilanSaat);
            double vergi = VergiHesapla(brutMaas);
            double netMaas = NetMaasHesapla(brutMaas, vergi);
            string maasDurumu = MaasDurumu(netMaas);

            Console.WriteLine("Brüt maaş: " + brutMaas);
            Console.WriteLine("Vergi: " + vergi);
            Console.WriteLine("Net maaş: " + netMaas);
            Console.WriteLine("Maaş durumu: " + maasDurumu);
        }

        static double MaasHesapla(double saatUcreti, int calisilanSaat)
        {
            double maas = saatUcreti * calisilanSaat;
            return maas;
        }

        static double VergiHesapla(double maas)
        {
            double vergi = maas * 0.20;
            return vergi;
        }

        static double NetMaasHesapla(double brutMaas, double vergi)
        {
            double netMaas = brutMaas - vergi;
            return netMaas;
        }

        static string MaasDurumu(double netMaas)
        {
            if (netMaas > 150000)
            {
                return "Yüksek Gelir";
            }
            else if (netMaas >= 80000 && netMaas <= 150000)
            {
                return "Orta Gelir";
            }
            else
            {
                return "Düşük Gelir";
            }
        }
    }
}
 
 */