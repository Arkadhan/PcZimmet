using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pczimmet.Control
{
    interface InterfaceDataPage
    {/// <summary>
     /// Bu kısımda bir arayüz tanımlayarak her açılan sayfanın bu arayüzün üzerinden
     /// geçerek sayfaların daha kontrollü açılmasını ve yönetilmesini sağlamaktadır.
     /// Tüm sayfların üstündeki bir yönetim arayüzü dür. 
     /// </summary>
        bool OpenPageSave();
        void clearPage();
        void refreshPageData();

    }
}
