using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payplan
    {
        public long PayPlanNum { get; set; }
        public long PatNum { get; set; }
        public long Guarantor { get; set; }
        public DateTime PayPlanDate { get; set; }
        public double Apr { get; set; }
        public string Note { get; set; }
        public long PlanNum { get; set; }
        public double CompletedAmt { get; set; }
        public long InsSubNum { get; set; }
        public sbyte PaySchedule { get; set; }
        public int NumberOfPayments { get; set; }
        public double PayAmt { get; set; }
        public double DownPayment { get; set; }
        public sbyte IsClosed { get; set; }
        public string Signature { get; set; }
        public sbyte SigIsTopaz { get; set; }
        public long PlanCategory { get; set; }
        public sbyte IsDynamic { get; set; }
        public sbyte ChargeFrequency { get; set; }
        public DateTime DatePayPlanStart { get; set; }
        public sbyte IsLocked { get; set; }
        public DateTime DateInterestStart { get; set; }
    }
}
