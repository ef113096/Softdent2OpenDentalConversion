using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Printer
    {
        public long PrinterNum { get; set; }
        public long ComputerNum { get; set; }
        public byte PrintSit { get; set; }
        public string PrinterName { get; set; }
        public byte DisplayPrompt { get; set; }
    }
}
