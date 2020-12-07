using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Paysplit
    {
        public long SplitNum { get; set; }
        public double SplitAmt { get; set; }
        public long PatNum { get; set; }
        public DateTime ProcDate { get; set; }
        public long PayNum { get; set; }
        public byte IsDiscount { get; set; }
        public byte DiscountType { get; set; }
        public long ProvNum { get; set; }
        public long PayPlanNum { get; set; }
        public DateTime DatePay { get; set; }
        public long ProcNum { get; set; }
        public DateTime DateEntry { get; set; }
        public long UnearnedType { get; set; }
        public long ClinicNum { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public long FsplitNum { get; set; }
        public long AdjNum { get; set; }
        public long PayPlanChargeNum { get; set; }
    }
}
