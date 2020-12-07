using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anesthmedsinventory
    {
        public int AnestheticMedNum { get; set; }
        public string AnesthMedName { get; set; }
        public string AnesthHowSupplied { get; set; }
        public double? QtyOnHand { get; set; }
        public string Deaschedule { get; set; }
    }
}
