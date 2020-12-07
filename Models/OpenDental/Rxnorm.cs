using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Rxnorm
    {
        public long RxNormNum { get; set; }
        public string RxCui { get; set; }
        public string MmslCode { get; set; }
        public string Description { get; set; }
    }
}
