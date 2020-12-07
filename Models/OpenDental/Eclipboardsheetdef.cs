using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Eclipboardsheetdef
    {
        public long EclipboardSheetDefNum { get; set; }
        public long SheetDefNum { get; set; }
        public long ClinicNum { get; set; }
        public long ResubmitInterval { get; set; }
        public int ItemOrder { get; set; }
    }
}
