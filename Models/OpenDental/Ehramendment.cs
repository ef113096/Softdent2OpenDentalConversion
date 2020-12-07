using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehramendment
    {
        public long EhrAmendmentNum { get; set; }
        public long PatNum { get; set; }
        public sbyte IsAccepted { get; set; }
        public string Description { get; set; }
        public sbyte Source { get; set; }
        public string SourceName { get; set; }
        public string FileName { get; set; }
        public string RawBase64 { get; set; }
        public DateTime DateTrequest { get; set; }
        public DateTime DateTacceptDeny { get; set; }
        public DateTime DateTappend { get; set; }
    }
}
