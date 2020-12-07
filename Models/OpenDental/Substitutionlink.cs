using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Substitutionlink
    {
        public long SubstitutionLinkNum { get; set; }
        public long PlanNum { get; set; }
        public long CodeNum { get; set; }
        public string SubstitutionCode { get; set; }
        public int SubstOnlyIf { get; set; }
    }
}
