using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Clinicpref
    {
        public long ClinicPrefNum { get; set; }
        public long ClinicNum { get; set; }
        public string PrefName { get; set; }
        public string ValueString { get; set; }
    }
}
