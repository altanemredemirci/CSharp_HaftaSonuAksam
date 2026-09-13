using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
    }
}
