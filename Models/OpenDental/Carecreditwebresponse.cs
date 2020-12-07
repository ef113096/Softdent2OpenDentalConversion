using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Carecreditwebresponse
    {
        public long CareCreditWebResponseNum { get; set; }
        public long PatNum { get; set; }
        public long PayNum { get; set; }
        public string RefNumber { get; set; }
        public double Amount { get; set; }
        public string WebToken { get; set; }
        public string ProcessingStatus { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public DateTime DateTimePending { get; set; }
        public DateTime DateTimeCompleted { get; set; }
        public DateTime DateTimeExpired { get; set; }
        public DateTime DateTimeLastError { get; set; }
        public string LastResponseStr { get; set; }
        public long ClinicNum { get; set; }
        public string ServiceType { get; set; }
        public string TransType { get; set; }
    }
}
