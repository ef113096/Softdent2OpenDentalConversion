using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthoschedule
    {
        public long OrthoScheduleNum { get; set; }
        public DateTime BandingDateOverride { get; set; }
        public DateTime DebondDateOverride { get; set; }
        public double BandingAmount { get; set; }
        public double VisitAmount { get; set; }
        public double DebondAmount { get; set; }
        public sbyte IsActive { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
