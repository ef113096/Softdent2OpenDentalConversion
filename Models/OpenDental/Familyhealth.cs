using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Familyhealth
    {
        public long FamilyHealthNum { get; set; }
        public long PatNum { get; set; }
        public sbyte Relationship { get; set; }
        public long DiseaseDefNum { get; set; }
        public string PersonName { get; set; }
    }
}
