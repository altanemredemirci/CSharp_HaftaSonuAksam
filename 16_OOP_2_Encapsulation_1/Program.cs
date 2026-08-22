namespace _16_OOP_2_Encapsulation_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DATA ACCESS MODIFIER (Erişim Belirteci):
            /*
             public    : Bütün solution tarafından erişilebilir.
             internal  : Kendi projesi altında erişilebilir.
             private   : Sadece kendi classı altında erişebilir.
             protected : Kendi classı ve miras alınan class tarafından erişilebilir.
             */

            //Insan insan = new Insan();
            //Console.WriteLine(insan.Ad);
            //insan.Soyad = "Demirci";          

            //insan.Yaz();


            Vatandas vatandas = new Vatandas();
            vatandas.Ad = "Altan Emre";
            vatandas.Soyad = "Demirci";

            //Aşağıda set metot çalışır.
            vatandas._TC = "12345678901"; //value

            //Aşağıda get metot çalışır.
            Console.WriteLine(vatandas._TC);

        }
    }
}
