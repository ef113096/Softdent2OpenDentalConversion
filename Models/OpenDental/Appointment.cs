using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Appointment
    {
        public long AptNum { get; set; }
        public long PatNum { get; set; }
        public byte AptStatus { get; set; }
        public string Pattern { get; set; }
        public long Confirmed { get; set; }
        public bool TimeLocked { get; set; }
        public long Op { get; set; }
        public string Note { get; set; }
        public long ProvNum { get; set; }
        public long ProvHyg { get; set; }
        public DateTime AptDateTime { get; set; }
        public long NextAptNum { get; set; }
        public long UnschedStatus { get; set; }
        public byte IsNewPatient { get; set; }
        public string ProcDescript { get; set; }
        public long Assistant { get; set; }
        public long ClinicNum { get; set; }
        public byte IsHygiene { get; set; }
        public DateTime DateTstamp { get; set; }
        public DateTime DateTimeArrived { get; set; }
        public DateTime DateTimeSeated { get; set; }
        public DateTime DateTimeDismissed { get; set; }
        public long InsPlan1 { get; set; }
        public long InsPlan2 { get; set; }
        public DateTime DateTimeAskedToArrive { get; set; }
        public string ProcsColored { get; set; }
        public int ColorOverride { get; set; }
        public long AppointmentTypeNum { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateTentry { get; set; }
        public sbyte Priority { get; set; }
        public string ProvBarText { get; set; }
        public string PatternSecondary { get; set; }
    }
}
