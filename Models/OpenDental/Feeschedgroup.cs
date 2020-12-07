using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Feeschedgroup
    {
        public long FeeSchedGroupNum { get; set; }
        public string Description { get; set; }
        public long FeeSchedNum { get; set; }
        public string ClinicNums { get; set; }
    }
}
