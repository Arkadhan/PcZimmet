using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pczimmet.Model;
using System.Data.Entity;
using pczimmet.Control;

namespace pczimmet.View
{
    public partial class pageYeniPc : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım var olan bir bilgisayar ve parçalarını eklemek için kullanılır
     /// </summary>
        public pageYeniPc()
        {
            InitializeComponent();
            lueSATedarikci.Properties.DataSource = OrtakDb.db.tblTedarikci.ToList();

        }

        public void clearPage()
        {
            txtSAPAdet.Text = "";
            txtSAPAdi.Text = "";
            txtSAPDate.Text = "";
            txtSAPFiyat.Text = "";
            txtSAPMarka.Text = "";
            txtSAPModel.Text = "";
            txtSAPOzellik.Text = "";
            icmeditTuru.EditValue = "";
            lueSATedarikci.EditValue = "";


        }

        public bool OpenPageSave()
        {
            DialogResult cevap=MessageBox.Show("Yeni Pc Kayıt Etmek İstiyormusunuz?", "Kaydetme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                tblPcStok stok = new tblPcStok();
                stok.satinalmaParcaAdi = txtSAPAdi.Text;
                stok.satinalmaTarihi = txtSAPDate.DateTime;
                stok.satinalmaFiyati = Convert.ToDecimal(txtSAPFiyat.Text);
                stok.satinalmaTuru = (int)icmeditTuru.EditValue;
                stok.satinalmaAdet = Convert.ToByte(txtSAPAdet.Text);
                stok.satinalmaMarka = txtSAPMarka.Text;
                stok.satinalmaModel = txtSAPModel.Text;
                stok.satinalmaOzellik = txtSAPOzellik.Text;
                stok.tedarikciID = (int)lueSATedarikci.EditValue;
                OrtakDb.db.tblPcStok.Add(stok);

                return true;
            }

            return false;
        }

        public void refreshPageData()
        {
            lueSATedarikci.Properties.DataSource = OrtakDb.db.tblTedarikci.ToList();
        }
    }
}
