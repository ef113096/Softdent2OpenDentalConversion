using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Popup
    {
        public long PopupNum { get; set; }
        public long PatNum { get; set; }
        public string Description { get; set; }
        public bool IsDisabled { get; set; }
        public sbyte PopupLevel { get; set; }
        public long UserNum { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public sbyte IsArchived { get; set; }
        public long PopupNumArchive { get; set; }
    }
}
