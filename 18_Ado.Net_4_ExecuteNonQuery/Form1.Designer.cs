namespace _18_Ado.Net_4_ExecuteNonQuery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_ad = new TextBox();
            label2 = new Label();
            txt_soyad = new TextBox();
            label3 = new Label();
            rch_adres = new RichTextBox();
            btn_kaydet = new Button();
            btn_guncelle = new Button();
            rch_gadres = new RichTextBox();
            label4 = new Label();
            txt_gsoyad = new TextBox();
            label5 = new Label();
            txt_gad = new TextBox();
            label6 = new Label();
            label7 = new Label();
            nmr_gid = new NumericUpDown();
            nmr_sid = new NumericUpDown();
            label8 = new Label();
            btn_sil = new Button();
            lst_ogrenciler = new ListBox();
            btn_liste = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_gid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_sid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 59);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(138, 56);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(193, 23);
            txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 93);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "SOYAD:";
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(138, 90);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(193, 23);
            txt_soyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 130);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "ADRES:";
            // 
            // rch_adres
            // 
            rch_adres.Location = new Point(139, 130);
            rch_adres.Name = "rch_adres";
            rch_adres.Size = new Size(192, 96);
            rch_adres.TabIndex = 5;
            rch_adres.Text = "";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(140, 244);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(191, 26);
            btn_kaydet.TabIndex = 6;
            btn_kaydet.Text = "KAYDET";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(471, 244);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(191, 26);
            btn_guncelle.TabIndex = 13;
            btn_guncelle.Text = "GÜNCELLE";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // rch_gadres
            // 
            rch_gadres.Location = new Point(470, 164);
            rch_gadres.Name = "rch_gadres";
            rch_gadres.Size = new Size(192, 62);
            rch_gadres.TabIndex = 12;
            rch_gadres.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 164);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 11;
            label4.Text = "ADRES:";
            // 
            // txt_gsoyad
            // 
            txt_gsoyad.Location = new Point(469, 124);
            txt_gsoyad.Name = "txt_gsoyad";
            txt_gsoyad.Size = new Size(193, 23);
            txt_gsoyad.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 127);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "SOYAD:";
            // 
            // txt_gad
            // 
            txt_gad.Location = new Point(469, 90);
            txt_gad.Name = "txt_gad";
            txt_gad.Size = new Size(193, 23);
            txt_gad.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 93);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 7;
            label6.Text = "AD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 58);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 14;
            label7.Text = "ID:";
            // 
            // nmr_gid
            // 
            nmr_gid.Location = new Point(469, 56);
            nmr_gid.Name = "nmr_gid";
            nmr_gid.Size = new Size(193, 23);
            nmr_gid.TabIndex = 15;
            // 
            // nmr_sid
            // 
            nmr_sid.Location = new Point(776, 56);
            nmr_sid.Name = "nmr_sid";
            nmr_sid.Size = new Size(193, 23);
            nmr_sid.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(708, 58);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 16;
            label8.Text = "ID:";
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(778, 93);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(191, 26);
            btn_sil.TabIndex = 18;
            btn_sil.Text = "SİL";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // lst_ogrenciler
            // 
            lst_ogrenciler.FormattingEnabled = true;
            lst_ogrenciler.Location = new Point(140, 312);
            lst_ogrenciler.Name = "lst_ogrenciler";
            lst_ogrenciler.Size = new Size(191, 214);
            lst_ogrenciler.TabIndex = 19;
            // 
            // btn_liste
            // 
            btn_liste.Location = new Point(138, 549);
            btn_liste.Name = "btn_liste";
            btn_liste.Size = new Size(191, 26);
            btn_liste.TabIndex = 20;
            btn_liste.Text = "LİSTELE";
            btn_liste.UseVisualStyleBackColor = true;
            btn_liste.Click += btn_liste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 587);
            Controls.Add(btn_liste);
            Controls.Add(lst_ogrenciler);
            Controls.Add(btn_sil);
            Controls.Add(nmr_sid);
            Controls.Add(label8);
            Controls.Add(nmr_gid);
            Controls.Add(label7);
            Controls.Add(btn_guncelle);
            Controls.Add(rch_gadres);
            Controls.Add(label4);
            Controls.Add(txt_gsoyad);
            Controls.Add(label5);
            Controls.Add(txt_gad);
            Controls.Add(label6);
            Controls.Add(btn_kaydet);
            Controls.Add(rch_adres);
            Controls.Add(label3);
            Controls.Add(txt_soyad);
            Controls.Add(label2);
            Controls.Add(txt_ad);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmr_gid).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_sid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_ad;
        private Label label2;
        private TextBox txt_soyad;
        private Label label3;
        private RichTextBox rch_adres;
        private Button btn_kaydet;
        private Button btn_guncelle;
        private RichTextBox rch_gadres;
        private Label label4;
        private TextBox txt_gsoyad;
        private Label label5;
        private TextBox txt_gad;
        private Label label6;
        private Label label7;
        private NumericUpDown nmr_gid;
        private NumericUpDown nmr_sid;
        private Label label8;
        private Button btn_sil;
        private ListBox lst_ogrenciler;
        private Button btn_liste;
    }
}
