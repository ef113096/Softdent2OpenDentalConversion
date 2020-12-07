using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Treatplanattach
    {
        public long TreatPlanAttachNum { get; set; }
        public long TreatPlanNum { get; set; }
        public long ProcNum { get; set; }
        public long Priority { get; set; }
    }
}
