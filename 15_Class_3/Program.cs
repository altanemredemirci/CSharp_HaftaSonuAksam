namespace _15_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<User> userList = new List<User>();

            //User.Kayit(userList);

            //Kitap:BarkodNo,Kitap Adı ve Yazar Adı bilgilerini Kayit metodu ile bir listeye ekleyiniz

            List<Kitap> kitapList = new List<Kitap>();

            //Kitap.Kayit(kitapList);


            Kitap kitap = new Kitap();
            kitap.Kayit2();
            kitapList.Add(kitap);

        }
    }
}
