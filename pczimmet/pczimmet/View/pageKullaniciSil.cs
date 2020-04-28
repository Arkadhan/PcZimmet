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
    public partial class pageKullaniciSil : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım var olan bir kullanıcı silmek için kullanılır
     /// </summary>
        public pageKullaniciSil()
        {
            InitializeComponent();
            lueKullaniciSil.Properties.DataSource = OrtakDb.db.tblKullanici.ToList();
                 
        }
        public void clearPage()
        {
            lueKullaniciSil.SelectedText=lueKullaniciSil.Properties.NullText="Seçiniz";
            
        }

        public bool OpenPageSave()
        {
            DialogResult cevap = MessageBox.Show("Seçili Kullanıcıyı Silmek İstiyormusunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                tblKullanici deluser= new tblKullanici();
               
                int sil = (int)lueKullaniciSil.EditValue;
                deluser =OrtakDb.db.tblKullanici.Where(w => w.kullaniciID ==sil).FirstOrDefault();

                if (deluser != null)
                {
                    OrtakDb.db.tblKullanici.Remove(deluser);
                    return true;
                }
            }

            return false;
        }

        public void refreshPageData()
        {
            lueKullaniciSil.Properties.DataSource = OrtakDb.db.tblKullanici.ToList();
        }

        private void lueKullaniciSil_EditValueChanged(object sender, EventArgs e)
        {
            if (lueKullaniciSil.EditValue != null)
            {
                tblKullanici user = OrtakDb.db.tblKullanici.FirstOrDefault(x => x.kullaniciID == (int)lueKullaniciSil.EditValue);
                if (user != null)
                {
                    txteSifre.Text = user.kullaniciSifre;
                    txteYetki.Text = Convert.ToString(user.kullaniciYetki);
                    txteBolum.Text = user.tblBolum.bolumAdi;
                }
                else
                {
                    txteSifre.Text = null;
                    txteYetki.Text = null;
                    txteBolum.Text = null;
                }
            }

        }

        private void lueKullaniciSil_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }
    }
}
