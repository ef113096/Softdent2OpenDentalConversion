using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimattach
    {
        public long ClaimAttachNum { get; set; }
        public long ClaimNum { get; set; }
        public string DisplayedFileName { get; set; }
        public string ActualFileName { get; set; }
    }
}
