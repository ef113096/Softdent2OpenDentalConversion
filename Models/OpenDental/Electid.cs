using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Electid
    {
        public long ElectIdnum { get; set; }
        public string PayorId { get; set; }
        public string CarrierName { get; set; }
        public byte IsMedicaid { get; set; }
        public string ProviderTypes { get; set; }
        public string Comments { get; set; }
    }
}
