using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Providerident
    {
        public long ProviderIdentNum { get; set; }
        public long ProvNum { get; set; }
        public string PayorId { get; set; }
        public byte SuppIdtype { get; set; }
        public string Idnumber { get; set; }
    }
}
