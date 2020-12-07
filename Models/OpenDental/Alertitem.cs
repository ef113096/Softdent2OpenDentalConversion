using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Alertitem
    {
        public long AlertItemNum { get; set; }
        public long ClinicNum { get; set; }
        public string Description { get; set; }
        public sbyte Type { get; set; }
        public sbyte Severity { get; set; }
        public sbyte Actions { get; set; }
        public sbyte FormToOpen { get; set; }
        public long Fkey { get; set; }
        public string ItemValue { get; set; }
        public long UserNum { get; set; }
    }
}
