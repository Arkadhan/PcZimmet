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
    public partial class pageBolumEkle : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım bölüm ekleme için kullanılır.
     /// </summary>
        public pageBolumEkle()
        {
            InitializeComponent();

        }
        public void clearPage()
        {
            txtBolumekle.Text = "";
        }

        public bool OpenPageSave()
        {
            DialogResult cevap = MessageBox.Show("Yeni Bölüm Kayıt Etmek İstiyormusunuz?", "Kaydetme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                tblBolum bolum = new tblBolum();
                bolum.bolumAdi = txtBolumekle.Text;
                OrtakDb.db.tblBolum.Add(bolum);
                return true;
            }

            return false;
        }

        public void refreshPageData()
        {
           
        }
    }

}
