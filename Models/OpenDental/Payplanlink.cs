using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payplanlink
    {
        public long PayPlanLinkNum { get; set; }
        public long PayPlanNum { get; set; }
        public sbyte LinkType { get; set; }
        public long Fkey { get; set; }
        public double AmountOverride { get; set; }
        public DateTime SecDateTentry { get; set; }
    }
}
