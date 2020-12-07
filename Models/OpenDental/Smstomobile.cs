using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Smstomobile
    {
        public long SmsToMobileNum { get; set; }
        public long PatNum { get; set; }
        public string GuidMessage { get; set; }
        public string GuidBatch { get; set; }
        public string SmsPhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public sbyte IsTimeSensitive { get; set; }
        public sbyte MsgType { get; set; }
        public string MsgText { get; set; }
        public sbyte SmsStatus { get; set; }
        public int MsgParts { get; set; }
        public float MsgChargeUsd { get; set; }
        public long ClinicNum { get; set; }
        public string CustErrorText { get; set; }
        public DateTime DateTimeSent { get; set; }
        public DateTime DateTimeTerminated { get; set; }
        public sbyte IsHidden { get; set; }
        public float MsgDiscountUsd { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
