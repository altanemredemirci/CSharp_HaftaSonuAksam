using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _17_WinForm_2
{
    public partial class Register : Form
    {
        public Register()
        {
           InitializeComponent(); //Windows Form araçlarının yüklendiği kod satırı
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kullaniciAdi.Text) || string.IsNullOrEmpty(txt_sifre.Text) || string.IsNullOrEmpty(txt_sifre2.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
            else
            {
                if (txt_sifre.Text != txt_sifre2.Text)
                {
                    MessageBox.Show("Girilen şifreler uyuşmamaktadır.");
                }

                else
                {
                    List<User> Users = new List<User>();

                    User user = new User();
                    user.Ad = txt_ad.Text;
                    user.Soyad = txt_soyad.Text;
                    user.DogumTarihi = dt_dogumtarihi.Text;
                    user.Adres = rch_adres.Text;
                    user.Sehir = cmb_sehir.Text;
                    user.Sifre = txt_sifre.Text;
                    user.Telefon = msk_telefon.Text;
                    user.Yas = (int)nmr_yas.Value;
                    user.KullaniciAdi = txt_kullaniciAdi.Text;

                    Users.Add(user);
                }
            }
        }
    }
}
