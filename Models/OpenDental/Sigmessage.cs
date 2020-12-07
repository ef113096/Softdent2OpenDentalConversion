using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Sigmessage
    {
        public long SigMessageNum { get; set; }
        public string ButtonText { get; set; }
        public int ButtonIndex { get; set; }
        public byte SynchIcon { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public DateTime MessageDateTime { get; set; }
        public DateTime AckDateTime { get; set; }
        public string SigText { get; set; }
        public long SigElementDefNumUser { get; set; }
        public long SigElementDefNumExtra { get; set; }
        public long SigElementDefNumMsg { get; set; }
    }
}
