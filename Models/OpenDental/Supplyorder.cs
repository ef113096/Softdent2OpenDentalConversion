using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Supplyorder
    {
        public long SupplyOrderNum { get; set; }
        public long SupplierNum { get; set; }
        public DateTime DatePlaced { get; set; }
        public string Note { get; set; }
        public double AmountTotal { get; set; }
        public long UserNum { get; set; }
        public double ShippingCharge { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
