using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_3
{
    internal class User
    {
        public string FullName;
        public string Username;
        public string Email;
        public string Password;

        public static void Kayit(List<User> liste) //Çağrıldığında User tipinde bir liste parametre olarak gelecek.
        {
            User kullanici = new User();

            Console.WriteLine("Ad Soyad:");
            kullanici.FullName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            kullanici.Username = Console.ReadLine();

            Console.WriteLine("Email:");
            kullanici.Email = Console.ReadLine();

            Console.WriteLine("Şifre:");
            kullanici.Password = Console.ReadLine();

            liste.Add(kullanici);
        } 
    }
}
