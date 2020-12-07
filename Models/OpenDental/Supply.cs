using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Supply
    {
        public long SupplyNum { get; set; }
        public long SupplierNum { get; set; }
        public string CatalogNumber { get; set; }
        public string Descript { get; set; }
        public long Category { get; set; }
        public int ItemOrder { get; set; }
        public float LevelDesired { get; set; }
        public bool IsHidden { get; set; }
        public double Price { get; set; }
        public string BarCodeOrId { get; set; }
        public float DispDefaultQuant { get; set; }
        public int DispUnitsCount { get; set; }
        public string DispUnitDesc { get; set; }
        public float LevelOnHand { get; set; }
        public int OrderQty { get; set; }
    }
}
