using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Confirmationrequest
    {
        public long ConfirmationRequestNum { get; set; }
        public long ClinicNum { get; set; }
        public sbyte IsForSms { get; set; }
        public sbyte IsForEmail { get; set; }
        public long PatNum { get; set; }
        public long ApptNum { get; set; }
        public string PhonePat { get; set; }
        public DateTime DateTimeConfirmExpire { get; set; }
        public int SecondsFromEntryToExpire { get; set; }
        public string ShortGuid { get; set; }
        public string ConfirmCode { get; set; }
        public string MsgTextToMobileTemplate { get; set; }
        public string MsgTextToMobile { get; set; }
        public string EmailSubjTemplate { get; set; }
        public string EmailSubj { get; set; }
        public string EmailTextTemplate { get; set; }
        public string EmailText { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public DateTime DateTimeConfirmTransmit { get; set; }
        public DateTime DateTimeRsvp { get; set; }
        public sbyte Rsvpstatus { get; set; }
        public string ResponseDescript { get; set; }
        public string GuidMessageToMobile { get; set; }
        public string GuidMessageFromMobile { get; set; }
        public string ShortGuidEmail { get; set; }
        public DateTime AptDateTimeOrig { get; set; }
        public long Tsprior { get; set; }
        public sbyte DoNotResend { get; set; }
        public sbyte SmsSentOk { get; set; }
        public sbyte EmailSentOk { get; set; }
        public long ApptReminderRuleNum { get; set; }
    }
}
