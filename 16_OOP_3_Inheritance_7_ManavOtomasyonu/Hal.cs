using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_3_Inheritance_7_ManavOtomasyonu
{
    internal class Hal
    {
        public static List<Meyve> Meyveler = new List<Meyve>() 
        { 
            new Meyve(){No=1,Ad="Elma",Fiyat=100,Stok=1000},
            new Meyve(){No=2,Ad="Armut",Fiyat=100,Stok=1000},
            new Meyve(){No=3,Ad="Kiraz",Fiyat=100,Stok=1000},
            new Meyve(){No=4,Ad="Çilek",Fiyat=100,Stok=1000},
            new Meyve(){No=5,Ad="Kivi",Fiyat=100,Stok=1000}
        };

        public static List<Sebze> Sebzeler = new List<Sebze>()
        {
            new Sebze(){No=1,Ad="Domates",Fiyat=100,Stok=1000},
            new Sebze(){No=2,Ad="Patates",Fiyat=100,Stok=1000},
            new Sebze(){No=3,Ad="Soğan",Fiyat=100,Stok=1000},
            new Sebze(){No=4,Ad="Biber",Fiyat=100,Stok=1000},
            new Sebze(){No=5,Ad="Patlıcan",Fiyat=100,Stok=1000}
        };

        

       
    }
}
