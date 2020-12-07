using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Insfilingcode
    {
        public long InsFilingCodeNum { get; set; }
        public string Descript { get; set; }
        public string EclaimCode { get; set; }
        public int? ItemOrder { get; set; }
        public long GroupType { get; set; }
    }
}
