using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_9_RestaurantOtomasyonu
{
    internal class Masa
    {
        internal int No;
        internal bool Dolu;
        internal double Hesap;

        internal static void MasaDurumu(List<Masa> masalar) 
        {
            foreach (Masa masa in masalar)
            {
                Console.WriteLine(masa.No+" numaralı masa: "+ (masa.Dolu==true ? "Dolu" : "Boş"));
            }
        }

        internal static Masa MasaDoldur(List<Masa> masalar)
        {
            foreach (Masa masa in masalar)
            {
                if (masa.Dolu == false)
                {
                    masa.Dolu = true;
                    return masa;
                }
            }
            return null;
        }
    }


}
