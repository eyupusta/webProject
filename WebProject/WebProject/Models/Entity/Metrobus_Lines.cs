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
    
    public partial class Metrobus_Lines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Metrobus_Lines()
        {
            this.MetrobusLines_Times = new HashSet<MetrobusLines_Times>();
            this.MetrobusLines_Buses = new HashSet<MetrobusLines_Buses>();
            this.MetrobusLines_Drivers = new HashSet<MetrobusLines_Drivers>();
            this.MetrobusLines_Stations = new HashSet<MetrobusLines_Stations>();
        }
    
        public string LineID { get; set; }
        public string LineName { get; set; }
        public int OpenningYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetrobusLines_Times> MetrobusLines_Times { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetrobusLines_Buses> MetrobusLines_Buses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetrobusLines_Drivers> MetrobusLines_Drivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetrobusLines_Stations> MetrobusLines_Stations { get; set; }
    }
}