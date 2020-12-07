using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrsummaryccd
    {
        public long EhrSummaryCcdNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateSummary { get; set; }
        public string ContentSummary { get; set; }
        public long EmailAttachNum { get; set; }
    }
}
