using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_2_Encapsulation_2
{
    internal class Ogrenci
    {
        private int Vize { get; set; }
        private int Final { get; set; }

        public int _Vize
        {
            get { return Vize; }
            set
            {
                if(value>=0 && value <= 100)
                {
                    Vize = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Hatalı Not Aralığı!");
                        Console.WriteLine("Vize:");
                        int vize = Convert.ToInt32(Console.ReadLine());
                        if (vize >= 0 && vize <= 100)
                        {
                            Vize = vize;
                            break;
                        }
                    } 
                }
            }
        }
        public int _Final
        {
            get { return Final; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    Final = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Hatalı Not Aralığı!");
                        Console.WriteLine("Final:");
                        int final = Convert.ToInt32(Console.ReadLine());
                        if (final >= 0 && final <= 100)
                        {
                            Final = final;
                            break;
                        }
                    }
                }
            }
        }

        public double Ortalama()
        {
            return Vize * 0.4 + Final * 0.6;
        }
    }
}
