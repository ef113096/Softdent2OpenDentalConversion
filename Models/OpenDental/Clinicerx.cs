using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Clinicerx
    {
        public long ClinicErxNum { get; set; }
        public long PatNum { get; set; }
        public string ClinicDesc { get; set; }
        public long ClinicNum { get; set; }
        public sbyte EnabledStatus { get; set; }
        public string ClinicId { get; set; }
        public string ClinicKey { get; set; }
        public string AccountId { get; set; }
        public long RegistrationKeyNum { get; set; }
    }
}
