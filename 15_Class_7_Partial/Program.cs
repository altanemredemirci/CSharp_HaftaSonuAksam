internal class Program
{
    static void Main(string[] args)
    {
        Personel personel = new Personel();
        personel.Ad = "Altan";
        personel.CalismaSaati = 45;
    }
}

partial class Personel
{
    public string Ad;
    public string Soyad;
    public int Maas;
}

partial class Personel
{
    public string Departman;
    public int CalismaSaati;
}
