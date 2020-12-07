using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orionproc
    {
        public long OrionProcNum { get; set; }
        public long ProcNum { get; set; }
        public sbyte Dpc { get; set; }
        public DateTime DateScheduleBy { get; set; }
        public DateTime DateStopClock { get; set; }
        public int Status2 { get; set; }
        public sbyte IsOnCall { get; set; }
        public sbyte IsEffectiveComm { get; set; }
        public sbyte IsRepair { get; set; }
        public sbyte Dpcpost { get; set; }
    }
}
