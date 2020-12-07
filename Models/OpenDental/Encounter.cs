using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Encounter
    {
        public long EncounterNum { get; set; }
        public long PatNum { get; set; }
        public long ProvNum { get; set; }
        public string CodeValue { get; set; }
        public string CodeSystem { get; set; }
        public string Note { get; set; }
        public DateTime DateEncounter { get; set; }
    }
}
