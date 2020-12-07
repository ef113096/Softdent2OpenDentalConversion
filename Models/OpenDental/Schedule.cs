using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Schedule
    {
        public long ScheduleNum { get; set; }
        public DateTime SchedDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan StopTime { get; set; }
        public byte SchedType { get; set; }
        public long ProvNum { get; set; }
        public long BlockoutType { get; set; }
        public string Note { get; set; }
        public byte Status { get; set; }
        public long EmployeeNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public long ClinicNum { get; set; }
    }
}
