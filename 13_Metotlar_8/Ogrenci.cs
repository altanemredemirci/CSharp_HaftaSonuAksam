using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Metotlar_8
{
    internal class Ogrenci
    {
        private static void Oku()
        {
            Console.WriteLine("Okudum");
        }

        internal static void Yaz() //bir erişim belirteci verilmezse default private alır.
        {
            Oku();
        }

    }
}
