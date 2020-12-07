using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Erxlog
    {
        public long ErxLogNum { get; set; }
        public long PatNum { get; set; }
        public string MsgText { get; set; }
        public DateTime DateTstamp { get; set; }
        public long ProvNum { get; set; }
        public long UserNum { get; set; }
    }
}
