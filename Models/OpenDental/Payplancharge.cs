using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payplancharge
    {
        public long PayPlanChargeNum { get; set; }
        public long PayPlanNum { get; set; }
        public long Guarantor { get; set; }
        public long PatNum { get; set; }
        public DateTime ChargeDate { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public string Note { get; set; }
        public long ProvNum { get; set; }
        public long ClinicNum { get; set; }
        public sbyte ChargeType { get; set; }
        public long ProcNum { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public long StatementNum { get; set; }
        public long Fkey { get; set; }
        public sbyte LinkType { get; set; }
    }
}
