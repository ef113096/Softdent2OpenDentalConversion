using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrcareplan
    {
        public long EhrCarePlanNum { get; set; }
        public long PatNum { get; set; }
        public string SnomedEducation { get; set; }
        public string Instructions { get; set; }
        public DateTime DatePlanned { get; set; }
    }
}
