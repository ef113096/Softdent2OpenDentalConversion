using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Clockevent
    {
        public long ClockEventNum { get; set; }
        public long EmployeeNum { get; set; }
        public DateTime TimeEntered1 { get; set; }
        public DateTime TimeDisplayed1 { get; set; }
        public byte ClockStatus { get; set; }
        public string Note { get; set; }
        public DateTime TimeEntered2 { get; set; }
        public DateTime TimeDisplayed2 { get; set; }
        public TimeSpan OtimeHours { get; set; }
        public TimeSpan OtimeAuto { get; set; }
        public TimeSpan Adjust { get; set; }
        public TimeSpan AdjustAuto { get; set; }
        public sbyte AdjustIsOverridden { get; set; }
        public TimeSpan Rate2Hours { get; set; }
        public TimeSpan Rate2Auto { get; set; }
        public long ClinicNum { get; set; }
    }
}
