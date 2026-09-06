namespace _16_OOP_4_Polymorphism_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         POLYMORPHISM NEDİR? 

        Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği anlamına gelir ve statik, dinamik olmak üzere ikiye ayrılır.

            * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
            * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi işlemine verilen isimdir.

        Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.

        Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

        VIRTUAL() METODU

        *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir. Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


        METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

        *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
         *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).

        Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
        metotlar türemiş sınıfta geçersiz kılınabilir.
        Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
        sözcükleri ile tanımlanamaz.

        Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
        Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
        */
            //Aynı isimde farklı parametre sayısı veya parametre veri tipi ile tanımlanarak overload edilen metotlara Statik Polymorphism denir. 

            Toplama(); //Statik Polymorphism

            Ortaokul ortaokul = new Ortaokul();
            ortaokul.Kaydet();


        }

        //Aynı isimle farklı parametre sayısı veya türü ile tanımlanan metotlara overload metot denir. Overload bir nevi statik polymorphismdir.
        static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1+sayi2);
        }

        static void Toplama(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        static void Toplama(double sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        static void Toplama(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine(sayi1 + sayi2 + sayi3);
        }

    }
}
