namespace _17_WinForm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            #region Giriş Kontrolü

            //string kullaniciAdi = "altanemre";
            //string sifre = "1";

            //string username = txt_username.Text;
            //string password = txt_password.Text;

            //if (username == kullaniciAdi && password == sifre)
            //{
            //    MessageBox.Show("Giriş Başarılı");
            //}
            //else
            //{
            //    MessageBox.Show("Giriş Başarısız");
            //}

            #endregion

            #region Liste Kontrolü

            List<User> Users = new List<User>()
            {
                new User(){username="altanemre",password="1"},
                new User(){username="altanuras",password="1"},
                new User(){username="kerem",password="1"},
                new User(){username="kıvanç",password="1"}
            };


            string username = txt_username.Text;
            string password = txt_password.Text;

            foreach (User user in Users)
            {
                if(user.username==username && user.password == password)
                {
                    MessageBox.Show("GİRİŞ BAŞARILI");

                    this.Hide();
                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.Show();
                    return; //Aktif çalışan metodu durdurur.
                }
            }

            MessageBox.Show("GİRİŞ BAŞARISIZ!!");

            #endregion








        }
    }
}
