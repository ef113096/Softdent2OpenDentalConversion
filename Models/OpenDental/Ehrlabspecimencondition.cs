using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabspecimencondition
    {
        public long EhrLabSpecimenConditionNum { get; set; }
        public long EhrLabSpecimenNum { get; set; }
        public string SpecimenConditionId { get; set; }
        public string SpecimenConditionText { get; set; }
        public string SpecimenConditionCodeSystemName { get; set; }
        public string SpecimenConditionIdalt { get; set; }
        public string SpecimenConditionTextAlt { get; set; }
        public string SpecimenConditionCodeSystemNameAlt { get; set; }
        public string SpecimenConditionTextOriginal { get; set; }
    }
}
