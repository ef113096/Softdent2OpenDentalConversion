using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptthankyousent
    {
        public long ApptThankYouSentNum { get; set; }
        public long ApptNum { get; set; }
        public DateTime ApptDateTime { get; set; }
        public DateTime ApptSecDateTentry { get; set; }
        public long Tsprior { get; set; }
        public long ApptReminderRuleNum { get; set; }
        public sbyte IsForSms { get; set; }
        public sbyte IsForEmail { get; set; }
        public long ClinicNum { get; set; }
        public long PatNum { get; set; }
        public string PhonePat { get; set; }
        public string ResponseDescript { get; set; }
        public string GuidMessageToMobile { get; set; }
        public string MsgTextToMobileTemplate { get; set; }
        public string MsgTextToMobile { get; set; }
        public string EmailSubjTemplate { get; set; }
        public string EmailSubj { get; set; }
        public string EmailTextTemplate { get; set; }
        public string EmailText { get; set; }
        public DateTime DateTimeThankYouTransmit { get; set; }
        public string ShortGuidEmail { get; set; }
        public string ShortGuid { get; set; }
        public sbyte SmsSentStatus { get; set; }
        public sbyte EmailSentStatus { get; set; }
        public sbyte DoNotResend { get; set; }
    }
}
