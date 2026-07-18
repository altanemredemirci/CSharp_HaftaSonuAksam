using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Metotlar_12
{
    internal class Dizi
    {
        internal static void SayiUret()
        {
            int[] sayilar = new int[10];

            Console.WriteLine("Başlangıç:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (basla > bitis)
            {
                int temp = basla;
                basla = bitis;
                bitis = temp;
            }

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = r.Next(basla, bitis);
            }

            DiziYazdir(sayilar);

            Console.WriteLine("En Büyük Değer:" + EnBuyukDeger(sayilar));
            Console.WriteLine("En Küçük Değer:" + EnKucukDeger(sayilar));
        }

        internal static void DiziYazdir(int[] dizi)
        {
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }
        }

        internal static int EnBuyukDeger(int[] dizi)
        {
            int buyuk = dizi[0];

            foreach (int item in dizi)
            {
                if (item > buyuk)
                {
                    buyuk = item;
                }
            }

            return buyuk;
        }

        internal static int EnKucukDeger(int[] dizi)
        {
            int kucuk = dizi[0];

            foreach (int item in dizi)
            {
                if (item < kucuk)
                {
                    kucuk = item;
                }
            }

            return kucuk;
        }
    }
}
