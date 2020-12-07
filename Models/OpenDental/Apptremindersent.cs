using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptremindersent
    {
        public long ApptReminderSentNum { get; set; }
        public long ApptNum { get; set; }
        public DateTime ApptDateTime { get; set; }
        public DateTime DateTimeSent { get; set; }
        public long Tsprior { get; set; }
        public long ApptReminderRuleNum { get; set; }
        public sbyte IsSmsSent { get; set; }
        public sbyte IsEmailSent { get; set; }
    }
}
