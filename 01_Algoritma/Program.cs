namespace _01_Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution:Altında projeler barındıran en kapsamlı yazılım alanıdır.
            //Proje:İçerisinde C# kodları ile programalama yapılan yazılım yapısıdır.
            //Proje içerisinde bulunan Program.cs projelerin ana dizinidir ve proje start edildiğinde bu dosya çalıştırılır.

            // Her {} parantez bir kapsam belirler.

            // Bu alanda yazılan herşey C# kodu olmak zorundadır. Eğer bir açıklama yazmak istiyorsak mutlaka yorum(comment) satırı olması gerekir. Yorum satırı olarak girilen yazılar program(Visual Studio) tarafında kontrol edilmez.

            //Tek satır açıklama yazmamızı sağlar.


            /*
                Bu aralığa yazılan her şey yorum 
                    satırı olarak 
                            çalışır.             
             */

            /*
             * Visual Studio : Derleyici(Compiler) 
              Yazılan kodun syntax(yazım kuralı) kontrol eder.
              Bulunduğu makinenin donanımsal olarak bu kodu çalıştırabilirliğini kontrol eder.
              Yazdığımız kodu Makine koduna çevirir.
              Programı çalıştırır.
              Cevap Döndürülür
                    Yukarıdaki yaptığı işlemlere Debug denir.
             
             DOTNET: C# dilinde geliştirilmiş projelerin ortak bir platformda oluşturulmasını ve yayına alınmasını sağlar.

             Bu kurs sonunda .Net Developer olarak mezun olacağız.

             C#: Nesne Yönelimli bir programlama dilidir. Object Oriented Programming(OOP)
             */

            /*
             ******** ALGRORİTMA *******
             Varolan bir problem veya geliştirmeyi sonuca götüren mantıklı ve sıralı çözüm adımlarına denir.

            1-Giriş Çıkış Belirli olmalı
            2-Sonluluk(Bütün olasıklıklar bir sonuca varmalıdır)
            3-Kesinlik(Yazılım her kelime anlaşılır olmalıdır)
            4-Genellenebilirlik(Kod modüler ve genelebilir olmalıdır)
            5-Performans(Zaman ve Maliyet Tasarrufu ve Yüksek verimlilik)
              
            True -> Evet
            False -> Hayır

            ÇAY DEMLEME ALGORİTMASI
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Ocağı Yak
            5-Çaydanlığı Ocağa Koy
            6-Su Kaynadı Mı? T->8 F->7
            7-3 dk Bekle ->6
            8-Demliğe Çay Koy
            9-Çaydanlığa Su Koy
            10-Ocağa Koy
            11-Çay Demlendi Mi? T->13 F->12
            12-3 dk Bekle ->11
            13-Ocağı Kapat
            14-Servis Et
            15-Bitti

            **Su kesik
            **Çay olmama
            **Bakkal kapalı olma

            1-Başla
            2-Mutfağa Git
            3-Su ve Çay Var Mı? T->9 F->4
            4-Bakkala Git
            5-Bakkal Açık Mı? T->7 F->6
            6-Başka Bakkala Git->5
            7-Eksikleri Al
            8-Eve Dön->2 
            9-Çaydanlığa Su Koy
            10-Ocağı Yak
            11-Çaydanlığı Ocağa Koy
            12-Su Kaynadı Mı? T->14 F->13
            13-3 dk Bekle ->12
            14-Demliğe Çay Koy
            15-Çaydanlığa Su Koy
            16-Ocağa Koy
            17-Çay Demlendi Mi? T->19 F->18
            18-3 dk Bekle ->17
            19-Ocağı Kapat
            20-Servis Et
            21-Bitti


            Kullanıcıdan ad ve soyadını ekrana yazdırılması
            1-Başla
            2-Kullanıcıdan Adını Al
            3-Kullanıcıdan Soyadını Al
            4-Ad ve Soyad Ekrana yazdır
            5-Bitti



            **Ekrana Metin Yazma Komutu: Console.WriteLine() 'dır.
            **Ekrana Girilen Metni Okuma Komutu: Console.ReadLine()'dır.
            */

            //Console.WriteLine("Adınız");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınız");
            //string soyad = Console.ReadLine();

            //Console.WriteLine(ad+soyad);

            /*
             EVDEN AKADEMİYE GELME ALGORİTMASI
            1-Başla
            2-Yataktan Kalk
            3-Lavaboya Git
            4-Elini Yüzü Yıka
            5-Yatak Odasına Dön
            6-Hava Durumuna Bak 20 derece üstündeyse->7 Değilse->8 
            7-Yazlık Kıyafetlerini Giy ->9
            8-Kışlık Kıyafetlerini Giy
            9-Kahvaltını Yap

            10-Evden Çık
            11-Kapıyı Kitle
            12-Asansör Mü? Merdiven Mi? A->13 M->20
            13-Asansör Katta Mı? T->15 F->14
            14-Asansörü Çağır ->13
            15-Asansöre Bin
            16-Gidilecek Kat Tuşuna Bas
            17-Asansörden Gidilecek Katta Mı? T->19 F->18
            18-Bekle ->17
            19-Asansörden Çık ->22
            20-Bir Kat Aşağıya İn
            21-Gidilecek Katta Mıyız? T->22 F->20
            
            22-Binadan Çık

            23-Akbil Dolu Mu? T->26 F->24
            24-Dolum İstasyonuna Git
            25-Akbil Doldur
            26-Durağa Git
            27-Toplu Taşıma Geldi Mi? T->29 F->28
            28-Bekle ->27
            29-Toplu Taşımaya Bin
            30-Akbil Bas
            31-Boş Yer Var Mı? T->33 F->32
            32-Ayakta Git ->34
            33-Otur
            34-İnilecek Durağa Geldi Mi? T->36 F->35
            35-Bekle ->34
            36-Toplu Taşımadan İn

            37-Akademiye Yürü
            38-Asansöre Bin
            39-5.Kata Çık
            40-Asansörden İn
            41-Sınıfa Gir
            42-Bitti


             */
            #region Emir
            //EVDEN AKADEMİYE GELME ALGORİTMASI
            //1 - Evden çıkarım
            //2 - Kapıyı kilitlerim
            //4 - Binadan çıkarım
            //5 - otobüs durağına giderim
            //6 - Akademiye en yakın geçen otobüse binerim
            //7 - Otobüste koltuğa otururum
            //8 - Durağa gelince koltuktan kalkarım
            //9 - otobüsten inerim
            //10 - akademiye yürürüm
            //11 - akademinin binasına gelince kapıyı açarım
            //12 - akademi binasına girerim
            #endregion
        }
    }
}

