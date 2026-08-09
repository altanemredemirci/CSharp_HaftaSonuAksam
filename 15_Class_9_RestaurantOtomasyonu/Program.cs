namespace _15_Class_9_RestaurantOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restaurant Otomasyonu
            /*
            Başlangıçta Çorbalar,Salatalar,Makarnalar,Etler,Balıklar,İçecekler diye içlerinde 3'er adet yemek kaydı olan menüler(listeler) tanımlanacaktır.
            Yemek: No,Ad,Fiyat

            Menü: List<Yemek> yemekler, No, Ad

            Masa: No, List<Siparis> siparisler, Dolu(bool)

            Siparis: Masa No, List<Yemek> siparis

            Restaurant bünyesinde 5 adet masa bulunacaktır. Masalarda kişi sınırı yok.
            
            Uygulama çalıştığında ekrana aşağıdaki menü gelecek
                1-Sipariş Al
                2-Hesap Al
                3-Masa Durumu
                4-Z Raporu
                5-Çıkış
                100-Yönetici Girişi

            *** 1-Sipariş Al 
            Her gelen yeni müşteri veya müşteriler ilk boş masaya oturtulacaktır.
            
            Kaç kişi oldukları öğrenildikten sonra sırasıyla müşterilere Menülerden yemek seçmeleri istenilecektir.
            Menüler:
                Çorbalar
                Salatalar
                Makarnalar
                Etler
                Balıklar
                İçecekler
            seçilen menü içerisindeki 3 yemek adı ekrana yazıdrılacak ve seçim yapılması istenilecektir.
            
            seçim sonrası başka bir arzunuz var mı? Evet ise menüler tekrar yazdırılacak
                                                    Hayır ise diğer müşteriye geçilecek


            *** 2-Hesap Al
            Hangi masa olduğu sorulacak ve seçilen masadaki toplam tutar ekrana yazdırılacak.
            Hesap Ödendi Mi? Evet ise masayı boşaltacağız ve Z raporuna tutarı ekleyeceğiz.


            *** 100- Yönetici Girişi
            Menü ekleme
            Menüye yeni yemek ekleme
            Varolan yemeğin fiyatını güncelleme
            Varolan yemeği silme
            Varolan menüyü silme işlemleri yapılacak
            Yeni masa ekleme
            Z raporu(günlük kazanç sıfırlama) alma 
             */
            #endregion
        }
    }
}
