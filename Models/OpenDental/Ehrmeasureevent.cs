using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrmeasureevent
    {
        public long EhrMeasureEventNum { get; set; }
        public DateTime DateTevent { get; set; }
        public sbyte EventType { get; set; }
        public long PatNum { get; set; }
        public string MoreInfo { get; set; }
        public string CodeValueEvent { get; set; }
        public string CodeSystemEvent { get; set; }
        public string CodeValueResult { get; set; }
        public string CodeSystemResult { get; set; }
        public long Fkey { get; set; }
        public byte TobaccoCessationDesire { get; set; }
        public DateTime DateStartTobacco { get; set; }
    }
}
