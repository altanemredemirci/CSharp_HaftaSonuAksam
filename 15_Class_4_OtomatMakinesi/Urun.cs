using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_4_OtomatMakinesi
{
    internal class Urun
    {
        public int No;
        public string Name;
        public double Fiyat;
        public int Stok;

        public static void Listele(List<Urun> uruns)
        {
            foreach (Urun item in uruns)
            {
                Console.WriteLine(item.No+"-"+item.Name+":"+item.Fiyat);
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
                if (secilenUrun.Stok > 0)
                {

                }

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
            urun.Name = Console.ReadLine();

            Console.WriteLine("Ürün Fiyatı:");
            urun.Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stok:");
            urun.Stok = Convert.ToInt32(Console.ReadLine());

            urunler.Add(urun);
        }
    }
}
