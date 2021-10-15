using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Murugi_25July.ViewModels
{
    public class RequestsListViewModel
    {
        public string RequestID { get; set; }
        public string RequestType { get; set; }
        public string Description { get; set; }
        public string Date_Time { get; set; }
        public string RequesterIdNumber { get; set; }
        public int Location { get; set; }
        public string VehicleRegistrationNo { get; set; }
        public decimal Amount { get; set; }
        public string RequestStatus { get; set; }
    }
}