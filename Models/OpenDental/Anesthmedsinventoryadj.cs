using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anesthmedsinventoryadj
    {
        public int AdjustNum { get; set; }
        public int AnestheticMedNum { get; set; }
        public double? QtyAdj { get; set; }
        public int UserNum { get; set; }
        public string Notes { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
