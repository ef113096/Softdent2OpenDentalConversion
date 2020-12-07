using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Autocodeitem
    {
        public long AutoCodeItemNum { get; set; }
        public long AutoCodeNum { get; set; }
        public string OldCode { get; set; }
        public long CodeNum { get; set; }
    }
}
