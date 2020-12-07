using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Allergy
    {
        public long AllergyNum { get; set; }
        public long AllergyDefNum { get; set; }
        public long PatNum { get; set; }
        public string Reaction { get; set; }
        public sbyte StatusIsActive { get; set; }
        public DateTime DateTstamp { get; set; }
        public DateTime DateAdverseReaction { get; set; }
        public string SnomedReaction { get; set; }
    }
}
