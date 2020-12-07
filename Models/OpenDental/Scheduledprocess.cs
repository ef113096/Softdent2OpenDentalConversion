using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Scheduledprocess
    {
        public long ScheduledProcessNum { get; set; }
        public string ScheduledAction { get; set; }
        public DateTime TimeToRun { get; set; }
        public string FrequencyToRun { get; set; }
        public DateTime LastRanDateTime { get; set; }
    }
}
