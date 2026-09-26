using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace _20_PersonelYonetimSistemi
{
    public partial class PersonelEkrani : Form
    {
        BusinessLogicLayer BLL;

        public PersonelEkrani()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            int EKS = BLL.PersonelEkle(txt_ad.Text, txt_soyad.Text, txt_email.Text, txt_telefon.Text);

            if (EKS > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
                PersonelDoldur();
            }
            else if (EKS == -100)
            {
                MessageBox.Show("Eksik bilgi! Lütfen form alanlarını doldurunuz");
            }
            else
            {
                MessageBox.Show("Keyıt Eklenemedi");
            }
        }

        private void PersonelDoldur()
        {
            List<Personel> PersonelListesi = BLL.PersonelTumListe();

            lst_personellerim.DataSource = PersonelListesi;
        }

        private void PersonelEkrani_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
        }

        private void lst_personellerim_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            Personel LstPersonel = (Personel)listBox.SelectedItem;
            Personel DatabasePersonel = BLL.PersonelKayitGetir(LstPersonel.Id);

            if (DatabasePersonel != null)
            {
                txt_gad.Text = DatabasePersonel.Isim;
                txt_gsoyad.Text = DatabasePersonel.Soyisim;
                txt_gemail.Text = DatabasePersonel.EmailAdres;
                txt_gtelefon.Text = DatabasePersonel.Telefon;
            }

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int Id = ((Personel)lst_personellerim.SelectedItem).Id;

            int EKS = BLL.PersonelKayitGuncelle(Id, txt_gad.Text, txt_gsoyad.Text, txt_gemail.Text, txt_gtelefon.Text);

            if (EKS > 0)
            {
                MessageBox.Show("Kayıt Güncellendi");
                PersonelDoldur();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız!!");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int Id = ((Personel)lst_personellerim.SelectedItem).Id;

            int EKS = BLL.PersonelSil(Id);

            if (EKS > 0)
            {
                MessageBox.Show("Kayıt Silindi");
                PersonelDoldur();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız!!");
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                string isim = FakeData.NameData.GetFirstName();
                string soyisim = FakeData.NameData.GetSurname();
                BLL.PersonelEkle(isim, soyisim, isim + soyisim + "@test.com", FakeData.PhoneNumberData.GetPhoneNumber());
            }

            PersonelDoldur();
        }

        private void btn_jsonKaydet_Click(object sender, EventArgs e)
        {
            List<Personel> Personellerim = BLL.PersonelTumListe();

            string jsonData = JsonSerializer.Serialize(Personellerim);

            File.WriteAllText(@"C:\Json\Personellerim.json", jsonData);
        }

        private void btn_jsonAl_Click(object sender, EventArgs e)
        {
            string jsonData = File.ReadAllText(@"C:\Json\Personellerim.json");
            List<Personel> Personellerim = JsonSerializer.Deserialize<List<Personel>>(jsonData);

            for (int i = 0; i < Personellerim.Count; i++)
            {
                BLL.PersonelEkle(Personellerim[i].Isim, Personellerim[i].Soyisim, Personellerim[i].EmailAdres, Personellerim[i].Telefon);
            }

            PersonelDoldur();
        }
    }
}
