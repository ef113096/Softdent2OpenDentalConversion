using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabnote
    {
        public long EhrLabNoteNum { get; set; }
        public long EhrLabNum { get; set; }
        public long EhrLabResultNum { get; set; }
        public string Comments { get; set; }
    }
}
