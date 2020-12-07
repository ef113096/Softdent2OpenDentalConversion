using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Installmentplan
    {
        public long InstallmentPlanNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateAgreement { get; set; }
        public DateTime DateFirstPayment { get; set; }
        public double MonthlyPayment { get; set; }
        public float Apr { get; set; }
        public string Note { get; set; }
    }
}
