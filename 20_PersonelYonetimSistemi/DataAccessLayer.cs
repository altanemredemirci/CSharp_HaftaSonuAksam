using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _20_PersonelYonetimSistemi
{
    internal class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        int Sonuc = 0;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-58CMK8T\\SQLEXPRESS; Initial Catalog=PersonelUygulamasi2026; Integrated Security=true; TrustServerCertificate=true;";
        }

        public void BaglantiAyarla()
        {
            if(connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
            {
                connect.Close();
            }
        }

        public int SistemGirisKontrol(SistemKullanici K)
        {
            try
            {
                command = new SqlCommand($"Select * from SistemKullanici where KullaniciAdi='{K.KullaniciAdi}' and Sifre='{K.Sifre}'", connect);

                BaglantiAyarla();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Sonuc = 1;
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                BaglantiAyarla();
            }
            return Sonuc;
        }

        public int PersonelEkle(Personel P)
        {
            try
            {
                command = new SqlCommand($"Insert into Personel (Isim,Soyisim,EmailAdres,Telefon) values ('{P.Isim}','{P.Soyisim}','{P.EmailAdres}','{P.Telefon}')", connect);

                BaglantiAyarla();

                Sonuc = command.ExecuteNonQuery(); //Insert,Update,Delete
            }
            catch (Exception)
            {
                
            }
            finally
            {
                BaglantiAyarla();
            }

            return Sonuc;
        }

        internal SqlDataReader PersonelTumListe()
        {
            try
            {
                command = new SqlCommand("Select * from Personel", connect);

                BaglantiAyarla();

                reader = command.ExecuteReader();
            }
            catch
            {

            }

            return reader;
        }
    }
}
