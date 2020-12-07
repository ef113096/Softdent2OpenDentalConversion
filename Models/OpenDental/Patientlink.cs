using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patientlink
    {
        public long PatientLinkNum { get; set; }
        public long PatNumFrom { get; set; }
        public long PatNumTo { get; set; }
        public sbyte LinkType { get; set; }
        public DateTime DateTimeLink { get; set; }
    }
}
