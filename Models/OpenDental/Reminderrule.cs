using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Reminderrule
    {
        public long ReminderRuleNum { get; set; }
        public sbyte ReminderCriterion { get; set; }
        public long CriterionFk { get; set; }
        public string CriterionValue { get; set; }
        public string Message { get; set; }
    }
}
