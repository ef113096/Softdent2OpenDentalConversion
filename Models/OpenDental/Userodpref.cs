using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Userodpref
    {
        public long UserOdPrefNum { get; set; }
        public long UserNum { get; set; }
        public long Fkey { get; set; }
        public sbyte FkeyType { get; set; }
        public string ValueString { get; set; }
        public long ClinicNum { get; set; }
    }
}
