using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Dunning
    {
        public long DunningNum { get; set; }
        public string DunMessage { get; set; }
        public long BillingType { get; set; }
        public byte AgeAccount { get; set; }
        public byte InsIsPending { get; set; }
        public string MessageBold { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public int DaysInAdvance { get; set; }
        public long ClinicNum { get; set; }
        public sbyte IsSuperFamily { get; set; }
    }
}
