using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_2_Encapsulation_1
{
    internal class Vatandas
    {
        public string Ad;
        public string Soyad;
        private string TC; //TC değeri 11 haneli rakamlar dizisi olmalıdır.

        public string _TC
        {
            get { return TC; }
            set
            {
                if (value.Length == 11)
                {
                    if (long.TryParse(value, out _))
                    {
                        TC = value;
                    }
                    else
                    {
                        Console.WriteLine("TC Kimlik Numarası RAKAMLARDAN Oluşmalıdır.");
                    }
                   
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası Hatalı!");
                }
            }

        }
    }
}
