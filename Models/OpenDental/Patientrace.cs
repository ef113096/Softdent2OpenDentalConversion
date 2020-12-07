using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patientrace
    {
        public long PatientRaceNum { get; set; }
        public long PatNum { get; set; }
        public sbyte Race { get; set; }
        public string CdcrecCode { get; set; }
    }
}
