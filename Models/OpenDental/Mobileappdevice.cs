using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Mobileappdevice
    {
        public long MobileAppDeviceNum { get; set; }
        public long ClinicNum { get; set; }
        public string DeviceName { get; set; }
        public string UniqueId { get; set; }
        public sbyte IsAllowed { get; set; }
        public DateTime LastAttempt { get; set; }
        public DateTime LastLogin { get; set; }
        public long PatNum { get; set; }
        public DateTime LastCheckInActivity { get; set; }
    }
}
