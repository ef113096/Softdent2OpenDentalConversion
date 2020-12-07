using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Account
    {
        public long AccountNum { get; set; }
        public string Description { get; set; }
        public byte AcctType { get; set; }
        public string BankNumber { get; set; }
        public byte Inactive { get; set; }
        public int AccountColor { get; set; }
    }
}
