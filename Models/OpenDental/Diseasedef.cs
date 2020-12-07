using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Diseasedef
    {
        public long DiseaseDefNum { get; set; }
        public string DiseaseName { get; set; }
        public ushort ItemOrder { get; set; }
        public byte IsHidden { get; set; }
        public DateTime DateTstamp { get; set; }
        public string Icd9code { get; set; }
        public string SnomedCode { get; set; }
        public string Icd10Code { get; set; }
    }
}
