using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_5_Kutuphane
{
    internal class Kutuphane
    {
        internal static List<Kitap> Kitaplar = new List<Kitap>();
        internal static List<Uye> Uyeler = new List<Uye>();

        public static void OduncVer()
        {
            Kitap.Listele(Kitaplar);

            Console.WriteLine("ISBN:");
            string isbn = Console.ReadLine();

            //Kitap odunc = Kitaplar.Where(i => i.ISBN == isbn && i.Durum).FirstOrDefault();

            Kitap odunc = Kitaplar.FirstOrDefault(i => i.ISBN == isbn);

            if (odunc == null)
            {
                Console.WriteLine("Hatlı Kitap Seçimi!");
            }
            else
            {
                if (odunc.Durum == false)
                {
                    Console.WriteLine("Kitap başka bir üye almış.");
                }
                else
                {
                    Console.WriteLine("Üye Numarası:");
                    int no = Convert.ToInt32(Console.ReadLine());

                    Uye uye = Uyeler.FirstOrDefault(i => i.UyeNo == no);

                    if (uye == null)
                    {
                        Console.WriteLine("Kayıtlı Olmayan Üye!!");
                    }
                    else
                    {
                        odunc.Durum = false;
                        uye.AldigiKitaplar.Add(odunc);

                        Console.WriteLine(odunc.Ad+ " kitabı "+uye.AdSoyad+ " isimli üyeye ödünç verildi.");
                    }
                }
            }
        }

        public static void OduncListesi()
        {
            foreach (Kitap kitap in Kitaplar)
            {
                if (!kitap.Durum) //if(kitap.Durum==false)
                {
                    Console.WriteLine("ISBN:" + kitap.ISBN);
                    Console.WriteLine("Kitap Adı:" + kitap.Ad);
                    Console.WriteLine("Yazar Adı:" + kitap.Yazar);
                }
            }
        }
    }
}
