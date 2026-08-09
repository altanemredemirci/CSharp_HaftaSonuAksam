namespace _15_Class_6_Enum_2
{
    enum Markalar
    {
        Honda,Mazda,BMW,Mercedes,Renault
    }

    enum Vitesler
    {
        Otomatik,Manuel,Yarı_Otomatik
    }

    enum Renkler
    {
        Kırmızı, Beyaz, Siyah, Sarı
    }

    class Otomobil
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public int KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        public Otomobil(Markalar marka,Vitesler vites,Renkler renk,int motorHacmi,int kapiSayisi, string model,bool ceker4, bool parkSensoru)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            MotorHacmi = motorHacmi;
            KapiSayisi = kapiSayisi;
            Model = model;
            Ceker4 = ceker4;
            ParkSensoru = parkSensoru;
        }
        public void OtomobilBilgiYaz()
        {
            Console.WriteLine("Marka:"+Marka);
            Console.WriteLine("Vites:"+Vites);
            Console.WriteLine("Renk:"+Renk);
            Console.WriteLine("Motor Hacmi:"+MotorHacmi);
            Console.WriteLine("Kapı Sayısı:"+KapiSayisi);
            Console.WriteLine("Model:"+Model);
            Console.WriteLine("4 Çeker Mi:"+(Ceker4 ? "Evet":"Hayır"));
            Console.WriteLine("Park Sensörü:"+(ParkSensoru ? "Var":"Yok"));
        }

    }

    class Ticari
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int TasimaKapasitesi;
        public bool Ceker4;
        public int YolcuKapasitesi;

        public Ticari(Markalar marka, Vitesler vites, Renkler renk, int tasimaKapasitesi, bool ceker4, int yolcuKapasitesi)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            TasimaKapasitesi = tasimaKapasitesi;
            Ceker4 = ceker4;
            YolcuKapasitesi = yolcuKapasitesi;
        }
        public void TicariBilgiYaz()
        {
            Console.WriteLine("Marka:" + Marka);
            Console.WriteLine("Vites:" + Vites);
            Console.WriteLine("Renk:" + Renk);
            Console.WriteLine("Taşıma Kapasitesi:" + TasimaKapasitesi);
            Console.WriteLine("4 Çeker Mi:" + (Ceker4 ? "Evet" : "Hayır"));
            Console.WriteLine("Yolcu Kapasitesi:" + YolcuKapasitesi);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORU
            /*
            Aşağıdaki Sınıfları tanımlayınız.
            Otomobil ve Ticari sınıfları var.
            Her sınıfa ait tüm sınıf özelliklerine atama yapan constructor metotlar tanımlanacaktır.
            Main içinde 2 nesne örneklendirilecektir.

            Sabit veri tipleri(enum):
            Marka:
            Honda,Mazda,Ford,Mercedes,Renault,Toyota,Tofaş
            Vites:
            Otomatik,Manuel,Yarı_Otomatik
            Renk:
            Kırmızı,Beyaz,Siyah,Sarı

            SınıfAdı:Otomobil
            ------------------
            Marka,Vites,Renk,MotorHacmi,KapiSayisi,Model,Ceker4(4x4 mü),Park Sensörü

            public void OtomobilBilgiYaz() => Araca ait tüm bilgiler yazıdırılsın


            SınıfAdı:Ticari
            ------------------
            Marka,Vites,Renk,MotorHacmi,TasimaKapasitesi,Ceker4(4x4 mü),YolcuKapasitesi

            public void TicariBilgiYaz() => Araca ait tüm bilgiler yazıdırılsın
             */
            #endregion

            Otomobil otomobil = new Otomobil(Markalar.Renault,Vitesler.Manuel,Renkler.Beyaz,1500,5,"Megane",false,true);

            otomobil.OtomobilBilgiYaz();

            Console.WriteLine("---------------");
            
            Ticari ticari = new Ticari(Markalar.Mazda, Vitesler.Otomatik, Renkler.Siyah, 20000, true, 3);


            ticari.TicariBilgiYaz();
        }
    }
}
