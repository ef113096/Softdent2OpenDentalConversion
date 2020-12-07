using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anesthmedsintake
    {
        public int AnestheticMedNum { get; set; }
        public DateTime IntakeDate { get; set; }
        public string AnesthMedName { get; set; }
        public int Qty { get; set; }
        public string SupplierIdnum { get; set; }
        public string InvoiceNum { get; set; }
    }
}
