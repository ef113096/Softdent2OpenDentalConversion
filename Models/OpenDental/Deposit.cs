using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Deposit
    {
        public long DepositNum { get; set; }
        public DateTime DateDeposit { get; set; }
        public string BankAccountInfo { get; set; }
        public double Amount { get; set; }
        public string Memo { get; set; }
        public string Batch { get; set; }
        public long DepositAccountNum { get; set; }
    }
}
