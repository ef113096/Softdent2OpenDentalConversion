using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Supplyneeded
    {
        public long SupplyNeededNum { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
