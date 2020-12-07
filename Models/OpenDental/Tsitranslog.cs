using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Tsitranslog
    {
        public long TsiTransLogNum { get; set; }
        public long PatNum { get; set; }
        public long UserNum { get; set; }
        public sbyte TransType { get; set; }
        public DateTime TransDateTime { get; set; }
        public sbyte DemandType { get; set; }
        public sbyte ServiceCode { get; set; }
        public double TransAmt { get; set; }
        public double AccountBalance { get; set; }
        public sbyte FkeyType { get; set; }
        public long Fkey { get; set; }
        public string RawMsgText { get; set; }
        public string ClientId { get; set; }
        public string TransJson { get; set; }
        public long ClinicNum { get; set; }
        public long AggTransLogNum { get; set; }
    }
}
