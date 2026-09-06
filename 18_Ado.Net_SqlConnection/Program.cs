using Microsoft.Data.SqlClient;

namespace _18_Ado.Net_1_SqlConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ORM - Object Relation Mapping 
            //ORM araçları yazılım dili ile veritabanın iletişim kurmasını ve birlikte çalışmasını sağlar.
            // C# & SQL
            /*
             *Ado.Net           47ms
             *Dapper            49ms
             *Entity Framework  631ms
             
             */

            //Ado.Net Veritabanı bağlantısı
            SqlConnection connect = new SqlConnection();

            connect.ConnectionString = "Data Source=DESKTOP-58CMK8T\\SQLEXPRESS; Initial Catalog=OkulDB; Integrated Security=true; TrustServerCertificate=true";

            connect.Open();
            Console.WriteLine("Bağlantı Durumu:"+connect.State);

            connect.Close();
            Console.WriteLine("Bağlantı Durumu:" + connect.State);


        }
    }
}
