namespace _15_Class_4_OtomatMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Urun> urunler = new List<Urun>();
            #region Urun Doldurma
            Urun urun1 = new Urun();
            urun1.No = 1;
            urun1.Stok = 3;
            urun1.Ad = "Kola";
            urun1.Fiyat = 50;

            urunler.Add(urun1);

            Urun urun2 = new Urun();
            urun2.No = 2;
            urun2.Stok = 10;
            urun2.Ad = "Fanta";
            urun2.Fiyat = 50;

            urunler.Add(urun2);

            Urun urun3 = new Urun();
            urun3.No = 3;
            urun3.Stok = 10;
            urun3.Ad = "Ayran";
            urun3.Fiyat = 40;

            urunler.Add(urun3);
            #endregion


            while (true)
            {
                Console.WriteLine("***** OTOMAT MAKİNESİ *****");

                Console.WriteLine("Yönetici 1\nMüşteri\t2");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 2)
                {
                    Urun.Listele(urunler);

                    Urun.UrunSatis(urunler);
                }
                else if (secim == 1)
                {
                    Console.WriteLine("Ürün Ekle\t1\nÜrün Sil\t2\nÜrün Güncelle\t3\nÜrün Listele\t4\nSeçiminiz:");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1) 
                    {
                        Urun.UrunEkle(urunler);
                    }
                    else if (islem == 2) 
                    {
                        Urun.UrunSil(urunler);
                    }
                    else if (islem == 3) 
                    {
                        Urun.UrunGuncelle(urunler);
                    }
                    else if (islem == 4) 
                    {
                        Urun.Listele(urunler);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem Seçimi!");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }

        }
    }
}
