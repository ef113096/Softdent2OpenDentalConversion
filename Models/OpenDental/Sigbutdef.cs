using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Sigbutdef
    {
        public long SigButDefNum { get; set; }
        public string ButtonText { get; set; }
        public short ButtonIndex { get; set; }
        public byte SynchIcon { get; set; }
        public string ComputerName { get; set; }
        public long SigElementDefNumUser { get; set; }
        public long SigElementDefNumExtra { get; set; }
        public long SigElementDefNumMsg { get; set; }
    }
}
