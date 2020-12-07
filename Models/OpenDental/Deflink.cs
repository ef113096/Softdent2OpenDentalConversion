using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Deflink
    {
        public long DefLinkNum { get; set; }
        public long DefNum { get; set; }
        public long Fkey { get; set; }
        public sbyte LinkType { get; set; }
    }
}
