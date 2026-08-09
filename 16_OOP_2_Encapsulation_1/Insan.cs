using System;
using System.Collections.Generic;
using System.Text;

namespace _16_OOP_2_Encapsulation_1
{
    //class a herhangi bir erişim belirteci verilmezse internal özelliğini alır.
    public class Insan
    {
        internal string Ad;

        string Soyad; //property e herhangi bir erişim belirteci verilmezse private özelliğini alır.

        public void Yaz()
        {
            Console.WriteLine("Insan sınıfına ait yaz metodu çalıştı.");

            Oku();

            Console.WriteLine(this.Soyad);
        }

        private void Oku() //sadece Insan classı içinde kullanılabilir.
        {
            Console.WriteLine("Insan sınıfına ait Oku metodu çalıştı.");
        }
    }
}
