using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Covcat
    {
        public long CovCatNum { get; set; }
        public string Description { get; set; }
        public short DefaultPercent { get; set; }
        public byte CovOrder { get; set; }
        public byte IsHidden { get; set; }
        public byte EbenefitCat { get; set; }
    }
}
