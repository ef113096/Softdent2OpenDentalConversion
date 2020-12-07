using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Displayfield
    {
        public long DisplayFieldNum { get; set; }
        public string InternalName { get; set; }
        public int ItemOrder { get; set; }
        public string Description { get; set; }
        public int ColumnWidth { get; set; }
        public int Category { get; set; }
        public long ChartViewNum { get; set; }
        public string PickList { get; set; }
        public string DescriptionOverride { get; set; }
    }
}
