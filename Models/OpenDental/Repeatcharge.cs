using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Repeatcharge
    {
        public long RepeatChargeNum { get; set; }
        public long PatNum { get; set; }
        public string ProcCode { get; set; }
        public double ChargeAmt { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string Note { get; set; }
        public sbyte CopyNoteToProc { get; set; }
        public sbyte CreatesClaim { get; set; }
        public sbyte IsEnabled { get; set; }
        public sbyte UsePrepay { get; set; }
        public string Npi { get; set; }
        public string ErxAccountId { get; set; }
        public string ProviderName { get; set; }
        public double ChargeAmtAlt { get; set; }
        public string UnearnedTypes { get; set; }
    }
}
