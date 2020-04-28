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
using DevExpress.XtraPrinting;

namespace pczimmet.View
{
    public partial class pageBolumZimmetListesi : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım bölüme zimmetlenmiş parçaları göstermek için kullanılır
     /// </summary>
        public pageBolumZimmetListesi()
        {
            InitializeComponent();
            lueBolum.Properties.DataSource = OrtakDb.db.tblBolum.ToList();
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();


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
            lueBolum.Properties.DataSource = OrtakDb.db.tblBolum.ToList();
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
            // gridView1.Invalidate();
        }

        private void lueBolum_EditValueChanged(object sender, EventArgs e)
        {
            
            if (lueBolum.EditValue != null)
            {
                int id = (int)lueBolum.EditValue;
                var liste = OrtakDb.db.tblZimmet.Where(w => w.tblPersonel.bolumID ==id ).ToList();
                gridControl1.DataSource = liste;

                
            }
            else
            {
                gridControl1.DataSource = null;
            }

        }

        private void sbtnYazdir_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridControl1;
            link.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.ShowPreview();
        }
    }
}
