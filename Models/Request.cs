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
        public string Request_ID { get; set; }
        public string RequestType { get; set; }
        public string Description { get; set; }
        public System.DateTime Date_Time { get; set; }
        public int User_ID { get; set; }
        public string Vehicle_ID { get; set; }
        public decimal TotalAmount { get; set; }
        public string RequestStatus { get; set; }
    }
}