using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Oidexternal
    {
        public long OidexternalNum { get; set; }
        public string Idtype { get; set; }
        public long Idinternal { get; set; }
        public string Idexternal { get; set; }
        public string RootExternal { get; set; }
    }
}
