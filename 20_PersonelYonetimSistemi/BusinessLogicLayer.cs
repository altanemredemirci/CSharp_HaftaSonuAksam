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
            DAL = new DataAccessLayer(); //DataAccessLayer sınıfından bir nesne türettik(constructor metot çalıştı) ve DAL değişkenine atadık
        }

        internal int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {

                SistemKullanici sistem = new SistemKullanici();

                sistem.KullaniciAdi = kullaniciAdi;
                sistem.Sifre = sifre;

                return DAL.SistemGirisKontrol(sistem);
            }
            else
            {
                return -100; //Kullanıcı adı ve sifre bilgileri boş gelirse -100 dönsün 
            }
        }

        internal int PersonelEkle(string isim, string soyisim, string email, string telefon)
        {
            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefon))
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

        internal Personel PersonelKayitGetir(int Id)
        {
            Personel personel = new Personel();

            try
            {
                reader = DAL.PersonelKayitGetir(Id);

                while (reader.Read())
                {
                    personel.Id = reader.GetInt32(0);
                    personel.Isim = reader.GetString(1);
                    personel.Soyisim = reader.GetString(2);
                    personel.EmailAdres = reader.GetString(3);
                    personel.Telefon = reader.GetString(4);
                }

                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DAL.BaglantiAyarla();
            }

            return personel;
        }

        public int PersonelKayitGuncelle(int Id,string Isim,string Soyisim,string Email,string Telefon)
        {
            Personel P = new Personel()
            {
                Id = Id,
                Isim = Isim,
                Soyisim = Soyisim,
                EmailAdres = Email,
                Telefon = Telefon
            };

            return DAL.PersonelKayitGuncelle(P);
        }

        public int PersonelSil(int Id)
        {
            return DAL.PersonelSil(Id);
        }
    }
}
