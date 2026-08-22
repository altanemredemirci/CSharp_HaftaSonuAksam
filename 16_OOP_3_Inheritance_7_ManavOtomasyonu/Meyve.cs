using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_3_Inheritance_7_ManavOtomasyonu
{
    internal class Meyve:Urun
    {
        public static void Listele(List<Meyve> liste)
        {
            foreach (Meyve item in liste)
            {
                Console.WriteLine($"{item.No}-{item.Ad}:{item.Fiyat}({item.Stok} stok)");
            }
        }

        public static void MeyveSatinAl(List<Meyve> liste, List<Meyve> satinAlListe)
        {
            Console.WriteLine("Lütfen seçtiğiniz meyvenin numarası giriniz:");
            int meyveNo = Convert.ToInt32(Console.ReadLine());

            Meyve secilenMeyve = liste.FirstOrDefault(i => i.No == meyveNo);

            if (secilenMeyve != null)
            {
                Console.WriteLine("Kaç kilo?");
                int kilo = Convert.ToInt32(Console.ReadLine());

                if (secilenMeyve.Stok >= kilo)
                {
                    secilenMeyve.Stok -= kilo;

                    satinAlListe.Add(new Meyve()
                    {
                        No = secilenMeyve.No,
                        Ad = secilenMeyve.Ad,
                        Fiyat = Math.Floor(secilenMeyve.Fiyat * 1.1),
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
