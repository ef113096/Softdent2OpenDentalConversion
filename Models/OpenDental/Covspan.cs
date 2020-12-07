using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Covspan
    {
        public long CovSpanNum { get; set; }
        public long CovCatNum { get; set; }
        public string FromCode { get; set; }
        public string ToCode { get; set; }
    }
}
