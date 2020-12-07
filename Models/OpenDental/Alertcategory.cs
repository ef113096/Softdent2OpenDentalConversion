using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Alertcategory
    {
        public long AlertCategoryNum { get; set; }
        public sbyte IsHqcategory { get; set; }
        public string InternalName { get; set; }
        public string Description { get; set; }
    }
}
