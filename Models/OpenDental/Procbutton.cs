using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procbutton
    {
        public long ProcButtonNum { get; set; }
        public string Description { get; set; }
        public ushort ItemOrder { get; set; }
        public long Category { get; set; }
        public string ButtonImage { get; set; }
        public sbyte IsMultiVisit { get; set; }
    }
}
