namespace _21_DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //C# To SQL birbirine bağlayan yapılar vardır. ORM(Object Relation Mapping) araçları: Onlar Entity Framework,Dapper ve ADO.NET'tir. Biz burada Entity Framework kullanacağız.

            //EntityFramework : C# ile SQL entegrasyonunu sağlayan hazır bir kütüphanedir.
            /*
             1-Code First
             2-Database First
             3-Model First
             4-Code First(Varolan database)
             
             Kurulacak Paket:
                * Microsoft.EntityFrameworkCore
                * Microsoft.EntityFrameworkCore.SqlServer
                * Microsoft.EntityFrameworkCore.Tools
                
             Tools => Nuget Package Manager => Package Manager Console
              
             Scaffold-DbContext "Server=DESKTOP-58CMK8T\SQLEXPRESS;Database=NORTHWND; Trusted_Connection=true; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
             */
        }
    }
}
