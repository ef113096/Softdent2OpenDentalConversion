using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medicalorder
    {
        public long MedicalOrderNum { get; set; }
        public sbyte MedOrderType { get; set; }
        public long PatNum { get; set; }
        public DateTime DateTimeOrder { get; set; }
        public string Description { get; set; }
        public sbyte IsDiscontinued { get; set; }
        public long ProvNum { get; set; }
    }
}
