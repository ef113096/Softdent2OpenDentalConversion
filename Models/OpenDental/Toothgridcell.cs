using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Toothgridcell
    {
        public long ToothGridCellNum { get; set; }
        public long SheetFieldNum { get; set; }
        public long ToothGridColNum { get; set; }
        public string ValueEntered { get; set; }
        public string ToothNum { get; set; }
    }
}
