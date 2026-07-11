using System.Collections;

namespace _12_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ﻿﻿******** MANAV OTOMASYONU *********
 1.Toptancı,Manav ve Müşteri alanlarımız olacak
 2.Manav toptancıdan isteğine göre meyve,sebze alacak ve müşteri de manavın toptancıdan aldığı ürünleri alabilecek.
 3.Toptancı için meyve ve sebze programın başında tanımlanacak.(Dolu liste yapılacak)
 4.Manav için meyve sebze listeleri boş olarak tanımlanacak
 5.Müşteri için tek liste yeterli boş olarak
 6.Program başladığında HALE HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
 7.M tuşuna basıldıysa Toptancının meyve listesi S tuşuna basıldıysa Toptancının sebze listesi ekrana yazdırıp manavın bir ürün alması istenecek
 8.Mesela Elma istediyse manavın meyveler listesine elma değeri eklenecek ve kaç kilo diye sorularak kilo alınacak
 9.Başka bir arzunu var mı? Evet E veya Hayır H
 10.Evet dendiyse Tekrar 6. adıma gidilecek ve işlemler tekrar edilecek
 11.Hayır dendiyse MANAVA HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.
 12.Manav Bölümünde müşteri M bastı diyelim 
 13.Manavın toptancıdan aldığı meyveler listelenecek ve müşterinin bir meyve girmesi beklenecek
 14.Mesela Elma istediyse kaç kilo diye sorularak kilo alınacak
 15.Müşterinin istediği kilo ile manavın toptancıdan aldığı elmanın kilosu karşılaştırılacak 
 16.Eğer manavın elinde yeterli miktarda elma varsa müşterinin listesine elma değeri eklenecek
 17.Başka bir arzunu var mı? Evet E veya Hayır H
 18.Evet dendiyse Tekrar 11. adıma gidilecek ve işlemler tekrar edilecek
 19.Hayır dendiyse Müşteri listesi ekrana yazdırılsın.
             */

            #region AYŞE
            //ArrayList toptanciMeyve = new ArrayList() { "Elma", "Armut", "Muz" };
            //ArrayList toptanciMeyveKg = new ArrayList() { 50, 40, 20 };
            //ArrayList toptanciSebze = new ArrayList() { "Domates", "Salatalık", "Biber" };
            //ArrayList toptanciSebzeKg = new ArrayList() { 60, 45, 35 };

            //ArrayList manavUrun = new ArrayList();
            //ArrayList manavKg = new ArrayList();
            //ArrayList musteriUrun = new ArrayList();
            //ArrayList musteriKg = new ArrayList();



            //while (true)
            //{
            //    Console.WriteLine("TOPTANCIYA HOŞGELDİNİZ!!!");
            //    Console.WriteLine("Meyve için M sebze için S");
            //    string manavAlis = Console.ReadLine().ToUpper();

            //    if (manavAlis == "M")
            //    {

            //        Console.WriteLine("Toptanci Meyve Listesi:");

            //        for (int i = 0; i < toptanciMeyve.Count; i++)
            //        {

            //            Console.WriteLine(toptanciMeyve[i] + " - " + toptanciMeyveKg[i] + " kg");

            //        }


            //        Console.WriteLine("Almak istediğiniz meyvenin adını giriniz.");
            //        string manavIstek = Console.ReadLine();
            //        int index = toptanciMeyve.IndexOf(manavIstek);

            //        if (toptanciMeyve.Contains(manavIstek))
            //        {
            //            Console.WriteLine("Kaç kilo " + manavIstek + " almak istersiniz?");
            //            int manavIstekKg = Convert.ToInt32(Console.ReadLine());
            //            int mevcutKg = Convert.ToInt32(toptanciMeyveKg[index]);

            //            if (manavIstekKg <= mevcutKg)
            //            {
            //                manavUrun.Add(manavIstek);
            //                manavKg.Add(manavIstekKg);

            //                toptanciMeyveKg[index] = mevcutKg - manavIstekKg;

            //                Console.WriteLine("Ürün manav listesine eklendi. ");

            //            }
            //            else
            //            {
            //                Console.WriteLine("Toptancıda yeterli kilo yok. ");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine("Bu meyve toptancıda yok. ");
            //        }
            //    }

            //    else if (manavAlis == "S")
            //    {

            //        Console.WriteLine("Toptancı Sebze Listesi: ");

            //        for (int i = 0; i < toptanciSebze.Count; i++)
            //        {
            //            Console.WriteLine(toptanciSebze[i] + " - " + toptanciSebzeKg[i] + " kg");
            //        }


            //        Console.WriteLine("Almak istediğiniz sebzenin adını giriniz.");
            //        string manavIstek2 = Console.ReadLine();
            //        int index = toptanciSebze.IndexOf(manavIstek2);

            //        if (toptanciSebze.Contains(manavIstek2))
            //        {
            //            Console.WriteLine("Kaç kilo" + manavIstek2 + " almak istersiniz? ");
            //            int manavIstekKg2 = Convert.ToInt32(Console.ReadLine());
            //            int mevcutKg2 = Convert.ToInt32(toptanciSebzeKg[index]);

            //            if (manavIstekKg2 <= mevcutKg2)
            //            {
            //                manavUrun.Add(manavIstek2);
            //                manavKg.Add(manavIstekKg2);

            //                toptanciSebzeKg[index] = mevcutKg2 - manavIstekKg2;

            //                Console.WriteLine("Ürün manav listesine eklendi.");

            //            }
            //            else
            //            {
            //                Console.WriteLine("Toptancıda yeterli kilo yok. ");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine("Bu sebze toptancıda yok.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı seçim yaptınız. ");
            //    }

            //    Console.WriteLine("Başka bir arzunuz var mı? E/H");
            //    string arzu = Console.ReadLine().ToUpper().ToUpper();

            //    if (arzu == "E")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}

            //Console.WriteLine("MANAVA HOŞGELDİNİZ!!!");

            //if (manavUrun.Count == 0)
            //{
            //    Console.WriteLine("Manavda ürün yok. Müşteri alışverişi yapılamaz. ");
            //}
            //else
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Manav Ürün Listesi: ");

            //        for (int i = 0; i < manavUrun.Count; i++)
            //        {
            //            Console.WriteLine(manavUrun[i] + " - " + manavKg[i] + " kg");
            //        }



            //        Console.WriteLine("Almak istediğiniz ürünün adını giriniz.");
            //        string musteriAlis = Console.ReadLine();
            //        int index = manavUrun.IndexOf(musteriAlis);


            //        if (manavUrun.Contains(musteriAlis))
            //        {
            //            Console.WriteLine("Kaç Kilo" + musteriAlis + " almak istersiniz? ");
            //            int musteriAlisKg = Convert.ToInt32(Console.ReadLine());
            //            int mevcutManavKg = Convert.ToInt32(manavKg[index]);

            //            if (musteriAlisKg <= mevcutManavKg)
            //            {
            //                musteriUrun.Add(musteriAlis);
            //                musteriKg.Add(musteriAlisKg);

            //                manavKg[index] = mevcutManavKg - musteriAlisKg;
            //                Console.WriteLine("Sepetinize Ürün Eklendi");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Manavda yeterli kilo yok.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bu ürün manavda yok.");
            //        }
            //        Console.WriteLine("Başka bir arzunuz var mı? E/H ");
            //        string secim = Console.ReadLine().ToUpper();

            //        if (secim == "E")
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }

            //    }
            //    Console.WriteLine("Ürün Listeniz:");

            //    for (int i = 0; i < musteriUrun.Count; i++)
            //    {
            //        Console.WriteLine(musteriUrun[i] + " - " + musteriKg[i] + " kg");
            //    }

            //}
            #endregion

            #region ARDA

            //ArrayList meyve = new ArrayList() { "Elma", "Armut", "Muz" };
            //ArrayList meyveKg = new ArrayList() { 50, 40, 30 };


            //ArrayList sebze = new ArrayList() { "Domates", "Salatalık", "Biber" };
            //ArrayList sebzeKg = new ArrayList() { 60, 45, 35 };


            //ArrayList manavUrun = new ArrayList();
            //ArrayList manavKg = new ArrayList();


            //ArrayList musteriUrun = new ArrayList();
            //ArrayList musteriKg = new ArrayList();

            //string cevap = "E";


            //while (cevap == "E")
            //{
            //    Console.WriteLine("Meyve=M Sebze=S");
            //    string secim = Console.ReadLine().ToUpper();

            //    if (secim == "M")
            //    {
            //        for (int i = 0; i < meyve.Count; i++)
            //        {
            //            Console.WriteLine(meyve[i] + " - " + meyveKg[i] + " Kg");
            //        }

            //        Console.Write("Meyve adı:");
            //        string ad = Console.ReadLine();

            //        int index = meyve.IndexOf(ad);

            //        if (index == -1)
            //        {
            //            Console.WriteLine("Bu meyve toptancıda yok.");
            //        }
            //        else
            //        {
            //            Console.Write("Kaç kilo:");
            //            int kilo = Convert.ToInt32(Console.ReadLine());

            //            if (kilo <= (int)meyveKg[index])
            //            {
            //                manavUrun.Add(ad);
            //                manavKg.Add(kilo);

            //                meyveKg[index] = (int)meyveKg[index] - kilo;

            //                Console.WriteLine("Manava eklendi.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Toptancıda yeterli kilo yok.");
            //            }
            //        }
            //    }
            //    else if (secim == "S")
            //    {
            //        for (int i = 0; i < sebze.Count; i++)
            //        {
            //            Console.WriteLine(sebze[i] + " - " + sebzeKg[i] + " Kg");
            //        }

            //        Console.Write("Sebze adı:");
            //        string ad = Console.ReadLine();

            //        int index = sebze.IndexOf(ad);

            //        if (index == -1)
            //        {
            //            Console.WriteLine("Bu sebze toptancıda yok.");
            //        }
            //        else
            //        {
            //            Console.Write("Kaç kilo:");
            //            int kilo = Convert.ToInt32(Console.ReadLine());

            //            if (kilo <= (int)sebzeKg[index])
            //            {
            //                manavUrun.Add(ad);
            //                manavKg.Add(kilo);

            //                sebzeKg[index] = (int)sebzeKg[index] - kilo;

            //                Console.WriteLine("Manava eklendi.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Toptancıda yeterli kilo yok.");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı seçim.");
            //    }

            //    Console.Write("Başka arzunuz var mı? E/H : ");
            //    cevap = Console.ReadLine().ToUpper();
            //}


            //cevap = "E";

            //while (cevap == "E")
            //{
            //    Console.WriteLine("\nManav Ürünleri");

            //    for (int i = 0; i < manavUrun.Count; i++)
            //    {
            //        Console.WriteLine(manavUrun[i] + " - " + manavKg[i] + " Kg");
            //    }

            //    Console.Write("Ürün adı:");
            //    string ad = Console.ReadLine();

            //    int index = manavUrun.IndexOf(ad);

            //    if (index == -1)
            //    {
            //        Console.WriteLine("Bu ürün manavda yok.");
            //    }
            //    else
            //    {
            //        Console.Write("Kaç kilo:");
            //        int kilo = Convert.ToInt32(Console.ReadLine());

            //        if (kilo <= (int)manavKg[index])
            //        {
            //            musteriUrun.Add(ad);
            //            musteriKg.Add(kilo);

            //            manavKg[index] = (int)manavKg[index] - kilo;

            //            Console.WriteLine("Satış yapıldı.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Manavda yeterli kilo yok.");
            //        }
            //    }

            //    Console.Write("Başka arzunuz var mı? E/H : ");
            //    cevap = Console.ReadLine().ToUpper();
            //}



            //Console.WriteLine("\nMüşteri Ürünleri");

            //for (int i = 0; i < musteriUrun.Count; i++)
            //{
            //    Console.WriteLine(musteriUrun[i] + " - " + musteriKg[i] + " Kg");
            //}

            //Console.ReadKey();

            #endregion

            #region EMİRHAN

            //List<string> toptancimeyve = new List<string>() { "Elma", "Uzum", "Muz", "Cilek", "Ayva" };
            //List<double> toptancimeyvekilo = new List<double>() { 50, 40, 35, 60, 40 };
            //List<string> toptancisebze = new List<string>() { "Patlican", "Biber", "Kabak", "Salatalik", "Sogan", "Brokoli" };
            //List<double> toptancisebzekilo = new List<double>() { 40, 45, 40, 50, 40, 35 };
            //List<string> manavurun = new List<string>();
            //List<double> manavurunkilo = new List<double>();
            //List<string> musteriurun = new List<string>();
            //List<double> musteriurunkilo = new List<double>();
            //Console.WriteLine("Meyve icin -M- sebze icin -S- tusuna basiniz ");
            //while (true)
            //{
            //    char secim = Convert.ToChar(Console.ReadLine());
            //    if (char.ToUpper(secim) == 'M')
            //    {
            //        for (int i = 0; i < toptancimeyve.Count; i++)
            //        {
            //            Console.WriteLine(toptancimeyve[i]);
            //        }
            //        Console.WriteLine("Hangi meyveden istiyorsunuz? ");
            //        while (true)
            //        {
            //            string input = Console.ReadLine();
            //            if (toptancimeyve.Contains(input))
            //            {
            //                Console.WriteLine("Kac kilo " + input + " ıstıyorsunuz? ");
            //                while (true)
            //                {
            //                    double istek = Convert.ToDouble(Console.ReadLine());
            //                    double mevcutkilomeyve = 0;
            //                    for (int a = 0; a < toptancimeyve.Count; a++)
            //                    {
            //                        if (toptancimeyve[a] == input)
            //                        {
            //                            mevcutkilomeyve = toptancimeyvekilo[a];
            //                            break;
            //                        }
            //                    }
            //                    if (istek <= mevcutkilomeyve)
            //                    {
            //                        manavurun.Add(input);
            //                        manavurunkilo.Add(istek);
            //                        double kalan = mevcutkilomeyve - istek;
            //                        for (int a = 0; a < toptancimeyve.Count; a++)
            //                        {
            //                            if (toptancimeyve[a] == input)
            //                            {
            //                                toptancimeyvekilo[a] = kalan;
            //                                break;
            //                            }
            //                        }
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Toptancida istediginiz kiloda " + input + " bulunmuyor,daha dusuk bir deger giriniz ");
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Istediginiz meyve toptancida bulunmuyor,lutfen baska bir meyve giriniz");
            //            }
            //            if (manavurun.Contains(input))
            //            {
            //                goto Sonkontrol;
            //            }
            //        }
            //    }
            //    else if (char.ToUpper(secim) == 'S')
            //    {
            //        for (int i = 0; i < toptancisebze.Count; i++)
            //        {
            //            Console.WriteLine(toptancisebze[i]);
            //        }
            //        Console.WriteLine("Hangi sebzeden istiyorsunuz? ");
            //        while (true)
            //        {
            //            string inputsebze = Console.ReadLine();
            //            if (toptancisebze.Contains(inputsebze))
            //            {
            //                Console.WriteLine("Kac kilo " + inputsebze + " ıstıyorsunuz? ");
            //                while (true)
            //                {
            //                    double isteksebze = Convert.ToDouble(Console.ReadLine());
            //                    double mevcutkilosebze = 0;
            //                    for (int a = 0; a < toptancimeyve.Count; a++)
            //                    {
            //                        if (toptancisebze[a] == inputsebze)
            //                        {
            //                            mevcutkilosebze = toptancisebzekilo[a];
            //                            break;
            //                        }
            //                    }
            //                    if (isteksebze <= mevcutkilosebze)
            //                    {
            //                        manavurun.Add(inputsebze);
            //                        manavurunkilo.Add(isteksebze);
            //                        double kalansebze = mevcutkilosebze - isteksebze;
            //                        for (int a = 0; a < toptancimeyve.Count; a++)
            //                        {
            //                            if (toptancisebze[a] == inputsebze)
            //                            {
            //                                toptancisebzekilo[a] = kalansebze;
            //                                break;
            //                            }
            //                        }
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Toptancida istediginiz kiloda " + inputsebze + " bulunmuyor,daha dusuk bir deger giriniz ");
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Istediginiz sebze toptancida bulunmuyor,lutfen baska bir meyve giriniz");
            //            }
            //            if (manavurun.Contains(inputsebze))
            //            {
            //                goto Sonkontrol;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gecersiz secim yaptınız.Lutfen -M- ya da -S- harfini tuşlayınız");
            //        continue;
            //    }
            //Sonkontrol:
            //    Console.WriteLine("Baska bir isteginiz var mi? Evet icin  -E- hayır icin -H- tusuna basiniz ");
            //Evethayir:
            //    char onay = Convert.ToChar(Console.ReadLine());
            //    if (char.ToUpper(onay) == 'E')
            //    {
            //        Console.WriteLine("Hangi urunu istersiniz? ");
            //    }
            //    else if (char.ToUpper(onay) == 'H')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gecersiz harf, lutfen E veya H tusuna basiniz");
            //        goto Evethayir;
            //    }
            //}
            //while (true)
            //{
            //    for (int i = 0; i < manavurun.Count; i++)
            //    {
            //        Console.WriteLine(manavurun[i]);
            //        for (int j = 0; j < manavurunkilo.Count; j++)
            //        {
            //            if (j == i)
            //            {
            //                Console.WriteLine(manavurunkilo[j]);
            //            }
            //        }
            //    }
            //musterisoru:
            //    Console.WriteLine("Hosgeldiniz ne istersiniz? ");

            //    string musteriistek = Console.ReadLine();
            //    if (manavurun.Contains(musteriistek))
            //    {
            //        double kalanmanavkilo = 0;
            //        double mevcutmanavkilo = 0;
            //        for (int a = 0; a < manavurun.Count; a++)
            //        {
            //            if (manavurun[a] == musteriistek)
            //            {
            //                mevcutmanavkilo = manavurunkilo[a];
            //            }
            //        }
            //        Console.WriteLine("Kac kilo " + musteriistek + " istiyorsunuz? ");
            //        while (true)
            //        {
            //            double istenenkilo = Convert.ToDouble(Console.ReadLine());

            //            if (istenenkilo <= mevcutmanavkilo)
            //            {
            //                musteriurun.Add(musteriistek);
            //                musteriurunkilo.Add(istenenkilo);
            //                kalanmanavkilo = mevcutmanavkilo - istenenkilo;
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bu urunden istediginiz kiloda mevcut degil daha dusuk bir deger giriniz ");
            //            }
            //        }
            //        Console.WriteLine("Baska bisey ister misiniz? Evet icin -E- hayır icin -H- tusuna basiniz ");
            //        while (true)
            //        {
            //            char evetmihayirmi = Convert.ToChar(Console.ReadLine());
            //            if (char.ToUpper(evetmihayirmi) == 'E')
            //            {
            //                Console.WriteLine("Baska ne istersiniz");
            //                goto musterisoru;
            //            }
            //            else if (char.ToUpper(evetmihayirmi) == 'H')
            //            {
            //                goto Bitis;
            //            }
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Bu urun manavda mevcut degil,baska bir urun giriniz ");
            //        goto musterisoru;
            //    }
            //Bitis:
            //    for (int x = 0; x < musteriurun.Count; x++)
            //    {
            //        Console.WriteLine(musteriurun[x]);
            //        for (int y = 0; y < musteriurunkilo.Count; y++)
            //        {
            //            if (y == x)
            //            {
            //                Console.WriteLine(musteriurunkilo[y] + "kilo");
            //            }
            //        }
            //    }
            //    break;
            //}

            #endregion



            ArrayList halMeyve = new ArrayList() { "Elma", "Armut", "Muz", "Kiraz" };
            ArrayList halSebze = new ArrayList() { "Domates", "Biber", "Patates", "Patlıcan" };

            ArrayList manavMeyve = new ArrayList();
            ArrayList manavSebze = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            
            ArrayList musteri = new ArrayList();

            //HALE KISMI
            while (true)
            {
                Console.WriteLine("******** HALE HOŞGELDİNİZ ********");
                Console.WriteLine("Meyve için M / Sebze için S / Çıkış için Q");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M") 
                {
                    for (int i = 0; i < halMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i}-{halMeyve[i]}");
                    }
                    Console.WriteLine("Seçiminiz:");
                    int index = Convert.ToInt32(Console.ReadLine());

                    if(index<0 || index >= halMeyve.Count)
                    {
                        Console.WriteLine("Hatalı Meyve Seçimi!!");
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (manavMeyve.Contains(halMeyve[index]))
                        {
                            int meyveIndex = manavMeyve.IndexOf(halMeyve[index]);

                            int eskikilo =(int) manavMeyveKilo[meyveIndex];
                            manavMeyveKilo[meyveIndex] = eskikilo + kilo;
                        }
                        else
                        {
                            manavMeyve.Add(halMeyve[index]);
                            manavMeyveKilo.Add(kilo);
                        }

                        Console.WriteLine("Başka Bir Arzunuz Var Mı?E/H");
                        string cevap = Console.ReadLine().ToUpper();

                        if (cevap == "E")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                else if (secim == "S") 
                {
                    for (int i = 0; i < halSebze.Count; i++)
                    {
                        Console.WriteLine($"{i}-{halSebze[i]}");
                    }
                    Console.WriteLine("Seçiminiz:");
                    int index = Convert.ToInt32(Console.ReadLine());

                    if (index < 0 || index >= halSebze.Count)
                    {
                        Console.WriteLine("Hatalı Sebze Seçimi!!");
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (manavSebze.Contains(halSebze[index]))
                        {
                            int sebzeIndex = manavSebze.IndexOf(halSebze[index]);

                            int eskikilo = (int)manavSebzeKilo[sebzeIndex];
                            manavSebzeKilo[sebzeIndex] = eskikilo + kilo;
                        }
                        else
                        {
                            manavSebze.Add(halSebze[index]);
                            manavSebzeKilo.Add(kilo);
                        }

                        Console.WriteLine("Başka Bir Arzunuz Var Mı?E/H");
                        string cevap = Console.ReadLine().ToUpper();

                        if (cevap == "E")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }
          
            //MANAV KISMI
            while (true)
            {
                Console.WriteLine("******** MANAVA HOŞGELDİNİZ ********");
                Console.WriteLine("Meyve için M / Sebze için S");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M") 
                {
                    for (int i = 0; i < manavMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavMeyve[i]}");
                    }
                    Console.WriteLine("Seçiminiz:");
                    int index = Convert.ToInt32(Console.ReadLine());

                    if(index<0 || index >= manavMeyve.Count)
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        int mevcutKilo = (int)manavMeyveKilo[index];

                        if (kilo <= mevcutKilo)
                        {
                            musteri.Add(manavMeyve[index]);

                            mevcutKilo -= kilo;
                            if (mevcutKilo == 0)
                            {
                                manavMeyve.RemoveAt(index);
                                manavMeyveKilo.RemoveAt(index);
                            }
                            else
                            {
                                manavMeyveKilo[index] = mevcutKilo;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Elimizde {mevcutKilo} kilo {manavMeyve[index]} var.");
                        }

                        Console.WriteLine("Başka Bir Arzunuz Var Mı?E/H");
                        string cevap = Console.ReadLine().ToUpper();

                        if (cevap == "E")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                else if (secim == "S") 
                {
                    for (int i = 0; i < manavSebze.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavSebze[i]}");
                    }
                    Console.WriteLine("Seçiminiz:");
                    int index = Convert.ToInt32(Console.ReadLine());

                    if (index < 0 || index >= manavSebze.Count)
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }
                    else
                    {
                        Console.WriteLine("Kaç Kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        int mevcutKilo = (int)manavSebzeKilo[index];

                        if (kilo <= mevcutKilo)
                        {
                            mevcutKilo -= kilo;
                            if (mevcutKilo == 0)
                            {
                                manavSebze.RemoveAt(index);
                                manavSebzeKilo.RemoveAt(index);
                            }
                            else
                            {
                                manavSebzeKilo[index] = mevcutKilo;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Elimizde {mevcutKilo} kilo {manavSebze[index]} var.");
                        }

                        Console.WriteLine("Başka Bir Arzunuz Var Mı?E/H");
                        string cevap = Console.ReadLine().ToUpper();

                        if (cevap == "E")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı Seçim!!");
                }

            }

            //MÜŞTERİ KISMI
            foreach (string item in musteri)
            {
                Console.WriteLine(item);
            }
        }
    }
}
