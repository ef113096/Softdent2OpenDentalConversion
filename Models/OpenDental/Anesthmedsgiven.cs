using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anesthmedsgiven
    {
        public int AnestheticMedNum { get; set; }
        public int AnestheticRecordNum { get; set; }
        public string AnesthMedName { get; set; }
        public double? QtyGiven { get; set; }
        public double? QtyWasted { get; set; }
        public string DoseTimeStamp { get; set; }
        public double? QtyOnHandOld { get; set; }
        public int AnesthMedNum { get; set; }
    }
}
