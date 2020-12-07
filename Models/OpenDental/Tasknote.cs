using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Tasknote
    {
        public long TaskNoteNum { get; set; }
        public long TaskNum { get; set; }
        public long UserNum { get; set; }
        public DateTime DateTimeNote { get; set; }
        public string Note { get; set; }
    }
}
