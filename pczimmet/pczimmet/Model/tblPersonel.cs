//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pczimmet.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPersonel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPersonel()
        {
            this.tblZimmet = new HashSet<tblZimmet>();
        }
    
        public int personelID { get; set; }
        public string personelAdi { get; set; }
        public string personelSoyadi { get; set; }
        public int personelTel { get; set; }
        public bool personelDurum { get; set; }
        public int bolumID { get; set; }
    
        public virtual tblBolum tblBolum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblZimmet> tblZimmet { get; set; }
    }
}