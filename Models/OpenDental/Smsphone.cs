using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Smsphone
    {
        public long SmsPhoneNum { get; set; }
        public long ClinicNum { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateTimeActive { get; set; }
        public DateTime DateTimeInactive { get; set; }
        public string InactiveCode { get; set; }
        public string CountryCode { get; set; }
    }
}
