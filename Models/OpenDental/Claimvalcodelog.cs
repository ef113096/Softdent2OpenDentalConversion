using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimvalcodelog
    {
        public long ClaimValCodeLogNum { get; set; }
        public long ClaimNum { get; set; }
        public string ClaimField { get; set; }
        public string ValCode { get; set; }
        public double ValAmount { get; set; }
        public uint Ordinal { get; set; }
    }
}
