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
using DevExpress.XtraEditors;
using pczimmet.Model;

namespace pczimmet.View
{
    public partial class pageZimmetUpdate : UserControl, InterfaceDataPage
    {
        /// <summary>
        /// Bu kısım zimmeti güncellemek  için kullanılır
        /// </summary>
        BindingList<tblZimmet> zimmetListesi;// Mevcut zimmet listesi (Vertabanından çekilen listeler
        BindingList<tblZimmet> silinenzimmetListesi = new BindingList<tblZimmet>();// Geçiçi olarak silinen zimmet listesi
        public pageZimmetUpdate()
        {
            InitializeComponent();
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
            zimmetListesi = new BindingList<tblZimmet>(OrtakDb.db.tblZimmet.ToList());
            gridControl1.DataSource = zimmetListesi;
        }

        private void ribeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit edit = sender as ButtonEdit;//Basılan butonun nesnesini edit adıyna aldık. 
            if (edit != null)//basılan boton boş değilse
            {
                int id = (int)edit.EditValue;// basılan satırdaki basılan butonun id si

                tblZimmet zimmet = zimmetListesi.FirstOrDefault(x => x.zimmetID == id);// Zimmet tablosundan 
                // satırda seçilen zimmet id si ile tablodaki id ler eşitle ve zimmetin içine at

                if (zimmet != null)
                {
                    DialogResult cevap = MessageBox.Show(zimmet.tblPersonel.personelAdi + ":\nAdlı Personel üzerindeki " + zimmet.tblPcStok.satinalmaParcaAdi + ":\n Zimmeti Silmek İstiyor musunuz?", "Zimmet Değiştirme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        zimmetListesi.Remove(zimmet);// Zimmetlistesinden çıkartıyoruz
                        silinenzimmetListesi.Add(zimmet);//Geçiçi olan silinenzimmet listesine ekliyoruz
                    }
                }
            }

        }
        public bool OpenPageSave()
        {
            DialogResult cevap = MessageBox.Show("Silinen Zimmetleri Gerçekten Kayıt Etmek İstiyormusunuz?", "Kaydetme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
             foreach(tblZimmet z in silinenzimmetListesi)
                {
                    OrtakDb.db.tblZimmet.Remove(z);
                }

                return true;
            }

            return false;
        }

        public void clearPage()
        {
            silinenzimmetListesi.Clear();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)//Yapılan son işlemi geri alma buton clicki
        {
            if (silinenzimmetListesi.Count > 0)
            {

                tblZimmet z = silinenzimmetListesi[silinenzimmetListesi.Count - 1];
                zimmetListesi.Add(z);
                silinenzimmetListesi.Remove(z);
            }
            else
            {
                MessageBox.Show("Herhangi bir değişilik yapmadınız!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void refreshPageData()
        {
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
            zimmetListesi = new BindingList<tblZimmet>(OrtakDb.db.tblZimmet.ToList());
            gridControl1.DataSource = zimmetListesi;

        }
    }
}
