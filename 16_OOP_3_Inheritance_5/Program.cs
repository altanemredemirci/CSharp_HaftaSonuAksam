namespace _16_OOP_3_Inheritance_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            List<Ogretmen> ogretmenler = new List<Ogretmen>();

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Kaydet();
            ogrenciler.Add(ogrenci);

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Kaydet();
            ogretmenler.Add(ogretmen);
        }
    }


}
