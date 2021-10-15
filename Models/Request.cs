//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Murugi_25July.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public string RequestID { get; set; }
        public string RequestType { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date_Time { get; set; }
        public string RequesterIdNumber { get; set; }
        public int Location { get; set; }
        public string VehicleRegistrationNo { get; set; }
        public decimal Amount { get; set; }
        public string RequestStatus { get; set; }
    
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
