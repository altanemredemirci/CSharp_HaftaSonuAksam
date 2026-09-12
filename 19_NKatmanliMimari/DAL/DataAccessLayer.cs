using _19_NKatmanliMimari.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19_NKatmanliMimari.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-58CMK8T\\SQLEXPRESS; Initial Catalog=AdoNet; Integrated Security=true; TrustServerCertificate=true;";
        }

        internal void BaglantiAyarla()
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

        internal int VeriKaydet(Musteri M)
        {
            command = new SqlCommand($"Insert into Musteri (Isim,Soyisim) values ('{M.Isim}','{M.Soyisim}')", connect);

            BaglantiAyarla();
            return command.ExecuteNonQuery();
        }
    }
}
