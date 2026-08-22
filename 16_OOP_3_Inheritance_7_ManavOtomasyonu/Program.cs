namespace _16_OOP_3_Inheritance_7_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** HAL HOŞGELDİNİZ ***");
            while (true)
            {
                Console.WriteLine("Meyve-1\nSebze-2\nÇıkış-3\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1) 
                {
                    Meyve.Listele(Hal.Meyveler);

                    Meyve.MeyveSatinAl(Hal.Meyveler,Manav.Meyveler);    
                }
                else if (secim == 2)
                {
                    Sebze.Listele(Hal.Sebzeler);

                    Sebze.SebzeSatinAl(Hal.Sebzeler,Manav.Sebzeler);
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Yine bekleriz..");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

                Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "E")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Yine bekleriz..");
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("*** MANAVA HOŞGELDİNİZ ***");
                Console.WriteLine("Meyve-1\nSebze-2\nÇıkış-3\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Meyve.Listele(Manav.Meyveler);

                    Meyve.MeyveSatinAl(Manav.Meyveler, Musteri.Meyveler);

                }
                else if (secim == 2)
                {
                    Sebze.Listele(Manav.Sebzeler);

                    Sebze.SebzeSatinAl(Manav.Sebzeler, Musteri.Sebzeler);
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Yine bekleriz..");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }

                Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap == "E")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Yine bekleriz..");
                    break;
                }
            }

            Meyve.Listele(Musteri.Meyveler);
            Sebze.Listele(Musteri.Sebzeler);
        }
    }
}
