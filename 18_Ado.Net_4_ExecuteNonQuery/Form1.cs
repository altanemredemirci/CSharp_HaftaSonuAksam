using Microsoft.Data.SqlClient;

namespace _18_Ado.Net_4_ExecuteNonQuery
{
    public partial class Form1 : Form
    {
        SqlConnection connect;

        public Form1()
        {
            InitializeComponent();
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-58CMK8T\\SQLEXPRESS; Initial Catalog=OkulDB; Integrated Security=true; TrustServerCertificate=true;";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"Insert into Ogrenci (Ad,Soyad,Adres) values ('{txt_ad.Text}','{txt_soyad.Text}','{rch_adres.Text}')", connect);



            connect.Open();

            command.ExecuteNonQuery(); //Tabloda ekleme,silme,güncelleme komutları çalıştırılacak ise kullanılır.

            MessageBox.Show("Kayıt Eklendi");

            connect.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = (int)nmr_gid.Value;

            if (id > 0)
            {
                SqlCommand command = new SqlCommand($"Update Ogrenci set Ad='{txt_gad.Text}', Soyad='{txt_gsoyad.Text}', Adres='{rch_gadres.Text}' where Id={id}", connect);

                connect.Open();

                command.ExecuteNonQuery();

                MessageBox.Show("Kayıt Güncellendi.");

                connect.Close();
            }

            else
            {
                MessageBox.Show("Id değeri giriniz.");
            }



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = (int)nmr_sid.Value;

            SqlCommand command = new SqlCommand($"Delete From Ogrenci where Id={id}", connect);

            connect.Open();

            command.ExecuteNonQuery();

            MessageBox.Show("Kayıt Silindi.");

            connect.Close();

        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Ogrenci", connect);

            connect.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string ad = reader.GetString(1);
                string soyad = reader.GetString(2);
                string adres = reader.GetString(3);

                lst_ogrenciler.Items.Add(id + " " + ad + " " + soyad + " " + adres);
            }

            reader.Close();
            connect.Close();
        }
    }
}
