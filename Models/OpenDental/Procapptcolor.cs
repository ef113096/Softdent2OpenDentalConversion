using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procapptcolor
    {
        public long ProcApptColorNum { get; set; }
        public string CodeRange { get; set; }
        public int ColorText { get; set; }
        public sbyte ShowPreviousDate { get; set; }
    }
}
