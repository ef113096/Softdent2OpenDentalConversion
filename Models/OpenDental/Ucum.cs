using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ucum
    {
        public long UcumNum { get; set; }
        public string UcumCode { get; set; }
        public string Description { get; set; }
        public sbyte IsInUse { get; set; }
    }
}
