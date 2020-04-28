using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pczimmet.Control;
using pczimmet.Model;

namespace pczimmet.View
{
    public partial class pageKullaniciEkle : UserControl,InterfaceDataPage
    {/// <summary>
     /// Bu kısım kullanıcı eklemek için kullanılır
     /// </summary>
        public pageKullaniciEkle()
        {
            InitializeComponent();
            lueBolumAdi.Properties.DataSource = OrtakDb.db.tblBolum.ToList();
        }
        public void clearPage()
        {
            txtKullAdi.Text = "";
            txtKullSifre.Text = "";
            lueBolumAdi.EditValue = "";
            icbeKullYetki.EditValue = "";
            
        }

        public bool OpenPageSave()
        {
            DialogResult cevap = MessageBox.Show("Yeni Kullanıcıyı Kayıt Etmek İstiyor musunuz?", "Kaydetme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                tblKullanici yeniuser = new tblKullanici();
                yeniuser.kullaniciAdi = txtKullAdi.Text;
                yeniuser.kullaniciSifre = txtKullSifre.Text;
                yeniuser.kullaniciYetki =Convert.ToByte(icbeKullYetki.EditValue);
                yeniuser.bolumID =(int)lueBolumAdi.EditValue;
                
                OrtakDb.db.tblKullanici.Add(yeniuser);

                return true;
            }

            return false;
        }

        public void refreshPageData()
        {
            
        }
    }
}
