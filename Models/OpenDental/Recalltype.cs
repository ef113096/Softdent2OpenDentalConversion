using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Recalltype
    {
        public long RecallTypeNum { get; set; }
        public string Description { get; set; }
        public int DefaultInterval { get; set; }
        public string TimePattern { get; set; }
        public string Procedures { get; set; }
        public sbyte AppendToSpecial { get; set; }
    }
}
