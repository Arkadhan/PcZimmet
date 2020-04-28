using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pczimmet.Model
{
    public partial class tblPcStok
    {/// <summary>
     /// Girilen parçaların adetlerini kontrol etmek için harici bir 
     /// atıkadet kontrolü kullandık. Bu sayede kullanıcın gdirden girdiği değeri burda
     /// saklayarak tekrardan doğru bir şekilde veritabanına yazabiliyoruz. 
     /// </summary>
        public int atikadet { get; set; }

    }
}
