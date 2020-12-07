using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehraptob
    {
        public long EhrAptObsNum { get; set; }
        public long AptNum { get; set; }
        public sbyte IdentifyingCode { get; set; }
        public sbyte ValType { get; set; }
        public string ValReported { get; set; }
        public string UcumCode { get; set; }
        public string ValCodeSystem { get; set; }
    }
}
