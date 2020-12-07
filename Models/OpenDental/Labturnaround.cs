using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Labturnaround
    {
        public long LabTurnaroundNum { get; set; }
        public long LaboratoryNum { get; set; }
        public string Description { get; set; }
        public short DaysPublished { get; set; }
        public short DaysActual { get; set; }
    }
}
