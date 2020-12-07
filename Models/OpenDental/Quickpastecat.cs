using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Quickpastecat
    {
        public long QuickPasteCatNum { get; set; }
        public string Description { get; set; }
        public ushort ItemOrder { get; set; }
        public string DefaultForTypes { get; set; }
    }
}
