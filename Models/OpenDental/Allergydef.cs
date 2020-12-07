using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Allergydef
    {
        public long AllergyDefNum { get; set; }
        public string Description { get; set; }
        public sbyte IsHidden { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte? SnomedType { get; set; }
        public long MedicationNum { get; set; }
        public string UniiCode { get; set; }
    }
}
