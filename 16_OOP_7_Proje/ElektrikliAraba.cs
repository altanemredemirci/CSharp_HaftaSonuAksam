using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_7_Proje
{
    internal class ElektrikliAraba : Araba, IElektrikliArac
    {
        public double BataryaKapasitesi { get; set; }
        public double MaksimumMenzil { get; set; }

        public ElektrikliAraba(string marka, string model, int yil, string plaka, double gunlukKiralamaBedeli,double bataryaKapasitesi,double maksimumMenzil,int kapiSayisi, string vitesTipi):base(marka,model,yil,plaka,gunlukKiralamaBedeli,kapiSayisi,vitesTipi)
        {
            BataryaKapasitesi = bataryaKapasitesi;
            MaksimumMenzil = maksimumMenzil;
        }


        public void BataryaDurumGoster()
        {
            throw new NotImplementedException();
        }

        public double SarjSuresiHesapla()
        {
            return BataryaKapasitesi / 10;
        }

        public override double KiraUcretHesapla(int gun)
        {
            return GunlukKiralamaBedeli * gun * 0.95;
        }

        public override void AracBilgileriGoster()
        {
            base.AracBilgileriGoster();
            Console.WriteLine(BataryaKapasitesi);
            Console.WriteLine(MaksimumMenzil);
        }

        public override string AracTipiGetir()
        {
            throw new NotImplementedException();
        }
    }
}
