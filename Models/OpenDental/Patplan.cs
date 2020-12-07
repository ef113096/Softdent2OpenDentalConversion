using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patplan
    {
        public long PatPlanNum { get; set; }
        public long PatNum { get; set; }
        public byte Ordinal { get; set; }
        public byte IsPending { get; set; }
        public byte Relationship { get; set; }
        public string PatId { get; set; }
        public long InsSubNum { get; set; }
        public double OrthoAutoFeeBilledOverride { get; set; }
        public DateTime OrthoAutoNextClaimDate { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
