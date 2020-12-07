using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Eduresource
    {
        public long EduResourceNum { get; set; }
        public long DiseaseDefNum { get; set; }
        public long MedicationNum { get; set; }
        public string LabResultId { get; set; }
        public string LabResultName { get; set; }
        public string LabResultCompare { get; set; }
        public string ResourceUrl { get; set; }
        public string SmokingSnoMed { get; set; }
    }
}
