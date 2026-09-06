namespace _16_OOP_5_Abstract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* *** ABSTRACTION - SOYUTLAMAK

             ** Abstract Nedir?
             *Abstract özelliği bir classın base class olarak tanımlanmasını ve Instance(örneklem) alınmamasını sağlar.
             *Abstract tanımlı property miras alınan sınıfta çağrılmak zorundadır.
             * C#'da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir.
             * Abstract tanımlı bir metot sadece abstract tanımlı sınıfta olabilir.
             * Abstract tanımlı sınıflarda abstract metotlar gibi normal tanımlı metotlarda bulunabilir.
             * Ad,Soyad gibi propertylerde abstract olarak tanımlanabilirler.
             */

            IK ik = new IK();
            

            MUH muh = new MUH();

            //Personel sınıfı diğer sınıflara kaynak olması ve ortak özellikleri tutması için yazılan bir sınıftır.
            //Personel personel = new Personel();
                     
        }
    }

    abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }

        abstract public void Kayit();
        abstract public void Guncelle();
        abstract public void Sil();
        abstract public void Listele();

        public void Yazdir()
        {
            Console.WriteLine("Abstract olmayan metot");
        }
    }

    class IK:Personel
    {
        public int PersonelSayisi { get; set; }
        public override string TC { get ; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kayit()
        {
            throw new NotImplementedException();
        }

        public override void Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }

    class IT:Personel
    {
        public int ProgramSayisi { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kayit()
        {
            throw new NotImplementedException();
        }

        public override void Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }

    class MUH:Personel
    {
        public int HesapSayisi { get; set; }

        public override void Guncelle()
        {
            throw new NotImplementedException();
        }

        public override void Kayit()
        {
            throw new NotImplementedException();
        }

        public override void Listele()
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
