using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Appointmentrule
    {
        public long AppointmentRuleNum { get; set; }
        public string RuleDesc { get; set; }
        public string CodeStart { get; set; }
        public string CodeEnd { get; set; }
        public byte IsEnabled { get; set; }
    }
}
