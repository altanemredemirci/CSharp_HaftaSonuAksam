using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _20_PersonelYonetimSistemi
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer DAL;
        SqlDataReader reader;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if(!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return DAL.SistemGirisKontrol(new SistemKullanici()
                {
                    KullaniciAdi = kullaniciAdi,
                    Sifre = sifre
                });
            }
            else
            {
                return -100; //Kullanıcı adı ve sifre bilgileri boş gelirse -100 dönsün 
            }
        }

        internal int PersonelEkle(string isim, string soyisim,string email,string telefon)
        {
            if(!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefon))
            {
                Personel P = new Personel();
                P.Isim = isim;
                P.Soyisim = soyisim;
                P.EmailAdres = email;
                P.Telefon = telefon;

                return DAL.PersonelEkle(P);
            }

            else
            {
                return -100;
            }
        }

        internal List<Personel> PersonelTumListe()
        {
            List<Personel> Personellerim = new List<Personel>();

            reader = DAL.PersonelTumListe();

            while (reader.Read())
            {
                Personel P = new Personel();
                P.Id = reader.GetInt32(0);
                P.Isim = reader.GetString(1);
                P.Soyisim = reader.GetString(2);
                P.EmailAdres = reader.GetString(3);
                P.Telefon = reader.GetString(4);

                Personellerim.Add(P);
            }

            reader.Close();
            DAL.BaglantiAyarla();
            return Personellerim;
        }

    }
}
