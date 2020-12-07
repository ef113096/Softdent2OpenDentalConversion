using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Etrans835attach
    {
        public long Etrans835AttachNum { get; set; }
        public long EtransNum { get; set; }
        public long ClaimNum { get; set; }
        public int ClpSegmentIndex { get; set; }
        public DateTime DateTimeEntry { get; set; }
    }
}
