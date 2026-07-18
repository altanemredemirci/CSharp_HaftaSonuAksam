namespace _13_Metotlar_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DATA ACCESS MODIFIER - Erişim Belirteçleri
            /*
             
             Tanımlara erişim özelliği atamak.
             
            public:Solution içerisinde erişilebilir.
            internal:Sadece kendi projesi içerisinde erişilebilir.
            private:Sadece kendi class içerisinde erişilebilir.
            protected:
             */

        #region Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayan metotları yazınız

            Indirim();

            #endregion

        }
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat1 > fiyat2)
            {
                fiyat1 = fiyat1 * 0.7;
            }
            else
            {
                double indirim = fiyat2 * 0.3;
                fiyat2 = fiyat2 - indirim;
            }

            Console.WriteLine("3.ürün ister misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                Indirim3(fiyat1, fiyat2);
            }
            else
            {
                Console.WriteLine("Toplam Ödemeniz:"+(fiyat1+fiyat2));
            }
        }

        static void Indirim3(double fiyat1,double fiyat2)
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double fiyat3 = Convert.ToDouble(Console.ReadLine());

            fiyat3 = fiyat3 / 2;

            Console.WriteLine("Toplam Ödemeniz:" + (fiyat1 + fiyat2+fiyat3));
        }
    }
}
