using pczimmet.Control;
using pczimmet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pczimmet
{
    public partial class userGiris : Form
    {/// <summary>
     /// Bu kısım kullanıcı girişi için kullanılır.
     /// </summary>
        public userGiris()
        {
            InitializeComponent();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (GirisYap(txtKullaniciAdi.Text, txtSifre.Text) == 1)
                this.Hide();
        }

        

        public int GirisYap(string kullaniciAdi, string sifre)
        {
            try
            {
                if (kullaniciAdi != "" && sifre != "")//kullanıcı adı ve parolanın dolu olup olmadığının kontrolü
                {
                    if (IsNumeric(kullaniciAdi))//kullanıcı adı sayısal olamaz.
                        MessageBox.Show("Kullanıcı adı sayısal olamaz.");
                    else
                    {
                        tblKullanici k = OrtakDb.db.tblKullanici.FirstOrDefault(x => x.kullaniciAdi == kullaniciAdi && x.kullaniciSifre == sifre);//kullanıcıAdı ve paraloya göre kullanıcı bulunur.
                        if (k != null)
                        {
                            //OrtakDb.db.SaveChanges();
                            formAna fmAna = new formAna();
                            fmAna.Show();
                            txtKullaniciAdi.Text = "";
                            txtSifre.Text = "";
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }

                }
                else
                    MessageBox.Show("Lütfen kullanıcı adınızı ve şifrenizi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Oluştu!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 3;
            }
        }
        public bool IsNumeric(string text)//inputların sayı olup olmadığının kontrolü
        {
            bool sayiMi = true;
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr))
                    sayiMi = false;
            }
            return sayiMi;
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)//Basılan tuşu bulan metot (Amaç Enter a basıldığında dahi giriş işlemine başlaması
        {
            if (e.KeyCode == Keys.Enter)//Enter tuşuna basılıp basılmadığını kontrol ediyor
            {
                GirisYap(txtKullaniciAdi.Text, txtSifre.Text);

            }
        }


    }
}

  
    

