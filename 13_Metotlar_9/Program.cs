namespace _13_Metotlar_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından belirlenen bir aralıkta, belirtilen adet rastgele sayılar ile bir diziyi dolduran metodu yazınız.
            //** aynı sayı eklenmesin

            Diziler.DiziDoldur();

            Diziler diziler = new Diziler();
            diziler.DiziDoldur2();
        }
    }

    class Diziler
    {
        //default olarak private tanımlanır.
        internal static void DiziDoldur()
        {
            //Console.WriteLine("Başlangıç:");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş:");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Adet:");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //int[] sayilar = new int[adet];

            //Random r = new Random();

            //int i = 0;
            //while(i<adet)
            //{
            //    int sayi = r.Next(basla, bitis);

            //    if (!sayilar.Contains(sayi))
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
                
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Adet:"+sayilar.Count());

        }


        //NonStatic
        internal void DiziDoldur2()
        {
            Console.WriteLine("Başlangıç:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş:");
            int bitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adet:");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            Random r = new Random();

            int i = 0;
            while (i < adet)
            {
                int sayi = r.Next(basla, bitis);

                if (!sayilar.Contains(sayi))
                {
                    sayilar[i] = sayi;
                    i++;
                }

            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Adet:" + sayilar.Count());

        }
    }
}
