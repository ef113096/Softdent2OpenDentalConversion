using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payment
    {
        public long PayNum { get; set; }
        public long PayType { get; set; }
        public DateTime PayDate { get; set; }
        public double PayAmt { get; set; }
        public string CheckNum { get; set; }
        public string BankBranch { get; set; }
        public string PayNote { get; set; }
        public byte IsSplit { get; set; }
        public long PatNum { get; set; }
        public long ClinicNum { get; set; }
        public DateTime DateEntry { get; set; }
        public long DepositNum { get; set; }
        public string Receipt { get; set; }
        public sbyte IsRecurringCc { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public sbyte PaymentSource { get; set; }
        public sbyte ProcessStatus { get; set; }
        public DateTime RecurringChargeDate { get; set; }
        public string ExternalId { get; set; }
        public sbyte PaymentStatus { get; set; }
    }
}
