namespace _16_OOP_5_Abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ETicaret Sitesi:
            //Urun: Kayit,Guncelle,Sil,Listele,Detay --Sercan
            //Kategori: Kayit,Guncelle,Sil,Listele,Detay --Ayşe
            //Marka: Kayit,Guncelle,Sil,Listele,Detay --Emir
            //Kullanıcı: Kayit,Guncelle,Sil,Listele,Detay --Selim
            //Sepet: Kayit,Guncelle,Sil,Listele,Detay --Emirhan
            //Siparis: Kayit,Guncelle,Sil,Listele,Detay --Burcu
        }
    }

    abstract class Temel
    {
        abstract public void Kayit();
        abstract public void Guncelle();
        abstract public void Sil();
        abstract public void Listele();
        abstract public void Detay();
    }

    class Urun : Temel
    {
        public override void Detay()
        {
            Console.WriteLine();
        }

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

    class Kategori : Temel
    {
        public override void Detay()
        {
            throw new NotImplementedException();
        }

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

    class Marka : Temel
    {
        public override void Detay()
        {
            throw new NotImplementedException();
        }

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
