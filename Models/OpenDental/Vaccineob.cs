using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Vaccineob
    {
        public long VaccineObsNum { get; set; }
        public long VaccinePatNum { get; set; }
        public sbyte ValType { get; set; }
        public sbyte IdentifyingCode { get; set; }
        public string ValReported { get; set; }
        public sbyte ValCodeSystem { get; set; }
        public long VaccineObsNumGroup { get; set; }
        public string UcumCode { get; set; }
        public DateTime DateObs { get; set; }
        public string MethodCode { get; set; }
    }
}
