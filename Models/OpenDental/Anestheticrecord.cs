using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anestheticrecord
    {
        public int AnestheticRecordNum { get; set; }
        public int PatNum { get; set; }
        public DateTime AnestheticDate { get; set; }
        public short ProvNum { get; set; }
    }
}
