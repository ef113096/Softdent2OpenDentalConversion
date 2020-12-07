using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Cpt
    {
        public long CptNum { get; set; }
        public string CptCode { get; set; }
        public string Description { get; set; }
        public string VersionIds { get; set; }
    }
}
