using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Providerclinic
    {
        public long ProviderClinicNum { get; set; }
        public long ProvNum { get; set; }
        public long ClinicNum { get; set; }
        public string Deanum { get; set; }
        public string StateLicense { get; set; }
        public string StateRxId { get; set; }
        public string StateWhereLicensed { get; set; }
    }
}
