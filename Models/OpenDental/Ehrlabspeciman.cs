using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabspeciman
    {
        public long EhrLabSpecimenNum { get; set; }
        public long EhrLabNum { get; set; }
        public long SetIdSpm { get; set; }
        public string SpecimenTypeId { get; set; }
        public string SpecimenTypeText { get; set; }
        public string SpecimenTypeCodeSystemName { get; set; }
        public string SpecimenTypeIdalt { get; set; }
        public string SpecimenTypeTextAlt { get; set; }
        public string SpecimenTypeCodeSystemNameAlt { get; set; }
        public string SpecimenTypeTextOriginal { get; set; }
        public string CollectionDateTimeStart { get; set; }
        public string CollectionDateTimeEnd { get; set; }
    }
}
