using _21_DatabaseFirst.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace _21_DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //C# To SQL birbirine bağlayan yapılar vardır. ORM(Object Relation Mapping) araçları: Onlar Entity Framework,Dapper ve ADO.NET'tir. Biz burada Entity Framework kullanacağız.

            /*
             Ado.Net 44ms
             Dapper 46ms
             EntityFramework 688ms
             
             */

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

             Projeye eklenen Entities klasörü altında database ait tablolar class olrak oluşturuldu. Bu klasör altında database bağlantısı tanımladığımız NorthwindContext isminde bir class bulunur.
             */
        }

        NorthwindContext db = new NorthwindContext(); //Database bağlantısını çektim.
        private void btn_getData_Click(object sender, EventArgs e)
        {
            #region ADO.NET
            //SqlConnection connect = new SqlConnection("Server=DESKTOP-58CMK8T\\SQLEXPRESS;Database=Northwind; Trusted_Connection=true; TrustServerCertificate=true;");

            //SqlCommand command = new SqlCommand("Select * from Categories", connect);

            //List<Category> categories = new List<Category>();

            //connect.Open();
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Category cat = new Category();
            //    cat.CategoryId = reader.GetInt32(0);
            //    cat.CategoryName = reader.GetString(1);
            //    cat.Description = reader.GetString(2);

            //    categories.Add(cat);
            //}

            //dt_gridView.DataSource = categories;
            #endregion

            #region Kategorileri Listele

            //dt_gridView.DataSource = db.Categories.ToList();

            #endregion

            #region Soru: Çalışanların tabloosundan isim,soyisim,ünvan ve doğum tarihilerini listeleyiniz.

            //dt_gridView.DataSource = db.Employees.Select(x => new
            //{
            //    x.FirstName,
            //    x.LastName,
            //    x.Title,
            //    x.BirthDate
            //}).ToList();

            #endregion

            #region Soru: Çalışan id'si 2 ile 8 arasında olan çalışanların A-Z'ye olacak şekilde isimlerine göre sıralayınız

            //dt_gridView.DataSource = db.Employees.Where(x => x.EmployeeId >= 2 && x.EmployeeId <= 8).OrderBy(x => x.FirstName).ToList();

            #endregion

            #region Soru: 1960 yılında doğan çalışanları listeleyin

            //dt_gridView.DataSource = db.Employees.Where(x => x.BirthDate.Value.Year == 1960).ToList();

            #endregion

            #region Soru: 1950 ile 1961 aralığında doğmuş çalışanların ismi, soyismi ve doğum tarihini listeleyiniz 

            //dt_gridView.DataSource = db.Employees.Where(x => x.BirthDate.Value.Year >= 1950 && x.BirthDate.Value.Year <= 1961)
            //    .Select(x=> new
            //    {
            //        x.FirstName,
            //        x.LastName,
            //        x.BirthDate
            //    })
            //    .ToList();

            #endregion

            #region Soru: Ünvanı Mr. olan ve yaşı 60'tan büyük olan çalışanları listeleyin

            //dt_gridView.DataSource = db.Employees
            //    .Where(x => x.TitleOfCourtesy == "Mr." && EF.Functions.DateDiffYear(x.BirthDate, DateTime.Now) > 60).ToList();

            #endregion

            #region Soru: Çalışanların İsim,Soyisim,Ünvan ve yaşlarını yaşa göre azalan şekilde sıralayınız

            //OrderByDescending 9->0 Z->A
            //dt_gridView.DataSource = db.Employees.OrderByDescending(x => EF.Functions.DateDiffYear(x.BirthDate, DateTime.Now)).Select(x => new
            //{
            //    x.FirstName,
            //    x.LastName,
            //    x.TitleOfCourtesy,
            //    Yas = EF.Functions.DateDiffYear(x.BirthDate, DateTime.Now)
            //}).ToList();

            #endregion

            #region Soru: Doğum tarihi 1930 ile 1960 arasında olup da USA'da çalışanları listeleyiniz 

            //dt_gridView.DataSource = db.Employees.Where(x => x.BirthDate.Value.Year > 1930 && x.BirthDate.Value.Year < 1960 && x.Country == "USA").ToList();

            #endregion

            #region Products tablosunda ProductID,ProductName,CategoryID,CategoryName ve Description bilgilerini listeleyiniz

            //dt_gridView.DataSource = db.Products.Include(i => i.Category).Select(x => new
            //{
            //    x.ProductId,
            //    x.ProductName,
            //    x.Category.CategoryId,
            //    x.Category.CategoryName,
            //    x.Category.Description
            //}).ToList();

            #endregion
        }
    }
}
