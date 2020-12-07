using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Gradingscale
    {
        public long GradingScaleNum { get; set; }
        public string Description { get; set; }
        public sbyte ScaleType { get; set; }
    }
}
