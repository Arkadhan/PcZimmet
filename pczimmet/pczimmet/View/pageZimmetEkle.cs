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
    public partial class pageZimmetEkle : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım var olan bir kullanıcıya var olan bir parçayı zimmetlemek için kullanılır.
     /// </summary>
        BindingList<tblZimmet> gecicizimmetlistesi = new BindingList<tblZimmet>();//Temp alanında gecizimmet ekler onayla dediğimizde 
        //veritabanına onaylanan verileri ekler


        public pageZimmetEkle()
        {
            InitializeComponent();
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();//Repository look Up Edit componenetine Personeli ekler
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
            gridControl1.DataSource = gecicizimmetlistesi;
        }

        public void clearPage()
        {
            
        }

        public bool OpenPageSave()
        {
            return true;
        }

        public void refreshPageData()
        {
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();//Repository look Up Edit componenetine Personeli ekler
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
           
        }

        private void sbtnOnay_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Zimmetleri Kayıt Etmek İstiyor musunuz?", "Kaydetme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                foreach (tblZimmet zimmetle in gecicizimmetlistesi)
                {
                    OrtakDb.db.tblZimmet.Add(zimmetle);
                }

                OrtakDb.db.SaveChanges();

            }

        }
    }
}
