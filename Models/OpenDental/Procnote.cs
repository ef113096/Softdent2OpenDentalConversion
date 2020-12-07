using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procnote
    {
        public long ProcNoteNum { get; set; }
        public long PatNum { get; set; }
        public long ProcNum { get; set; }
        public DateTime EntryDateTime { get; set; }
        public long UserNum { get; set; }
        public string Note { get; set; }
        public byte SigIsTopaz { get; set; }
        public string Signature { get; set; }
    }
}
