using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Autonote
    {
        public long AutoNoteNum { get; set; }
        public string AutoNoteName { get; set; }
        public string MainText { get; set; }
        public long Category { get; set; }
    }
}
