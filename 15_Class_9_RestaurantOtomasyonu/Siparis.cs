using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_9_RestaurantOtomasyonu
{
    internal class Siparis
    {
        internal int MasaNo;
        internal List<Yemek> Yemekler;

        public Siparis()
        {
            Yemekler = new List<Yemek>();
        }
    }
}
