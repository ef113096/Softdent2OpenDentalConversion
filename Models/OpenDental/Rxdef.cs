using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Rxdef
    {
        public long RxDefNum { get; set; }
        public string Drug { get; set; }
        public string Sig { get; set; }
        public string Disp { get; set; }
        public string Refills { get; set; }
        public string Notes { get; set; }
        public sbyte IsControlled { get; set; }
        public long RxCui { get; set; }
        public sbyte IsProcRequired { get; set; }
        public string PatientInstruction { get; set; }
    }
}
