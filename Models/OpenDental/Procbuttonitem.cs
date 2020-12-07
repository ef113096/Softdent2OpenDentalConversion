using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procbuttonitem
    {
        public long ProcButtonItemNum { get; set; }
        public long ProcButtonNum { get; set; }
        public string OldCode { get; set; }
        public long AutoCodeNum { get; set; }
        public long CodeNum { get; set; }
        public long ItemOrder { get; set; }
    }
}
