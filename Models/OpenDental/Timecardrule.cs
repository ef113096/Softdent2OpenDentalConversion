using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Timecardrule
    {
        public long TimeCardRuleNum { get; set; }
        public long EmployeeNum { get; set; }
        public TimeSpan OverHoursPerDay { get; set; }
        public TimeSpan AfterTimeOfDay { get; set; }
        public TimeSpan BeforeTimeOfDay { get; set; }
        public sbyte IsOvertimeExempt { get; set; }
        public TimeSpan MinClockInTime { get; set; }
    }
}
