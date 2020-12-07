using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Fhircontactpoint
    {
        public long FhircontactPointNum { get; set; }
        public long FhirsubscriptionNum { get; set; }
        public sbyte ContactSystem { get; set; }
        public string ContactValue { get; set; }
        public sbyte ContactUse { get; set; }
        public int ItemOrder { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
