using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_7_Proje
{
    internal class Motorsiklet : Arac
    {
        public int MotorHacmi { get; set; }
        public bool YanCantaVarmi { get; set; }

        public Motorsiklet(string marka, string model, int yil, string plaka, double gunlukKiralamaBedeli, int motorHacmi, bool yanCantaVarmi) : base(marka, model, yil,plaka, gunlukKiralamaBedeli)
        {
            MotorHacmi = motorHacmi;
            YanCantaVarmi = yanCantaVarmi;
        }
        public override void AracBilgileriGoster()
        {
            GenelBilgi();
            Console.WriteLine(MotorHacmi);
            Console.WriteLine(YanCantaVarmi);
        }

        public override string AracTipiGetir()
        {
            throw new NotImplementedException();
        }

        public override double KiraUcretHesapla(int gun)
        {
            return GunlukKiralamaBedeli * gun + (YanCantaVarmi==true ? 50 : 0);
        }
    }
}
