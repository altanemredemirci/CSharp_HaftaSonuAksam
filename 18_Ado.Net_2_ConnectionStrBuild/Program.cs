using Microsoft.Data.SqlClient;

namespace _18_Ado.Net_2_ConnectionStrBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connect = new SqlConnection();
            //connect.ConnectionString = "Data Source=DESKTOP-58CMK8T\\SQLEXPRESS; Initial Catalog=OkulDB; Integrated Security=true; TrustServerCertificate=true";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-58CMK8T\\SQLEXPRESS";
            builder.InitialCatalog = "OkulDB";
            builder.IntegratedSecurity = true;
            builder.TrustServerCertificate = true;

            connect.ConnectionString = builder.ConnectionString;

            connect.Open();
            Console.WriteLine("Bağlantı Durumu:" + connect.State);

            connect.Close();
            Console.WriteLine("Bağlantı Durumu:" + connect.State);
        }
    }
}
