using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrquarterlykey
    {
        public long EhrQuarterlyKeyNum { get; set; }
        public int YearValue { get; set; }
        public int QuarterValue { get; set; }
        public string PracticeName { get; set; }
        public string KeyValue { get; set; }
        public long PatNum { get; set; }
        public string Notes { get; set; }
    }
}
