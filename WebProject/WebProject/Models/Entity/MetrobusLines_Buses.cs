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
    
    public partial class MetrobusLines_Buses
    {
        public int MlbID { get; set; }
        public string LineID { get; set; }
        public int BusID { get; set; }
    
        public virtual Buses Buses { get; set; }
        public virtual Metrobus_Lines Metrobus_Lines { get; set; }
    }
}
