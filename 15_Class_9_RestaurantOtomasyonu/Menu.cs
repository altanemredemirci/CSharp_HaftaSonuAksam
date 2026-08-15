using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_9_RestaurantOtomasyonu
{
    internal class Menu
    {
        internal int No;
        internal string Ad;
        internal List<Yemek> Yemekler;
        
        internal static Menu MenuSec(List<Menu> menuler)
        {
            foreach (Menu menu in menuler)
            {
                Console.WriteLine(menu.No+"-"+menu.Ad);
            }

            Console.WriteLine("Seçilen Menu No:");
            int menuNo = Convert.ToInt32(Console.ReadLine());

            //menüler listenin içindeki her menüyü i değişkenine atar ve sırasıyla No eşleşen ilk kaydı bana geri getirir. No eşleşmezse null döndürür.
            return menuler.FirstOrDefault(i => i.No == menuNo);
        }

        internal static void MenuEkle(List<Menu> menuler)
        {
            Menu menu = new Menu();

            Console.WriteLine("Yeni Menü No:");
            menu.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yeni Menü Adı:");
            menu.Ad = Console.ReadLine();

            menu.Yemekler = new List<Yemek>();
            menuler.Add(menu);
        }

        internal static void MenuSil(List<Menu> menuler)
        {
            Menu secilenMenu = Menu.MenuSec(menuler);

            menuler.Remove(secilenMenu);
            Console.WriteLine($"Menüler listesinden {secilenMenu.Ad} menüsü silindi.");
        }
    }
}
