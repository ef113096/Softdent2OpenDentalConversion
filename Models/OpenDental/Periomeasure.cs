using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Periomeasure
    {
        public long PerioMeasureNum { get; set; }
        public long PerioExamNum { get; set; }
        public byte SequenceType { get; set; }
        public short IntTooth { get; set; }
        public short ToothValue { get; set; }
        public short Mbvalue { get; set; }
        public short Bvalue { get; set; }
        public short Dbvalue { get; set; }
        public short Mlvalue { get; set; }
        public short Lvalue { get; set; }
        public short Dlvalue { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
