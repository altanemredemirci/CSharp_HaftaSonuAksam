namespace _15_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı Kayıt Platformu yapalım
            //Kullanıcı:FullName,Username,Email,Password

            List<User> userList = new List<User>();

            User kullanici = new User();

            Console.WriteLine("Ad Soyad:");
            kullanici.FullName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            kullanici.Username = Console.ReadLine();

            Console.WriteLine("Email:");
            kullanici.Email = Console.ReadLine();

            Console.WriteLine("Şifre:");
            kullanici.Password = Console.ReadLine();

            userList.Add(kullanici);


            User kullanici2 = new User();

            Console.WriteLine("Ad Soyad:");
            kullanici2.FullName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            kullanici2.Username = Console.ReadLine();

            Console.WriteLine("Email:");
            kullanici2.Email = Console.ReadLine();

            Console.WriteLine("Şifre:");
            kullanici2.Password = Console.ReadLine();

            userList.Add(kullanici2);

            foreach (User user in userList)
            {
                Console.WriteLine(user.FullName);
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Password);
            }

        }
    }
}
