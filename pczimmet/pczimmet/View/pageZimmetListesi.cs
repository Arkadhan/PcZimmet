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
    public partial class pageZimmetListesi : UserControl, InterfaceDataPage
    {/// <summary>
     /// Bu kısım hangi personelin hangi parçayı zimmet aldığını göstermek için kullanılır
     /// </summary>
        public pageZimmetListesi()
        {
            InitializeComponent();
            repluePersonel.DataSource = OrtakDb.db.tblPersonel.ToList();
            replueParca.DataSource = OrtakDb.db.tblPcStok.ToList();
            gridControl1.DataSource = OrtakDb.db.tblZimmet.ToList();

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
            gridControl1.DataSource = OrtakDb.db.tblZimmet.ToList();
            //gridView1.Invalidate();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
