using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patientnote
    {
        public long PatNum { get; set; }
        public string FamFinancial { get; set; }
        public string ApptPhone { get; set; }
        public string Medical { get; set; }
        public string Service { get; set; }
        public string MedicalComp { get; set; }
        public string Treatment { get; set; }
        public string Icename { get; set; }
        public string Icephone { get; set; }
        public int OrthoMonthsTreatOverride { get; set; }
        public DateTime DateOrthoPlacementOverride { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public sbyte Consent { get; set; }
    }
}
