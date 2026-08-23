namespace _16_OOP_5_Abstract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Telefon: decimal AlisFiyati, decimal KarYuzdesi, decimal LisansUcreti - FiyatHesapla()
            //Buzdolabi: decimal AlisFiyati, decimal KarYuzdesi - FiyatHesapla()

            Telefon telefon = new Telefon();
            telefon.AlisFiyat = 100000;
            telefon.LisansUcreti = 1000;
            telefon.KarYuzdesi = 10;

            Console.WriteLine(telefon.FiyatHesapla());


        }
    }
    abstract class ElektronikEsya
    {
        public decimal AlisFiyat { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();

    }

    class Telefon : ElektronikEsya
    {
        public decimal LisansUcreti { get; set; }
        public override decimal FiyatHesapla()
        {
            return AlisFiyat + (AlisFiyat * KarYuzdesi / 100) + LisansUcreti;
        }
    }

    class Buzdolabi : ElektronikEsya
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyat + (AlisFiyat * KarYuzdesi);
        }
    }
}
