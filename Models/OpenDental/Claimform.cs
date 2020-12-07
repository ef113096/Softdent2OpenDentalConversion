using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimform
    {
        public long ClaimFormNum { get; set; }
        public string Description { get; set; }
        public byte IsHidden { get; set; }
        public string FontName { get; set; }
        public float FontSize { get; set; }
        public string UniqueId { get; set; }
        public byte PrintImages { get; set; }
        public short OffsetX { get; set; }
        public short OffsetY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
