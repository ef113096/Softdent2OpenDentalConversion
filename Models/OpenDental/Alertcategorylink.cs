using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Alertcategorylink
    {
        public long AlertCategoryLinkNum { get; set; }
        public long AlertCategoryNum { get; set; }
        public sbyte AlertType { get; set; }
    }
}
