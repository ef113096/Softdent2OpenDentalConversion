using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Hl7defsegment
    {
        public long Hl7defSegmentNum { get; set; }
        public long Hl7defMessageNum { get; set; }
        public int ItemOrder { get; set; }
        public sbyte CanRepeat { get; set; }
        public sbyte IsOptional { get; set; }
        public string SegmentName { get; set; }
        public string Note { get; set; }
    }
}
