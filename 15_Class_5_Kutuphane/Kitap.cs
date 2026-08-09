using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_5_Kutuphane
{
    internal class Kitap
    {
        internal string ISBN;
        internal string Ad;
        internal string Yazar;
        internal bool Durum; // true ise Ödünç verilebilir. false ise ödünç verilmiştir.

        internal static void Ekle(List<Kitap> liste)
        {
            Kitap kitap = new Kitap();

            Console.WriteLine("ISBN:");
            kitap.ISBN = Console.ReadLine();

            Console.WriteLine("Kitap Adı:");
            kitap.Ad = Console.ReadLine();

            Console.WriteLine("Yazar Adı:");
            kitap.Yazar = Console.ReadLine();

            kitap.Durum = true;

            liste.Add(kitap);
            Console.WriteLine("Ekleme işlemi başarılı");

        }

        internal static bool Sil(List<Kitap> liste)
        {
            Listele(liste);

            Console.WriteLine("Silinecek Kitap ISBN:");
            string isbn = Console.ReadLine();

            Kitap silinen = liste.Where(i => i.ISBN == isbn).FirstOrDefault();

            if (silinen == null)
            {
                return false;
            }

            liste.Remove(silinen);
            return true;
        }

        internal static void KitapAra(List<Kitap> liste)
        {
            Console.WriteLine("Kitap ISBN:");
            string isbn = Console.ReadLine();

            Kitap kitap = liste.Where(i => i.ISBN == isbn).FirstOrDefault();

            if (kitap != null)
            {
                Console.WriteLine("ISBN:"+kitap.ISBN);
                Console.WriteLine("Kitap Adı:"+kitap.Ad);
                Console.WriteLine("Yazar Adı:"+kitap.Yazar);
                Console.WriteLine("Ödünç:"+ (kitap.Durum ? "Verilebilir" : "Verilmiş"));
            }

            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }
        }



        internal static void Listele(List<Kitap> liste)
        {
            foreach (Kitap kitap in liste)
            {
                Console.WriteLine(kitap.ISBN+"-"+kitap.Ad+":"+kitap.Yazar+" Ödünç "+ (kitap.Durum==true ? "Verilebilir" : "Verildi"));
            }
        }
    }
}
