using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Cdspermission
    {
        public long CdspermissionNum { get; set; }
        public long UserNum { get; set; }
        public sbyte SetupCds { get; set; }
        public sbyte ShowCds { get; set; }
        public sbyte ShowInfobutton { get; set; }
        public sbyte EditBibliography { get; set; }
        public sbyte ProblemCds { get; set; }
        public sbyte MedicationCds { get; set; }
        public sbyte AllergyCds { get; set; }
        public sbyte DemographicCds { get; set; }
        public sbyte LabTestCds { get; set; }
        public sbyte VitalCds { get; set; }
    }
}
