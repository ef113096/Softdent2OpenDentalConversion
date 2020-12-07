using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrmeasure
    {
        public long EhrMeasureNum { get; set; }
        public sbyte MeasureType { get; set; }
        public short Numerator { get; set; }
        public short Denominator { get; set; }
    }
}
