using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrtrigger
    {
        public long EhrTriggerNum { get; set; }
        public string Description { get; set; }
        public string ProblemSnomedList { get; set; }
        public string ProblemIcd9List { get; set; }
        public string ProblemIcd10List { get; set; }
        public string ProblemDefNumList { get; set; }
        public string MedicationNumList { get; set; }
        public string RxCuiList { get; set; }
        public string CvxList { get; set; }
        public string AllergyDefNumList { get; set; }
        public string DemographicsList { get; set; }
        public string LabLoincList { get; set; }
        public string VitalLoincList { get; set; }
        public string Instructions { get; set; }
        public string Bibliography { get; set; }
        public sbyte Cardinality { get; set; }
    }
}
