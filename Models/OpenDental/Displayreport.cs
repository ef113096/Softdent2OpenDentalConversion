using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Displayreport
    {
        public long DisplayReportNum { get; set; }
        public string InternalName { get; set; }
        public int ItemOrder { get; set; }
        public string Description { get; set; }
        public sbyte Category { get; set; }
        public sbyte IsHidden { get; set; }
        public sbyte IsVisibleInSubMenu { get; set; }
    }
}
