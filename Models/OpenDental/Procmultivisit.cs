using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procmultivisit
    {
        public long ProcMultiVisitNum { get; set; }
        public long GroupProcMultiVisitNum { get; set; }
        public long ProcNum { get; set; }
        public sbyte ProcStatus { get; set; }
        public sbyte IsInProcess { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
