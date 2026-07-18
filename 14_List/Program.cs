using System.Collections;

namespace _14_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10]; //Avantajı belirli bir veri tipinde değerler alması.Dezavantajı dizide uzunluk tanımlama zorunluluğu.

            ArrayList arrayList = new ArrayList(); //Avantajı belirli bir uzunluk tanımı olmaması. Dezavantajı ise farklı veri tiplerinde data alması.


            List<string> isimler = new List<string>(); //Avantajı belirli bir uzunluk sınırı olmaması ve tek tip data alması.

            isimler.Add("Altan Emre");
            isimler.Add("Ceylan");
            isimler.Add("Kerem");

            isimler[2] = "Kıvanç"; //2. index değerini değiştirir.

            //Console.WriteLine(isimler[1]);

            foreach (string s in isimler) 
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

        }
    }
}
