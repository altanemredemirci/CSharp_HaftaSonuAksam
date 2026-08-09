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

            Insan insan = new Insan();
            Console.WriteLine(insan.Ad);

            Console.WriteLine(insan.);

            insan.Yaz();
        }
    }
}
