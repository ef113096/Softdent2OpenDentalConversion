using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Providererx
    {
        public long ProviderErxNum { get; set; }
        public long PatNum { get; set; }
        public string NationalProviderId { get; set; }
        public sbyte IsEnabled { get; set; }
        public sbyte IsIdentifyProofed { get; set; }
        public sbyte IsSentToHq { get; set; }
        public sbyte IsEpcs { get; set; }
        public sbyte ErxType { get; set; }
        public string UserId { get; set; }
        public string AccountId { get; set; }
        public long RegistrationKeyNum { get; set; }
    }
}
