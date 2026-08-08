namespace _15_Class_6_Enum_1
{
    //Enum: Sabit Veri Tipleri

    enum Markalar
    {
        Ford,Renault,BMW,Mercedes,Fiat
    }

    enum Gunler : byte
    {
        Pazartesi=2,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Marka = Markalar.Renault;
            araba.Plaka = "34TK1152";
            araba.Fiyat = 1500000;

            Console.WriteLine(araba.Marka);
            Console.WriteLine(araba.Fiyat);
            Console.WriteLine(araba.Plaka);
        }
    }

    class Araba
    {
        internal Markalar Marka;
        internal double Fiyat;
        internal string Plaka;
    }
}
