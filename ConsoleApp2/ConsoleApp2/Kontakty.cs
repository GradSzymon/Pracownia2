//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Xml.Serialization;

namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Kontakty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kontakty()
        {
            this.Managers = new HashSet<Manager>();
            this.Pracownicies = new HashSet<Pracownicy>();
        }
    
        public int IDK { get; set; }
        public int Osoba { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Managers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy> Pracownicies { get; set; }
    }
}
