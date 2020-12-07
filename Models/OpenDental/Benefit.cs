using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Benefit
    {
        public long BenefitNum { get; set; }
        public long PlanNum { get; set; }
        public long PatPlanNum { get; set; }
        public long CovCatNum { get; set; }
        public byte BenefitType { get; set; }
        public sbyte Percent { get; set; }
        public double MonetaryAmt { get; set; }
        public byte TimePeriod { get; set; }
        public byte QuantityQualifier { get; set; }
        public byte Quantity { get; set; }
        public long CodeNum { get; set; }
        public int CoverageLevel { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
