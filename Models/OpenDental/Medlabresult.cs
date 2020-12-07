using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medlabresult
    {
        public long MedLabResultNum { get; set; }
        public long MedLabNum { get; set; }
        public string ObsId { get; set; }
        public string ObsText { get; set; }
        public string ObsLoinc { get; set; }
        public string ObsLoincText { get; set; }
        public string ObsIdsub { get; set; }
        public string ObsValue { get; set; }
        public string ObsSubType { get; set; }
        public string ObsUnits { get; set; }
        public string ReferenceRange { get; set; }
        public string AbnormalFlag { get; set; }
        public string ResultStatus { get; set; }
        public DateTime DateTimeObs { get; set; }
        public string FacilityId { get; set; }
        public long DocNum { get; set; }
        public string Note { get; set; }
    }
}
