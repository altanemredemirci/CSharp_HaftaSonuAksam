using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_3
{
    internal class Kitap
    {
        public string BarkodNo;
        public string KitapAdi;
        public string Yazar;

        public static void Kayit(List<Kitap> kitapListesi)
        {
            //Nesne. tanımlı olduğu class a ait özellikleri barındıran canlı yazılım kavramıdır.

            Kitap kitap = new Kitap(); //Nesne Oluşturma

            Console.WriteLine("Barkod no giriniz:");
            kitap.BarkodNo = Console.ReadLine();

            Console.WriteLine("Kitap adı giriniz:");
            kitap.KitapAdi = Console.ReadLine();

            Console.WriteLine("Yazar adı giriniz:");
            kitap.Yazar = Console.ReadLine();

            kitapListesi.Add(kitap);

            Console.WriteLine("Kitap listeye eklendi.");
        }

        public void Kayit2()
        {
            Console.WriteLine("Barkod no giriniz:");
            BarkodNo = Console.ReadLine();

            Console.WriteLine("Kitap adı giriniz:");
            KitapAdi = Console.ReadLine();

            Console.WriteLine("Yazar adı giriniz:");
            Yazar = Console.ReadLine();
        }
    }
}
