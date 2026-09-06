using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_7_Proje
{
    internal class Araba:Arac
    {
        public int KapiSayisi { get; set; }
        public string VitesTipi { get; set; }

        public Araba(string marka,string model,int yil,string plaka,double gunlukKiralamaBedeli,int kapiSayisi,string vitesTipi):base(marka,model,yil,plaka,gunlukKiralamaBedeli)
        {
            KapiSayisi = kapiSayisi;
            VitesTipi = vitesTipi;
        }

        public override double KiraUcretHesapla(int gun)
        {
            return GunlukKiralamaBedeli * gun * 1.10;
        }

        public override void AracBilgileriGoster()
        {
            GenelBilgi();
            Console.WriteLine(KapiSayisi);
            Console.WriteLine(VitesTipi);
        }

        public override string AracTipiGetir()
        {
            throw new NotImplementedException();
        }
    }
}
