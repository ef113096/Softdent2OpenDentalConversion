using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimpayment
    {
        public long ClaimPaymentNum { get; set; }
        public DateTime CheckDate { get; set; }
        public double CheckAmt { get; set; }
        public string CheckNum { get; set; }
        public string BankBranch { get; set; }
        public string Note { get; set; }
        public long ClinicNum { get; set; }
        public long DepositNum { get; set; }
        public string CarrierName { get; set; }
        public DateTime DateIssued { get; set; }
        public sbyte IsPartial { get; set; }
        public long PayType { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public long PayGroup { get; set; }
    }
}
