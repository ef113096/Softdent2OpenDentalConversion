using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Toothinitial
    {
        public long ToothInitialNum { get; set; }
        public long PatNum { get; set; }
        public string ToothNum { get; set; }
        public byte InitialType { get; set; }
        public float Movement { get; set; }
        public string DrawingSegment { get; set; }
        public int ColorDraw { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
