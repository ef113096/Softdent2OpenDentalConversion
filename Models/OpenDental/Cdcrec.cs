using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Cdcrec
    {
        public long CdcrecNum { get; set; }
        public string CdcrecCode { get; set; }
        public string HeirarchicalCode { get; set; }
        public string Description { get; set; }
    }
}
