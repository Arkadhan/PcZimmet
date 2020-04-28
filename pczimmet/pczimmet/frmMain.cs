using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using pczimmet.View;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using pczimmet.Control;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;

namespace pczimmet
{
    public partial class formAna : RibbonForm
    {
        public formAna()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
            
        }

        private void formAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();//Formun tüm Threadlerini sonlandıran komut
        }

        private void pcSatinAl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageYeniPc), "Yeni Pc Ekle");
            //Yeni Pc Ekleme sayfasını oluşturup adını verdiğimiz metodu çağırıyoruz

        }

        public void SayfaAc(Type sayfaTuru,string text)
        {
            XtraTabPage eskiSayfa = SayfaBul(sayfaTuru);
                
            if(eskiSayfa!=null)
            {
                eskiSayfa.Show();
                return;
            }

            UserControl form = (UserControl)Activator.CreateInstance(sayfaTuru) as UserControl;

            XtraTabPage sayfa = new XtraTabPage();
            sayfa.Text = text;
            sayfa.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            xtraTabControl1.TabPages.Add(sayfa);
            xtraTabControl1.SelectedTabPage = sayfa;
        }

        XtraTabPage SayfaBul(Type sayfaTuru)
        {
            foreach(XtraTabPage sayfa in xtraTabControl1.TabPages)
            {
                if(sayfa.Controls.Count>0)
                {
                    System.Windows.Forms.Control ctrl = sayfa.Controls[0];

                    if (ctrl.GetType() == sayfaTuru)
                        return sayfa;
                }
            }

            return null;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs ea = (ClosePageButtonEventArgs)e;
                       
            xtraTabControl1.TabPages.Remove((XtraTabPage)ea.Page);

            if (ea.PrevPage!=null)
                ((XtraTabPage)ea.PrevPage).Show();
        }

        private void atikPcGirisi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageAtikPcGir), "Atık Pc Ekle");
            //Atık Pc Ekleme sayfasını oluşturup adını verdiğimiz metodu çağırıyoruz
        }

        private void kaydet_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraTabPage page = xtraTabControl1.SelectedTabPage;// Orta alanda bir sayfa tanımladık.
            if (page != null)
            {
                if (page.Controls.Count <= 0) return;//Hiç sayfa yoksa kaydetme işlemini yapmıyor

                //formu interface olarak oluşturduk 
                InterfaceDataPage form = page.Controls[0] as InterfaceDataPage;
                //ki katmanlı bir mimari oluşturalım

                if (form != null)
                {
                    if (form.OpenPageSave())//Sayfa açılmış ise 
                    {
                        OrtakDb.db.SaveChanges();// Değişiklikler kaydediliyor
                        MessageBox.Show("İşlem Başarıyla Gerçekleştirildi Sayfayı Güncelleyiniz", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (XtraTabPage sayfa in xtraTabControl1.TabPages)
                        {
                            if (sayfa.Controls.Count <= 0) continue;

                            InterfaceDataPage page2 = sayfa.Controls[0] as InterfaceDataPage;

                            if (page2 != null)
                            {
                                page2.refreshPageData();
                            }
                        }

                        form.clearPage();// Sayfa Temizleme metodu 
                    }
                }else
                    MessageBox.Show("Kayıt edilecek herhangi bir veri bulunamadı.","Kaydetme Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void zimmetListe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageZimmetListesi),"Zimmet Listesi");
            //Zimmet listesinin sayfasını oluşturup adını verdiğimiz metodu çağırıyoruz

        }

        private void kullEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageKullaniciEkle), "Kullanıcı Ekleme");
            //Kullanıcı Ekleme sayfasını oluşturup adını verdiğimiz metodu çağırıyoruz
        }

        private void bolumEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageBolumEkle), "Bölüm Ekle");
            //Bölüm Ekleme sayfasını oluşturup adını verdiğimiz metodu çağırıyoruz
        }

        private void kullSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageKullaniciSil), "Kullanıcı Silme");
            //Kullanıcı silme sayfasını oluşturup adını verdiğimiz metodu çağırıyoruz
        }

        private void bolumSil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageBolumSil), "Bölüm Sil");
        }

        private void pcStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pagePcStokListesi), "Pc Stok Listesi");
        }

        private void bolumZimmetListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageBolumZimmetListesi), "Bölüm Zimmet Listesi");
        }

        private void zimmetEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageZimmetEkle), "Zimmet Ekleme");
        }

        private void zimmetGuncelle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SayfaAc(typeof(pageZimmetUpdate), "Zimmet Güncelleme");
        }

        private void yazdir_ItemClick(object sender, ItemClickEventArgs e)
        {
            //foreach (XtraTabPage sayfa in xtraTabControl1.TabPages)
            //{
            //    if (sayfa.Controls.Count <= 0) continue;

            //    InterfaceDataPage page2 = sayfa.Controls[0] as InterfaceDataPage;

            //    if (page2 != null)
            //    {
            //        page2.refreshPageData();
            //    }
            //}
            //PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            //link.Component = ; //yazdıracağımız grid’i gösteriyoruz.
            //link.Landscape = true; //kenarlıkların, boşlukların görüntülenmesini sağlıyoruz.
            //link.ShowPreview(); //yazdırılacak gridi ekranda gösteriyoruz
        }
    }
}