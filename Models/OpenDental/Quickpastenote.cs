using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Quickpastenote
    {
        public long QuickPasteNoteNum { get; set; }
        public long QuickPasteCatNum { get; set; }
        public ushort ItemOrder { get; set; }
        public string Note { get; set; }
        public string Abbreviation { get; set; }
    }
}
