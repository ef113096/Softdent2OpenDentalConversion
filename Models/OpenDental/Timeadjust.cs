using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Timeadjust
    {
        public long TimeAdjustNum { get; set; }
        public long EmployeeNum { get; set; }
        public DateTime TimeEntry { get; set; }
        public TimeSpan RegHours { get; set; }
        public TimeSpan OtimeHours { get; set; }
        public string Note { get; set; }
        public sbyte IsAuto { get; set; }
        public long ClinicNum { get; set; }
        public long PtoDefNum { get; set; }
        public TimeSpan PtoHours { get; set; }
    }
}
