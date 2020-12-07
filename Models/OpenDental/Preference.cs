using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Preference
    {
        public string PrefName { get; set; }
        public string ValueString { get; set; }
        public long PrefNum { get; set; }
        public string Comments { get; set; }
    }
}
