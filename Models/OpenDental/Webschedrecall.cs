using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Webschedrecall
    {
        public long WebSchedRecallNum { get; set; }
        public long ClinicNum { get; set; }
        public long PatNum { get; set; }
        public long RecallNum { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public DateTime DateDue { get; set; }
        public int ReminderCount { get; set; }
        public sbyte PreferRecallMethod { get; set; }
        public DateTime DateTimeReminderSent { get; set; }
        public DateTime DateTimeSendFailed { get; set; }
        public sbyte EmailSendStatus { get; set; }
        public sbyte SmsSendStatus { get; set; }
        public string PhonePat { get; set; }
        public string EmailPat { get; set; }
        public string MsgTextToMobileTemplate { get; set; }
        public string MsgTextToMobile { get; set; }
        public string EmailSubjTemplate { get; set; }
        public string EmailSubj { get; set; }
        public string EmailTextTemplate { get; set; }
        public string EmailText { get; set; }
        public string GuidMessageToMobile { get; set; }
        public string ShortGuidsms { get; set; }
        public string ShortGuidemail { get; set; }
        public string ResponseDescript { get; set; }
        public sbyte Source { get; set; }
    }
}
