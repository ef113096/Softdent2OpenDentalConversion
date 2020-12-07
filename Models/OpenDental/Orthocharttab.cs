using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthocharttab
    {
        public long OrthoChartTabNum { get; set; }
        public string TabName { get; set; }
        public int ItemOrder { get; set; }
        public sbyte IsHidden { get; set; }
    }
}
