using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Eservicesignal
    {
        public long EserviceSignalNum { get; set; }
        public int ServiceCode { get; set; }
        public int ReasonCategory { get; set; }
        public int ReasonCode { get; set; }
        public sbyte Severity { get; set; }
        public string Description { get; set; }
        public DateTime SigDateTime { get; set; }
        public string Tag { get; set; }
        public sbyte IsProcessed { get; set; }
    }
}
