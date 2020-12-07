using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Feesched
    {
        public long FeeSchedNum { get; set; }
        public string Description { get; set; }
        public int FeeSchedType { get; set; }
        public int ItemOrder { get; set; }
        public bool IsHidden { get; set; }
        public sbyte IsGlobal { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
