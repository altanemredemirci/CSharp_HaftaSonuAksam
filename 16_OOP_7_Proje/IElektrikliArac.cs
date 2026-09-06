using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_7_Proje
{
    internal interface IElektrikliArac
    {
        double BataryaKapasitesi { get; set; }
        double MaksimumMenzil {  get; set; }

        void BataryaDurumGoster();
        double SarjSuresiHesapla();
    }
}
