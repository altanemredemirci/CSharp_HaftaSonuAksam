namespace _20_PersonelYonetimSistemi
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int EKS = BLL.SistemGirisKontrol(txt_username.Text, txt_password.Text);

            if (EKS > 0)
            {
                this.Hide();
                PersonelEkrani personelEkrani = new PersonelEkrani();
                personelEkrani.Show();
            }
            else if (EKS == -100)
            {
                MessageBox.Show("Eksik bilgi! Lütfen form alanlarını doldurunuz.");
            }
            else
            {
                MessageBox.Show("Giriş bilgileriniz hatalı");
            }
        }
    }
}
