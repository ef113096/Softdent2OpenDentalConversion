using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Asapcomm
    {
        public long AsapCommNum { get; set; }
        public long Fkey { get; set; }
        public sbyte FkeyType { get; set; }
        public long ScheduleNum { get; set; }
        public long PatNum { get; set; }
        public long ClinicNum { get; set; }
        public string ShortGuid { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public DateTime DateTimeExpire { get; set; }
        public DateTime DateTimeSmsScheduled { get; set; }
        public sbyte SmsSendStatus { get; set; }
        public sbyte EmailSendStatus { get; set; }
        public DateTime DateTimeSmsSent { get; set; }
        public DateTime DateTimeEmailSent { get; set; }
        public long EmailMessageNum { get; set; }
        public sbyte ResponseStatus { get; set; }
        public DateTime DateTimeOrig { get; set; }
        public string TemplateText { get; set; }
        public string TemplateEmail { get; set; }
        public string TemplateEmailSubj { get; set; }
        public string Note { get; set; }
        public string GuidMessageToMobile { get; set; }
        public string EmailTemplateType { get; set; }
    }
}
