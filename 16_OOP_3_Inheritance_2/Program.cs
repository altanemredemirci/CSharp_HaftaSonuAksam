namespace _16_OOP_3_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Kolej sisteminde ilkokul,Ortaokul ve lise olacaktır.
            //ilkokul:No,Ad,Soyad,Veli Telefon,OkumaYazmaBiliyorMu
            //ortaokul:No,Ad,Soyad,Veli Telefon,Notlar
            //lise:No,Ad,Soyad,Veli Telefon,YKSPuanı

            Ilkokul ilkokul = new Ilkokul();
            ilkokul.No = 1;
            ilkokul.Ad = "Altan Emre";
            ilkokul.Soyad = "Demirci";
            ilkokul.VeliTelefon = "5553332211";
            ilkokul.OkumaYazmaBiliyorMu = true;

            Ortaokul ortaokul = new Ortaokul();
            ortaokul.No = 2;
            ortaokul.Ad = "Sercan";
            ortaokul.Soyad = "Demir";
            ortaokul.VeliTelefon = "22233344455";
            ortaokul.Notlar = 100;

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ilkokul);
            ogrenciler.Add(ortaokul);
        }
    }

    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string VeliTelefon { get; set; }
    }

    class Ilkokul : Ogrenci
    {
        public bool OkumaYazmaBiliyorMu { get; set; }
    }

    class Ortaokul : Ogrenci
    {
        public int Notlar { get; set; }
    }

    class Lise : Ogrenci
    {
        public double YKSPuani { get; set; }
    }
}
