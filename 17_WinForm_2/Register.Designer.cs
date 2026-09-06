namespace _17_WinForm_2
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_kayit = new Button();
            rch_adres = new RichTextBox();
            label10 = new Label();
            cmb_sehir = new ComboBox();
            label9 = new Label();
            nmr_yas = new NumericUpDown();
            label8 = new Label();
            dt_dogumtarihi = new DateTimePicker();
            label7 = new Label();
            msk_telefon = new MaskedTextBox();
            label6 = new Label();
            txt_sifre2 = new TextBox();
            label5 = new Label();
            txt_sifre = new TextBox();
            label4 = new Label();
            txt_kullaniciAdi = new TextBox();
            label3 = new Label();
            txt_soyad = new TextBox();
            label2 = new Label();
            txt_ad = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_yas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_kayit);
            groupBox1.Controls.Add(rch_adres);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmb_sehir);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(nmr_yas);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dt_dogumtarihi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(msk_telefon);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_sifre2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_sifre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_kullaniciAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_soyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_ad);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(54, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KULLANICI KAYIT PANELİ";
            // 
            // btn_kayit
            // 
            btn_kayit.BackColor = SystemColors.ActiveCaption;
            btn_kayit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_kayit.ForeColor = SystemColors.Control;
            btn_kayit.Location = new Point(455, 282);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(200, 35);
            btn_kayit.TabIndex = 20;
            btn_kayit.Text = "Kaydet";
            btn_kayit.UseVisualStyleBackColor = false;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // rch_adres
            // 
            rch_adres.Location = new Point(456, 153);
            rch_adres.Name = "rch_adres";
            rch_adres.Size = new Size(199, 104);
            rch_adres.TabIndex = 19;
            rch_adres.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(339, 156);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 18;
            label10.Text = "Adres:";
            // 
            // cmb_sehir
            // 
            cmb_sehir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmb_sehir.FormattingEnabled = true;
            cmb_sehir.Items.AddRange(new object[] { "İstanbul", "Ankara", "Hakkari", "Trabzon", "Ardahan", "Tokat", "Sivas", "Yozgat", "Mersin", "Gaziantep", "Siirt" });
            cmb_sehir.Location = new Point(455, 114);
            cmb_sehir.Name = "cmb_sehir";
            cmb_sehir.Size = new Size(200, 29);
            cmb_sehir.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(339, 117);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 16;
            label9.Text = "Şehir:";
            // 
            // nmr_yas
            // 
            nmr_yas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nmr_yas.Location = new Point(455, 76);
            nmr_yas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_yas.Name = "nmr_yas";
            nmr_yas.Size = new Size(200, 29);
            nmr_yas.TabIndex = 15;
            nmr_yas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(339, 79);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 14;
            label8.Text = "Yaş:";
            // 
            // dt_dogumtarihi
            // 
            dt_dogumtarihi.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dt_dogumtarihi.Location = new Point(455, 41);
            dt_dogumtarihi.Name = "dt_dogumtarihi";
            dt_dogumtarihi.Size = new Size(200, 23);
            dt_dogumtarihi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(339, 41);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 12;
            label7.Text = "Doğum Tarihi:";
            // 
            // msk_telefon
            // 
            msk_telefon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            msk_telefon.Location = new Point(133, 228);
            msk_telefon.Mask = "+90(999) 000-00-00";
            msk_telefon.Name = "msk_telefon";
            msk_telefon.Size = new Size(176, 29);
            msk_telefon.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(25, 232);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 10;
            label6.Text = "Telefon No:";
            // 
            // txt_sifre2
            // 
            txt_sifre2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_sifre2.Location = new Point(133, 191);
            txt_sifre2.Name = "txt_sifre2";
            txt_sifre2.Size = new Size(176, 29);
            txt_sifre2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(23, 194);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 8;
            label5.Text = "Tekrar Şifre:";
            // 
            // txt_sifre
            // 
            txt_sifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_sifre.Location = new Point(133, 153);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(176, 29);
            txt_sifre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(23, 156);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 6;
            label4.Text = "Şifre:";
            // 
            // txt_kullaniciAdi
            // 
            txt_kullaniciAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_kullaniciAdi.Location = new Point(133, 114);
            txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            txt_kullaniciAdi.Size = new Size(176, 29);
            txt_kullaniciAdi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı Adı:";
            // 
            // txt_soyad
            // 
            txt_soyad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_soyad.Location = new Point(133, 76);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(176, 29);
            txt_soyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // txt_ad
            // 
            txt_ad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_ad.Location = new Point(133, 38);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(176, 29);
            txt_ad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 427);
            Controls.Add(groupBox1);
            Name = "Register";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_yas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_ad;
        private Label label1;
        private TextBox txt_sifre2;
        private Label label5;
        private TextBox txt_sifre;
        private Label label4;
        private TextBox txt_kullaniciAdi;
        private Label label3;
        private TextBox txt_soyad;
        private Label label2;
        private Label label6;
        private MaskedTextBox msk_telefon;
        private DateTimePicker dt_dogumtarihi;
        private Label label7;
        private NumericUpDown nmr_yas;
        private Label label8;
        private ComboBox cmb_sehir;
        private Label label9;
        private RichTextBox rch_adres;
        private Label label10;
        private Button btn_kayit;
    }
}