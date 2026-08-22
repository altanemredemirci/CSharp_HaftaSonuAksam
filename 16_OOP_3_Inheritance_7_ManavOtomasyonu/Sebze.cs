using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_3_Inheritance_7_ManavOtomasyonu
{
    internal class Sebze:Urun
    {
        public static void Listele(List<Sebze> liste)
        {
            foreach (Sebze item in liste)
            {
                Console.WriteLine($"{item.No}-{item.Ad}:{item.Fiyat}({item.Stok} stok)");                
            }
        }

        public static void SebzeSatinAl(List<Sebze> liste, List<Sebze> satinAlListe)
        {
            Console.WriteLine("Lütfen seçtiğiniz sebzenin numarası giriniz:");
            int sebzeNo = Convert.ToInt32(Console.ReadLine());

            Sebze secilenSebze = liste.FirstOrDefault(i => i.No == sebzeNo);

            if (secilenSebze != null)
            {
                Console.WriteLine("Kaç kilo?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (secilenSebze.Stok >= kilo)
                {
                    secilenSebze.Stok -= kilo;

                    satinAlListe.Add(new Sebze()
                    {
                        No = secilenSebze.No,
                        Ad = secilenSebze.Ad,
                        Fiyat = Math.Floor(secilenSebze.Fiyat * 1.1),
                        Stok = kilo
                    });
                }
                else
                {
                    Console.WriteLine("Stoğu aşan talep!");
                }
            }


        }
    }
}
