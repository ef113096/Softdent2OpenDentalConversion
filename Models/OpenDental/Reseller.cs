using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Reseller
    {
        public long ResellerNum { get; set; }
        public long PatNum { get; set; }
        public string UserName { get; set; }
        public string ResellerPassword { get; set; }
        public long BillingType { get; set; }
        public int VotesAllotted { get; set; }
        public string Note { get; set; }
    }
}
