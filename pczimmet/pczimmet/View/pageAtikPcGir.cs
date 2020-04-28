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
using DevExpress.XtraEditors;

namespace pczimmet.View
{
    public partial class pageAtikPcGir : UserControl, InterfaceDataPage
    {
        /// <summary>
        /// Bu kısım kullanılmayan bilgisayarların atığa gönderilmesi için kullanılır
        /// </summary>
        BindingList<tblPcStok> stokListesi;// Mevcut zimmet listesi (Vertabanından çekilen listeler
        BindingList<tblPcStok> silinenzimmetListesi = new BindingList<tblPcStok>();// Geçiçi olarak silinen zimmet listesi
        public pageAtikPcGir()
        {
            InitializeComponent();
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
            stokListesi = new BindingList<tblPcStok>(OrtakDb.db.tblPcStok.ToList());
            gridControl1.DataSource = stokListesi;
        }

        private void ribeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit edit = sender as ButtonEdit;//Basılan butonun nesnesini edit adıyna aldık. 
            if (edit != null)//basılan boton boş değilse
            {
                int id = (int)edit.EditValue;// basılan satırdaki basılan butonun id si

                tblPcStok stok = stokListesi.FirstOrDefault(x => x.satinalmaID == id);// Zimmet tablosundan 
                // satırda seçilen zimmet id si ile tablodaki id ler eşitle ve zimmetin içine at

                if (stok != null)
                {
                    DialogResult cevap = MessageBox.Show(stok.satinalmaParcaAdi + ":\n Stokğu Atığa atmak istiyor musunuz?", "Zimmet Değiştirme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        stokListesi.Remove(stok);// Zimmetlistesinden çıkartıyoruz
                        silinenzimmetListesi.Add(stok);//Geçiçi olan silinenzimmet listesine ekliyoruz
                    }
                }
            }

        }
        public bool OpenPageSave()
        {
            DialogResult cevap = MessageBox.Show("Slinen Pc Parçalarını Gerçekten Kayıt Etmek İstiyormusunuz?", "Kaydetme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                foreach (tblPcStok z in silinenzimmetListesi)
                {
                    if (z.atikadet > z.satinalmaAdet)
                    {
                        MessageBox.Show("Adet olarak var olandan fazla parçayı atığa atmaya çalışıyorsunuz!", "Fazla Atık Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        tblAtikPc atik = new tblAtikPc();
                        atik.atikAdi = z.satinalmaParcaAdi;
                        atik.atikAdedi = z.atikadet;
                        atik.atikMarka = z.satinalmaMarka;
                        atik.atikModel = z.satinalmaModel;
                        atik.atikOzellik = z.satinalmaOzellik;
                        atik.satinalmaID = z.satinalmaID;
                        OrtakDb.db.tblAtikPc.Add(atik);
                        z.satinalmaAdet = (byte)(z.satinalmaAdet-(byte)z.atikadet);
                    }
                                        
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

                tblPcStok z = silinenzimmetListesi[silinenzimmetListesi.Count - 1];
                stokListesi.Add(z);
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
            stokListesi = new BindingList<tblPcStok>(OrtakDb.db.tblPcStok.ToList());
            gridControl1.DataSource = stokListesi;

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            SpinEdit edit = gridView1.ActiveEditor as SpinEdit;
            tblPcStok stok = gridView1.GetFocusedRow() as tblPcStok;

            if(edit!=null && stok!=null)
            {
                edit.Properties.MinValue = 1;
                edit.Properties.MaxValue = stok.satinalmaAdet;
                edit.EditValue = 1;
                
            }
        }
    }
}