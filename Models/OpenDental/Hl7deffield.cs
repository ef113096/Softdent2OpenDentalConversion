using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Hl7deffield
    {
        public long Hl7defFieldNum { get; set; }
        public long Hl7defSegmentNum { get; set; }
        public int OrdinalPos { get; set; }
        public string TableId { get; set; }
        public string DataType { get; set; }
        public string FieldName { get; set; }
        public string FixedText { get; set; }
    }
}
