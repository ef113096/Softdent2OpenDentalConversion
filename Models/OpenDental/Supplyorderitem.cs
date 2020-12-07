using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Supplyorderitem
    {
        public long SupplyOrderItemNum { get; set; }
        public long SupplyOrderNum { get; set; }
        public long SupplyNum { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
    }
}
