using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Alertsub
    {
        public long AlertSubNum { get; set; }
        public long UserNum { get; set; }
        public long ClinicNum { get; set; }
        public sbyte Type { get; set; }
        public long AlertCategoryNum { get; set; }
    }
}
