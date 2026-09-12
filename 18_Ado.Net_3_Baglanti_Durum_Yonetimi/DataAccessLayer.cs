using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Ado.Net_3_Baglanti_Durum_Yonetimi
{
    internal class DataAccessLayer
    {
        SqlConnection connect;

        public DataAccessLayer()  //Constructor Metot
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-58CMK8T\\SQLEXPRESS; Initial Catalog=OkulDB; Integrated Security=true; TrustServerCertificate=true";
        }

        void BaglantiYonetimi() //Default private özellik alır.
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
            else
            {
                connect.Open();
            }
        }

        public void TestBaglanti()
        {
            BaglantiYonetimi();
            Console.WriteLine("Bağlantı Durumu:"+connect.State);

            BaglantiYonetimi();
            Console.WriteLine("Bağlantı Durumu:" + connect.State);

        }
    }
}
