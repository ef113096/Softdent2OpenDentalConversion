using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Commoptout
    {
        public long CommOptOutNum { get; set; }
        public long PatNum { get; set; }
        public sbyte CommType { get; set; }
        public sbyte CommMode { get; set; }
    }
}
