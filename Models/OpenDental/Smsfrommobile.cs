using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Smsfrommobile
    {
        public long SmsFromMobileNum { get; set; }
        public long PatNum { get; set; }
        public long ClinicNum { get; set; }
        public long CommlogNum { get; set; }
        public string MsgText { get; set; }
        public DateTime DateTimeReceived { get; set; }
        public string SmsPhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public int MsgPart { get; set; }
        public int MsgTotal { get; set; }
        public string MsgRefId { get; set; }
        public sbyte SmsStatus { get; set; }
        public string Flags { get; set; }
        public sbyte IsHidden { get; set; }
        public int MatchCount { get; set; }
        public string GuidMessage { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
