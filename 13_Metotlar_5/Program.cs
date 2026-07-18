namespace _13_Metotlar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metot static ise class adı ile erişilebilir.
            DortIslem.Yaz();


            Random r = new Random();
            r.Next();

            //Metot static değilse classdan bir nesne oluşturarak erişebiliriz.
            DortIslem d = new DortIslem(); //Instance - Örneklem
            d.Yaz2();


        }       
    }

    class DortIslem
    {
        //public: Solution içerisinde her proje erişebilsin
        public static void Yaz()
        {
            Console.WriteLine("Altan Emre Demirci");
        }

        public void Yaz2()
        {
            Console.WriteLine("Altan Emre Demirci");
        }
    }
}
