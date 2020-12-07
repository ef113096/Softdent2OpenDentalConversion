using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Guardian
    {
        public long GuardianNum { get; set; }
        public long PatNumChild { get; set; }
        public long PatNumGuardian { get; set; }
        public sbyte Relationship { get; set; }
        public sbyte IsGuardian { get; set; }
    }
}
