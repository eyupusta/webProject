//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ferry_Lines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ferry_Lines()
        {
            this.Ferries = new HashSet<Ferries>();
            this.FerryLines_Times = new HashSet<FerryLines_Times>();
            this.FerryLines_Drivers = new HashSet<FerryLines_Drivers>();
            this.FerryLines_Stations = new HashSet<FerryLines_Stations>();
        }
    
        public string LineID { get; set; }
        public string LineName { get; set; }
        public int OpenningYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ferries> Ferries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FerryLines_Times> FerryLines_Times { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FerryLines_Drivers> FerryLines_Drivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FerryLines_Stations> FerryLines_Stations { get; set; }
    }
}
