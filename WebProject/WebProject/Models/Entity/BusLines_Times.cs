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
    
    public partial class BusLines_Times
    {
        public int BltID { get; set; }
        public string LineID { get; set; }
        public int TimeID { get; set; }
    
        public virtual Bus_Lines Bus_Lines { get; set; }
        public virtual Times Times { get; set; }
    }
}
