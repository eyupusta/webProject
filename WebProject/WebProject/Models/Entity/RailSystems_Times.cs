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
    
    public partial class RailSystems_Times
    {
        public int RstID { get; set; }
        public string LineID { get; set; }
        public int TimeID { get; set; }
    
        public virtual Rail_Systems Rail_Systems { get; set; }
        public virtual Times Times { get; set; }
    }
}