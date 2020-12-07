using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Reactivation
    {
        public long ReactivationNum { get; set; }
        public long PatNum { get; set; }
        public long ReactivationStatus { get; set; }
        public string ReactivationNote { get; set; }
        public sbyte DoNotContact { get; set; }
    }
}
