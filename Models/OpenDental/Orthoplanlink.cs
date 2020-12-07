using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthoplanlink
    {
        public long OrthoPlanLinkNum { get; set; }
        public long OrthoCaseNum { get; set; }
        public sbyte LinkType { get; set; }
        public long Fkey { get; set; }
        public sbyte IsActive { get; set; }
        public DateTime SecDateTentry { get; set; }
        public long SecUserNumEntry { get; set; }
    }
}
