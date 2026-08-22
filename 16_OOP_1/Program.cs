using _16_OOP_2_Encapsulation_1;

namespace _16_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **** OOP ****
            /*
            OBJECT ORIENTED PROGRAMMING (NESNE YÖNELİMLİ PROGRALAMA) 
            4 Temel prensibe sahiptir.
            * Encapsulation - Kapsülleme
            * Inheritance - Kalıtım
            * Polymorphism - Çok Biçimlilik
            * Abstraction - Soyutlama

            Class üzerinde oluşturulan nesnelerin yönetimi ve ilişkileirni kodlama kurallarına OOP denir.
            C++ ile yazılım dünyasına girmiştir ve OOP ile büyük çaplı projeler yazılabilir hale gelmiştir.
             */

            Insan insan = new Insan();
            //Console.WriteLine(insan.Ad);
            Console.ReadLine();

            insan.Yaz();

            
        }
    }
}
