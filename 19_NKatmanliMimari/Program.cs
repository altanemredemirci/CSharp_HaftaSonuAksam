using _19_NKatmanliMimari.BLL;

namespace _19_NKatmanliMimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N KATMANLI MİMARİ
            /*
             UI -> Kullanıcı Arayüzü
             BLL -> İşlem Katmanı
             DAL -> Database Katmanı
             Entity -> Sınıf(Nesne) Katmanı
             */

            BusinessLogicLayer BLL = new BusinessLogicLayer();

            Console.WriteLine("İsim:");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisim:");
            string soyisim = Console.ReadLine();


            int EKS = BLL.VeriKaydet(isim,soyisim);

            if (EKS == -1)
            {
                Console.WriteLine("İsim ve Soyisim boş geçilemez!");
            }
            else if (EKS == 1)
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Bilinmeyen Hata. Sistem yöneticiniz ile iletişime geçiniz");
            }

        }
    }
}
