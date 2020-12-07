using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Sigelementdef
    {
        public long SigElementDefNum { get; set; }
        public byte LightRow { get; set; }
        public int LightColor { get; set; }
        public byte SigElementType { get; set; }
        public string SigText { get; set; }
        public string Sound { get; set; }
        public short ItemOrder { get; set; }
    }
}
