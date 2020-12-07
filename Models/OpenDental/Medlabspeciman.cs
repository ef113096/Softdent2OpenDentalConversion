using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medlabspeciman
    {
        public long MedLabSpecimenNum { get; set; }
        public long MedLabNum { get; set; }
        public string SpecimenId { get; set; }
        public string SpecimenDescript { get; set; }
        public DateTime DateTimeCollected { get; set; }
    }
}
