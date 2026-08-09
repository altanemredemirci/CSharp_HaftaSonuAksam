using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_5_Kutuphane
{
    internal class Uye
    {
        internal int UyeNo;
        internal string AdSoyad;
        internal List<Kitap> AldigiKitaplar;

        public Uye()
        {
            AldigiKitaplar = new List<Kitap>();
        }


        internal static void Ekle(List<Uye> liste)
        {
            Uye uye = new Uye();
            
            Console.WriteLine("Uye No:");
            uye.UyeNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad Soyad:");
            uye.AdSoyad = Console.ReadLine();

            liste.Add(uye);
                        
        }

        internal static void Listele(List<Uye> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine(item.UyeNo);
                Console.WriteLine(item.AdSoyad);

                if (item.AldigiKitaplar.Count > 0)
                {
                    foreach (var kitap in item.AldigiKitaplar)
                    {
                        Console.WriteLine("ISBN:" + kitap.ISBN);
                        Console.WriteLine("Kitap Adı:" + kitap.Ad);
                        Console.WriteLine("Yazar Adı:" + kitap.Yazar);
                    }
                }
            }
        }
    }
}
