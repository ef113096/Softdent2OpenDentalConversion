using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Dispsupply
    {
        public long DispSupplyNum { get; set; }
        public long SupplyNum { get; set; }
        public long ProvNum { get; set; }
        public DateTime DateDispensed { get; set; }
        public float DispQuantity { get; set; }
        public string Note { get; set; }
    }
}
