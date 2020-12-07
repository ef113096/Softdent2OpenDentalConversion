using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Icd10
    {
        public long Icd10Num { get; set; }
        public string Icd10Code { get; set; }
        public string Description { get; set; }
        public string IsCode { get; set; }
    }
}
