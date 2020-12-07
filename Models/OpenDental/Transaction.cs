using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Transaction
    {
        public long TransactionNum { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public long UserNum { get; set; }
        public long DepositNum { get; set; }
        public long PayNum { get; set; }
        public long SecUserNumEdit { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
