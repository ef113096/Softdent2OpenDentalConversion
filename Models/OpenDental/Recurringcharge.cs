using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Recurringcharge
    {
        public long RecurringChargeNum { get; set; }
        public long PatNum { get; set; }
        public long ClinicNum { get; set; }
        public DateTime DateTimeCharge { get; set; }
        public sbyte ChargeStatus { get; set; }
        public double FamBal { get; set; }
        public double PayPlanDue { get; set; }
        public double TotalDue { get; set; }
        public double RepeatAmt { get; set; }
        public double ChargeAmt { get; set; }
        public long UserNum { get; set; }
        public long PayNum { get; set; }
        public long CreditCardNum { get; set; }
        public string ErrorMsg { get; set; }
    }
}
