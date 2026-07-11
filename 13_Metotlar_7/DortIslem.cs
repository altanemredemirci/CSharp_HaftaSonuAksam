using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Metotlar_7
{
    internal class DortIslem
    {
        public static void Toplama(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 + s2));
        }
        public static void Cikarma(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 - s2));
        }
        public static void Carpma(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 * s2));
        }
        public static void Bolme(int s1, int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 / s2));
        }
    }
}
