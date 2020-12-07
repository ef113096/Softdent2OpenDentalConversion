using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Programproperty
    {
        public long ProgramPropertyNum { get; set; }
        public long ProgramNum { get; set; }
        public string PropertyDesc { get; set; }
        public string PropertyValue { get; set; }
        public string ComputerName { get; set; }
        public long ClinicNum { get; set; }
    }
}
