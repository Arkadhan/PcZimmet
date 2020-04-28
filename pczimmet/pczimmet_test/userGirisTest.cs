using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.Contracts;
using pczimmet.Model;
using pczimmet.View;

namespace pczimmet_test
{
    [TestClass]
    public class userGirisTest
    {
        
        [TestMethod]
        public void Form()
        {
            pczimmet.userGiris giris = new pczimmet.userGiris();
            Assert.IsNotNull(giris);
        }

        [TestMethod()]
        public void FormUserGirisTest()
        {
            int beklenenDeger = 2;
            string kullaniciAdi = "";
            string sifre = "";
            pczimmet.userGiris giris = new pczimmet.userGiris();
            int sonuc = Convert.ToInt16(giris.GirisYap(kullaniciAdi,sifre));
            Assert.AreEqual(beklenenDeger, sonuc);                 
        }
        [TestMethod()]
        public void connectionTest()
        {
            pcZimmetEntities db = new pcZimmetEntities();
        }

        [TestMethod]
        public void introRunTest()
        {
            intro splash = new intro();
            Assert.IsNotNull(splash);
       
        }


    }
}
