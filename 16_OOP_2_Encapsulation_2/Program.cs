namespace _16_OOP_2_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir üniversite öğrencisinin vize ve final notlarını alarak ortalamasını hesaplayan kodu yazınız. Ortalam için vize%40, final notunun %60'ı alınır. Not aralığının 0-100 arasında olma durumunu encapsulation ile kontrol ediniz.

            Ogrenci ogrenci = new Ogrenci();
            ogrenci._Vize = 90;
            ogrenci._Final = 56;

            Console.WriteLine("Ortalama:"+ogrenci.Ortalama());
        }
    }
    internal class Vatandas
    {
        public string Ad;
        public string Soyad;
        private string TC; //TC değeri 11 haneli rakamlar dizisi olmalıdır.

        public string _TC
        {
            get { return TC; }
            set
            {
                if (value.Length == 11)
                {
                    if (long.TryParse(value, out _))
                    {
                        TC = value;
                    }
                    else
                    {
                        Console.WriteLine("TC Kimlik Numarası RAKAMLARDAN Oluşmalıdır.");
                    }

                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası Hatalı!");
                }
            }

        }
    }
}
