using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.Softdent
{
    public partial class SdRefRpt
    {
        public int RefDrId { get; set; }
        public int PatId { get; set; }
        public string RefDate { get; set; }
        public bool Converted { get; set; }
    }
}
