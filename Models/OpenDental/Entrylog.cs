using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Entrylog
    {
        public long EntryLogNum { get; set; }
        public long UserNum { get; set; }
        public sbyte FkeyType { get; set; }
        public long Fkey { get; set; }
        public sbyte LogSource { get; set; }
        public DateTime EntryDateTime { get; set; }
    }
}
