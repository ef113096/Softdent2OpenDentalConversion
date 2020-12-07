using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthocharttablink
    {
        public long OrthoChartTabLinkNum { get; set; }
        public int ItemOrder { get; set; }
        public long OrthoChartTabNum { get; set; }
        public long DisplayFieldNum { get; set; }
        public int ColumnWidthOverride { get; set; }
    }
}
