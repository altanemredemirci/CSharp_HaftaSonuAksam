using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_9_RestaurantOtomasyonu
{
    internal class Yemek
    {
        internal int No;
        internal string Ad;
        internal double Fiyat;

        internal static Yemek YemekSec(Menu menu)
        {
            foreach (Yemek yemek in menu.Yemekler)
            {
                Console.WriteLine(yemek.No + "-" + yemek.Ad + ":" + yemek.Fiyat);
            }

            Console.WriteLine("Seçilen Yemek No:");
            int yemekNo = Convert.ToInt32(Console.ReadLine());

            return menu.Yemekler.FirstOrDefault(i => i.No == yemekNo);   
        }

        internal static void YemekEkle(List<Menu> menuler)
        {
            Yemek yemek = new Yemek();
            Console.WriteLine("Yemek No:");
            yemek.No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yemek Adı:");
            yemek.Ad = Console.ReadLine();
            Console.WriteLine("Yemek Fiyatı:");
            yemek.Fiyat = Convert.ToDouble(Console.ReadLine());

            Menu secilenMenu = Menu.MenuSec(menuler);
            secilenMenu.Yemekler.Add(yemek);
            Console.WriteLine($"{secilenMenu.Ad} menüsüne {yemek.Ad} yemeği eklendi.");
        }

        internal static void YemekGuncelle(List<Menu> menuler)
        {
            Menu secilenMenu = Menu.MenuSec(menuler);

            Yemek secilenYemek = Yemek.YemekSec(secilenMenu);

            Console.WriteLine("Yeni Yemek Adı:");
            secilenYemek.Ad = Console.ReadLine();
            Console.WriteLine("Yemek Fiyatı:");
            secilenYemek.Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{secilenMenu.Ad} menüsüne {secilenYemek.Ad} yemeği güncellendi.");
        }

        internal static void YemekSil(List<Menu> menuler)
        {
            Menu secilenMenu = Menu.MenuSec(menuler);

            Yemek secilenYemek = Yemek.YemekSec(secilenMenu);

            secilenMenu.Yemekler.Remove(secilenYemek);

            Console.WriteLine($"{secilenMenu.Ad} menüsüne {secilenYemek.Ad} yemeği silindi.");
        }
    }
}
