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
    public partial class pageBolumSil : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım var olan bir bölümü silmek için kullanılır
     /// </summary>
        public pageBolumSil()
        {
            InitializeComponent();
            lueBolumSil.Properties.DataSource = OrtakDb.db.tblKullanici.ToList();
        }
        public void clearPage()
        {
            lueBolumSil.SelectedText = lueBolumSil.Properties.NullText = "Seçiniz";

        }

        public bool OpenPageSave()
        {
            DialogResult cevap = MessageBox.Show("Seçili Bölümü Silmek İstiyormusunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                tblBolum delbolum = new tblBolum();
                int sil = (int)lueBolumSil.EditValue;
                delbolum = OrtakDb.db.tblBolum.Where(w => w.bolumID == sil).FirstOrDefault();
                if (delbolum != null)
                {
                    OrtakDb.db.tblBolum.Remove(delbolum);
                    return true;
                }
            }

            return false;
        }

        public void refreshPageData()
        {
            
        }
    }
}
