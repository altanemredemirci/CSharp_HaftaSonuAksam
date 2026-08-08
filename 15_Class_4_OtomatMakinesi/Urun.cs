using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_4_OtomatMakinesi
{
    internal class Urun
    {
        public int No;
        public string Ad;
        public double Fiyat;
        public int Stok;

        public static void Listele(List<Urun> uruns)
        {
            foreach (Urun item in uruns)
            {
                Console.WriteLine(item.No+"-"+item.Ad + ":"+item.Fiyat);
            }
        }

        public static void UrunSatis(List<Urun> urunler)
        {
            Console.WriteLine("Ürün Seçiniz:");
            int urunNo = Convert.ToInt32(Console.ReadLine());

            //Where komutu ile her ürünü kontrol et ve urunun numarası ile kullanıcıdan alınan urunNo eşleşen ilk kaydı bana getir
            Urun secilenUrun = urunler.Where(i => i.No == urunNo).FirstOrDefault();

            if (secilenUrun == null) //secilenUrun bulunamazsa
            {
                Console.WriteLine("Hatalı Ürün Numarası");
            }
            else
            {
                double bakiye = 0;
                while (true)
                {
                    Console.WriteLine("Para Girişi:");
                    bakiye += Convert.ToDouble(Console.ReadLine());

                    if (secilenUrun.Fiyat <= bakiye)
                    {
                        Console.WriteLine("Afiyet Olsun. Para Üstü:" + (bakiye - secilenUrun.Fiyat));
                        secilenUrun.Stok--;
                        if (secilenUrun.Stok == 0)
                        {
                            urunler.Remove(secilenUrun);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye!");
                        Console.WriteLine("Para Girişi\t1\nPara İade\t2\nSeçiminiz:");
                        int secim = Convert.ToInt32(Console.ReadLine());

                        if (secim != 1)
                        {
                            Console.WriteLine("Para İade:" + bakiye);
                            break;
                        }                       
                    }
                }
                
            }
        }

        public static void UrunEkle(List<Urun> urunler)
        {
            Urun urun = new Urun();
            Console.WriteLine("Ürün No:");
            urun.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ürün Adı:");
            urun.Ad = Console.ReadLine();

            Console.WriteLine("Ürün Fiyatı:");
            urun.Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stok:");
            urun.Stok = Convert.ToInt32(Console.ReadLine());

            urunler.Add(urun);
        }

        public static void UrunSil(List<Urun> urunler)
        {
            Listele(urunler);

            Console.WriteLine("Silinecek Ürün No:");
            int urunNo = Convert.ToInt32(Console.ReadLine());

            Urun silinecekUrun = urunler.Where(i => i.No == urunNo).FirstOrDefault();

            if (silinecekUrun == null)
            {
                Console.WriteLine("Hatalı Ürün Numarası Girişi!");
            }
            else
            {
                urunler.Remove(silinecekUrun);
                Console.WriteLine("Ürün Başarıyla Silindi.");
            }

        }

        public static void UrunGuncelle(List<Urun> urunler) 
        {
            Listele(urunler);

            Console.WriteLine("Güncelenecek Ürün No:");
            int urunNo = Convert.ToInt32(Console.ReadLine());

            Urun guncellenecekUrun = urunler.Where(i => i.No == urunNo).FirstOrDefault();

            if (guncellenecekUrun == null)
            {
                Console.WriteLine("Hatalı Ürün Numarası Girişi!");
            }
            else
            {
                Console.WriteLine("Ürün Adı:");
                guncellenecekUrun.Ad = Console.ReadLine();

                Console.WriteLine("Ürün Fiyatı:");
                guncellenecekUrun.Fiyat = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ürün Stok:");
                guncellenecekUrun.Stok = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ürün Başarıyla Güncellendi.");
            }
        }
    }
}
