using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Discountplan
    {
        public long DiscountPlanNum { get; set; }
        public string Description { get; set; }
        public long FeeSchedNum { get; set; }
        public long DefNum { get; set; }
        public sbyte IsHidden { get; set; }
    }
}
