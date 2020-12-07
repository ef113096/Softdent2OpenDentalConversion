using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Fee
    {
        public long FeeNum { get; set; }
        public double Amount { get; set; }
        public string OldCode { get; set; }
        public long FeeSched { get; set; }
        public byte UseDefaultFee { get; set; }
        public byte UseDefaultCov { get; set; }
        public long CodeNum { get; set; }
        public long ClinicNum { get; set; }
        public long ProvNum { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
