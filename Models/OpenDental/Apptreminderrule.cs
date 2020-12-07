using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptreminderrule
    {
        public long ApptReminderRuleNum { get; set; }
        public sbyte TypeCur { get; set; }
        public long Tsprior { get; set; }
        public string SendOrder { get; set; }
        public sbyte IsSendAll { get; set; }
        public string TemplateSms { get; set; }
        public string TemplateEmailSubject { get; set; }
        public string TemplateEmail { get; set; }
        public long ClinicNum { get; set; }
        public string TemplateSmsaggShared { get; set; }
        public string TemplateSmsaggPerAppt { get; set; }
        public string TemplateEmailSubjAggShared { get; set; }
        public string TemplateEmailAggShared { get; set; }
        public string TemplateEmailAggPerAppt { get; set; }
        public long DoNotSendWithin { get; set; }
        public sbyte IsEnabled { get; set; }
        public string TemplateAutoReply { get; set; }
        public string TemplateAutoReplyAgg { get; set; }
        public sbyte IsAutoReplyEnabled { get; set; }
        public string Language { get; set; }
        public string TemplateComeInMessage { get; set; }
        public string EmailTemplateType { get; set; }
        public string AggEmailTemplateType { get; set; }
    }
}
