using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabclinicalinfo
    {
        public long EhrLabClinicalInfoNum { get; set; }
        public long EhrLabNum { get; set; }
        public string ClinicalInfoId { get; set; }
        public string ClinicalInfoText { get; set; }
        public string ClinicalInfoCodeSystemName { get; set; }
        public string ClinicalInfoIdalt { get; set; }
        public string ClinicalInfoTextAlt { get; set; }
        public string ClinicalInfoCodeSystemNameAlt { get; set; }
        public string ClinicalInfoTextOriginal { get; set; }
    }
}
