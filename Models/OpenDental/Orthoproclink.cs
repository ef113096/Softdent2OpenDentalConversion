using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthoproclink
    {
        public long OrthoProcLinkNum { get; set; }
        public long OrthoCaseNum { get; set; }
        public long ProcNum { get; set; }
        public DateTime SecDateTentry { get; set; }
        public long SecUserNumEntry { get; set; }
        public sbyte ProcLinkType { get; set; }
    }
}
