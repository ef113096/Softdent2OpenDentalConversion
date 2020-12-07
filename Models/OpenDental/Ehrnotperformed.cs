using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrnotperformed
    {
        public long EhrNotPerformedNum { get; set; }
        public long PatNum { get; set; }
        public long ProvNum { get; set; }
        public string CodeValue { get; set; }
        public string CodeSystem { get; set; }
        public string CodeValueReason { get; set; }
        public string CodeSystemReason { get; set; }
        public string Note { get; set; }
        public DateTime DateEntry { get; set; }
    }
}
