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
    
    public partial class RailSystems_Transfers
    {
        public int TransferID { get; set; }
        public string FromLineID { get; set; }
        public string ToLineID { get; set; }
        public int StationID { get; set; }
    
        public virtual Rail_Systems Rail_Systems { get; set; }
        public virtual Rail_Systems Rail_Systems1 { get; set; }
        public virtual Stations Stations { get; set; }
    }
}
