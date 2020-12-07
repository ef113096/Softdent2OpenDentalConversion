using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patrestriction
    {
        public long PatRestrictionNum { get; set; }
        public long PatNum { get; set; }
        public sbyte PatRestrictType { get; set; }
    }
}
