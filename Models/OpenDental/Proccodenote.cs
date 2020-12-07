using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Proccodenote
    {
        public long ProcCodeNoteNum { get; set; }
        public long CodeNum { get; set; }
        public long ProvNum { get; set; }
        public string Note { get; set; }
        public string ProcTime { get; set; }
        public sbyte ProcStatus { get; set; }
    }
}
