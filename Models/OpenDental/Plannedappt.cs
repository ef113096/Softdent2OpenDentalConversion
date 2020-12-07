using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Plannedappt
    {
        public long PlannedApptNum { get; set; }
        public long PatNum { get; set; }
        public long AptNum { get; set; }
        public int ItemOrder { get; set; }
    }
}
