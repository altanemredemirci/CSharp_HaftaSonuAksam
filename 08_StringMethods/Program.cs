namespace _08_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Length

            //string ad = "Altan Emre Demirci";
            //int uzunluk = ad.Length;

            //Console.WriteLine(uzunluk);

            //Console.WriteLine(ad.Length);
            #endregion

            #region IndexOf
            //string ad = "Altan Emre Demirci";

            //int Index = ad.IndexOf("E");

            //Console.WriteLine("E harfinin ilk bulunduğu index numarasını:"+Index);

            #endregion

            #region LastIndexOf
            //string ad = "Altan Emre Demirci";

            //int Index = ad.LastIndexOf("i");

            //Console.WriteLine("i harfinin ilk bulunduğu index numarasını:" + Index);

            #endregion

            #region StartsWith
            //string ad = "Altan Emre Demirci";

            //bool varMi = ad.StartsWith("al");

            //Console.WriteLine(varMi);


            //Console.WriteLine("Başında TR olacak şekilde Iban bilgisi giriniz:");
            //string iban = Console.ReadLine().ToUpper();

            //if (iban.StartsWith("TR"))
            //{
            //    Console.WriteLine("Başında TR var");
            //}
            //else
            //{
            //    Console.WriteLine("Başında TR olmalıdır");
            //}

            #endregion

            #region EndsWith
            //string ad = "Altan Emre Demirci";

            //bool varMi = ad.EndsWith("rci");

            //Console.WriteLine(varMi);

            #endregion

            #region ToUpper
            //string ad = "Altan Emre Demirci";

            //Console.WriteLine(ad.ToUpper());

            #endregion

            #region ToLower
            //string ad = "Altan Emre Demirci";

            //Console.WriteLine(ad.ToLower());

            #endregion

            #region Replace
            //string ad = "Altan Emre Demirci";

            //Console.WriteLine(ad.Replace("e","a"));

            #endregion

            #region Substring
            //string ad = "Altan Emre Demirci";

            //ad=ad.Substring(2,5);
            //Console.WriteLine(ad);
            #endregion

            Console.WriteLine("Başında TR olacak şekilde Iban bilgisi giriniz:");
            string iban = Console.ReadLine().ToUpper();

            string tr = iban.Substring(0, 2);
            string numara = iban.Substring(2);

            if (tr.StartsWith("TR"))
            {
                if (numara.Length == 12)
                {
                    Console.WriteLine("IBAN doğru girildi");
                }
                
            }
            else
            {
                Console.WriteLine("Başında TR olmalıdır");
            }
        }
    }
}
